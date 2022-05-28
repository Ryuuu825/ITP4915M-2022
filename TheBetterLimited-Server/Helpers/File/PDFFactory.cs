using System.Runtime.InteropServices;
using DinkToPdf;
using DinkToPdf.Contracts;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using System.Runtime.InteropServices;

namespace TheBetterLimited_Server.Helpers.File
{
    public class PDFFactory
    {
        public static PDFFactory Instance = new PDFFactory();
        private IConverter _converter;
        private Process _process;
        
        public PDFFactory()
        {
            // if (RuntimeInformation.OSArchitecture == Architecture.Arm64 && RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            // {
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
                _converter = null;
            // }
            // else 
            // {
            //     CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
            //     if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            //     {
            //         context.LoadUnmanagedLibrary(AppDomain.CurrentDomain.BaseDirectory + "libwkhtmltox.dll");
            //     }
            //     // else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            //     // {
            //     //     context.LoadUnmanagedLibrary(AppDomain.CurrentDomain.BaseDirectory + "libwkhtmltox.dylib");
            //     // }
            //     _converter = new SynchronizedConverter(new PdfTools());
            //     _process = null;
            // }
        }
        public byte[] Create(string HtmlContent)
        {
            // if (RuntimeInformation.OSArchitecture == Architecture.Arm64 && RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            // {   
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

                for(int i = 0 ; i < 2 ; i++)
                {
                    if (_process.HasExited)
                    {
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
                return System.IO.File.ReadAllBytes(savePath);
            // }
            // else 
            // {
            //     return new byte[]{};
            // }
                
// string htmlString = "<h1>Document</h1> <p>This is an HTML document which is converted to a pdf file.</p>";
            
//             var doc = new HtmlToPdfDocument()
//             { 
//                 GlobalSettings = {
//                     ColorMode = ColorMode.Color,
//                     Orientation = Orientation.Landscape,
//                     PaperSize = PaperKind.A4Plus,
//                 },
//                 Objects = {
//                     new ObjectSettings() {
//                         PagesCount = true,
//                         HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
//                         WebSettings = { DefaultEncoding = "utf-8" },
//                         HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
//                     }
//                 }
//             };

//             return _convertor.Convert(doc);
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