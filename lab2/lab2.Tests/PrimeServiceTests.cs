using NUnit.Framework;
using System;
using System.IO;
using System.Diagnostics;

namespace lab2.Tests
{
    [TestFixture]
    public class PrimeServiceTest
    {
        private const string exePath = "lab2.exe"; 

        [Test]
        public void Main_ValidInput_PrintsTrue()
        {
            var result = RunProcessWithInput("5");
            Assert.AreEqual("true", result.stdout.Trim());
            Assert.AreEqual("", result.stderr.Trim());
            Assert.AreEqual(0, result.exitCode);
        }

        [Test]
        public void Main_InvalidInput_PrintsErrorAndExitCode1()
        {
            var result = RunProcessWithInput("notanumber");
            Assert.AreEqual("", result.stdout.Trim());
            Assert.IsTrue(result.stderr.Trim().Contains("Invalid input"));
            Assert.AreEqual(1, result.exitCode);
        }

        private (string stdout, string stderr, int exitCode) RunProcessWithInput(string input)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = exePath,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

            using (var writer = process.StandardInput)
            {
                writer.WriteLine(input);
            }

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            return (output, error, process.ExitCode);
        }
    }
}
