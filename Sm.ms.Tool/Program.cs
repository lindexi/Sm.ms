using System;
using System.IO;
using dotnetCampus.Cli;

namespace Sm.ms.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLine = CommandLine.Parse(args);
            Options? options = commandLine.As<Options>();

            if (options != null)
            {
                if (string.IsNullOrEmpty(options.FilePath) || !File.Exists(options.FilePath))
                {
                    Console.WriteLine($"找不到文件 {options.FilePath}");
                    return;
                }

                if (string.IsNullOrEmpty(options.ApiKey))
                {
                    Console.WriteLine($"没有 API Key 不能上传图片，请到 sm.ms 注册");
                    return;
                }

                var smms = new Smms(options.ApiKey);
                var response = smms.UploadImageAsync(new FileInfo(options.FilePath), Path.GetRandomFileName() + ".png")
                    .Result;
                if (response.Success)
                {
                    Console.WriteLine(response.Data?.Url);
                }
                else
                {
                    Console.WriteLine("Upload Fail. " + response.Message);
                }
            }
        }
    }
}