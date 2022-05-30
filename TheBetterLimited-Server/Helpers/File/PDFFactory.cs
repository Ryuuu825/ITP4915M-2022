using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;


namespace TheBetterLimited_Server.Helpers.File
{
    public class PDFFactory : IDisposable
    {

        public static PDFFactory Instance = new PDFFactory();
        private Process _process;
        private bool isDisposed = false;

        public void Dispose()
        {
            if (! isDisposed)
            {
                if (_process != null)
                {
                    _process.Dispose();
                    Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + "/Lib", true);

                if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + ".DS_Store"))
                {
                    System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + ".DS_Store");
                }
                if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/__MACOSX"))
                {
                    Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + "/__MACOSX" , true);
                }
                }
            }
        }
        
        public PDFFactory()
        {
            _process = new Process();
            string os = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                os = "win";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                os = "linux";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                os = "osx";
            }

            var arch = RuntimeInformation.OSArchitecture.ToString().ToLower();

            ConsoleLogger.Debug($"{os}-{arch}");
            TheBetterLimited_Server.Helpers.File.ZipHelper.Decompress("/Lib.zip", "");


            string FileName = $"Lib/wkhtmltopdf/{os}-{arch}/wkhtmltopdf";
            var startInfo = new ProcessStartInfo
            {
                FileName = FileName,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
            };
            _process.StartInfo = startInfo;
        }
        public byte[] Create(string HtmlContent)
        {
            _process.Start();
            string savePath = AppDomain.CurrentDomain.BaseDirectory + "/var/tmp/temp.pdf";
            _process.StartInfo.Arguments = $" {HtmlContent} {savePath}";
            _process.Start();
            // get the output of the process
            var output = _process.StandardOutput.ReadToEnd();
            var error = _process.StandardError.ReadToEnd();

            ConsoleLogger.Debug(
                "Output of the process: " + output + "\n" + "Error of the process: " + error);
            _process.WaitForExit();

            while (!_process.HasExited)
            {
                Thread.Sleep(200);
            }
            return System.IO.File.ReadAllBytes(savePath);
        } 
        public async Task<byte[]> Create<T>(List<T> list)
        {
            // get headers from the attributes of the item with type T
            StringBuilder header = new StringBuilder();
            var Instance = Activator.CreateInstance<T>();
            foreach(var item in Instance.GetType().GetProperties())
            {
                // ignore the properties that are not mapped to dto and is a class or collection
                if  (    
                        System.Attribute.IsDefined(item , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        item.PropertyType is ICollection || 
                        item.GetAccessors()[0].IsVirtual
                    )
                    continue;

                header.Append($"<th scope=\"col\">{item.Name}</th>");
            }

            // create the html table
            /**
                <tr>
                    <th scope="row">1</th>
                    <td>Mark</td>
                    <td>Otto</td>
                    <td>@mdo</td>
                </tr>
             */
            StringBuilder table = new StringBuilder();
            foreach(var item in list)
            {
                table.Append($"<tr>");
                foreach(var prop in item.GetType().GetProperties())
                {
                    if (    
                        System.Attribute.IsDefined(prop , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        prop.PropertyType is ICollection || 
                        prop.GetAccessors()[0].IsVirtual // a foreign key object
                    )
                        continue;
                    table.Append($"<td>{prop.GetValue(item)}</td>");
                }
                table.Append($"</tr>");
            }

            List<AppLogic.Models.UpdateObjectModel> content = new List<AppLogic.Models.UpdateObjectModel>
            {
                new AppLogic.Models.UpdateObjectModel
                {
                    Attribute = "record",
                    Value = typeof(T).Name
                },
                new AppLogic.Models.UpdateObjectModel
                {
                    Attribute = "header",
                    Value = header.ToString()
                },
                new AppLogic.Models.UpdateObjectModel
                {
                    Attribute = "body",
                    Value = table.ToString()
                }
            };

            string temp = Helpers.File.DynamicFile.UpdatePlaceHolder("template/Records.html" , content);

            // create a html file for wkhtmltopdf to convert
            string htmlFilePath = AppDomain.CurrentDomain.BaseDirectory+ "var/tmp/record.html";
            using (FileStream fs = new FileStream(htmlFilePath, FileMode.OpenOrCreate))
            {
                await fs.WriteAsync(Encoding.UTF8.GetBytes(temp));
            }
            return Create(htmlFilePath);
        } 

    }

    internal class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }
        protected override IntPtr LoadUnmanagedDll(String unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            throw new NotImplementedException();
        }
    }
}