using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sm.ms
{
    public class Smms
    {
        public Smms(string apiToken)
        {
            ApiToken = apiToken;
        }

        private string ApiToken { get; }

        public async Task<string> UploadImage(Stream image, string fileName)
        {
            using var httpClient = new HttpClient();

            if (!string.IsNullOrEmpty(ApiToken))
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", ApiToken);
            }

            httpClient.DefaultRequestHeaders.UserAgent.Clear();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0");

            var multipartFormDataContent = new MultipartFormDataContent();
            HttpContent fileContent = new StreamContent(image);
            multipartFormDataContent.Add(fileContent, "smfile", fileName);

            const string url = "https://sm.ms/api/v2/upload";

            var httpResponseMessage = await httpClient.PostAsync(url, multipartFormDataContent).ConfigureAwait(false);
            return await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
        } 

        public async Task<SmmsResponseBase<UploadImageResponse>> UploadImageAsync(Stream image, string fileName)
        {
            var json = await UploadImage(image, fileName);
            return JsonConvert.DeserializeObject<SmmsResponseBase<UploadImageResponse>>(json);
        }

        public async Task<SmmsResponseBase<UploadImageResponse>> UploadImageAsync(FileInfo imageFile, string fileName = null)
        {
            fileName ??= imageFile.Name;

            using var fileStream = imageFile.OpenRead();
            return await UploadImageAsync(fileStream, fileName);
        }
    }
}