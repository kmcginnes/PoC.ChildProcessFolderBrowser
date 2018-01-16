using System;
using System.Diagnostics;
using System.Text;

namespace HostProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            var processStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                FileName = "OpenFileDialogProcess.exe"
            };

            var process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true,
            };

            var output = new StringBuilder();

            process.Start();
            process.BeginOutputReadLine();

            process.OutputDataReceived += (sender, eventArgs) => { output.AppendLine(eventArgs.Data); };

            process.WaitForExit();
            process.CancelOutputRead();

            Console.WriteLine($"User chose the following file path: {output}");
            Console.ReadKey();
        }
    }
}