using dotnetCampus.Cli;

namespace Sm.ms.Tool
{
    public class Options
    {
        [Option('k', nameof(ApiKey), Description = "密钥，用来上传到sm.ms注册账户下")]
        public string ApiKey { get; set; } = null!;

        [Option('f', "File", Description = "要上传的图片路径")]
        public string FilePath { get; set; } = null!;
    }
}