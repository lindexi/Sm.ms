using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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
            httpClient.DefaultRequestHeaders.Add("Authorization", ApiToken);

            var multipartFormDataContent = new MultipartFormDataContent();
            HttpContent fileContent = new StreamContent(image);
            multipartFormDataContent.Add(fileContent, "smfile", fileName);

            var url = "https://sm.ms/api/v2/upload";

            var httpResponseMessage = await httpClient.PostAsync(url, multipartFormDataContent);
           return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}