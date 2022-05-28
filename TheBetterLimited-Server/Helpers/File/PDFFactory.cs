using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using System.Runtime.InteropServices;

namespace TheBetterLimited_Server.Helpers.File
{
    public class PDFFactory
    {
        public static PDFFactory Instance = new PDFFactory();
        private Process _process;
        
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