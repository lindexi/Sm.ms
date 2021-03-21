using System;
using System.IO;

namespace Sm.ms.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Options options = null;
            if (args.Length == 2)
            {
                options = new Options()
                {
                    ApiKey = args[0],
                    FilePath = args[1]
                };
            }

            if (options != null)
            {
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