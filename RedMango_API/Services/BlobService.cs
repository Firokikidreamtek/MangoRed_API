
using Newtonsoft.Json;
using RedMango_API.Models;

namespace RedMango_API.Services
{
    public class BlobService : IBlobService
    {
        private WebApplicationBuilder builder;
        private string apiKey;
        private string url;
        private readonly string connectionToImgBB;
        private HttpClient client;
        private MultipartFormDataContent content;

        public BlobService()
        {
            builder = WebApplication.CreateBuilder();
            url = builder.Configuration.GetConnectionString("ImgBB");
            apiKey = builder.Configuration.GetValue<string>("ApiSettings:ApiKeyImgBB");
            connectionToImgBB = url + $"?key={apiKey}";
            client = new HttpClient();
            content = new MultipartFormDataContent();
        }

        public async Task<string> UploadBlob(IFormFile file)
        {
            var b64 = ConvertFileToByteArray(file);
            content.Add(new StringContent(b64));
            var request = new HttpRequestMessage(HttpMethod.Post, connectionToImgBB) { Content = content };
            var rarResponse = await client.SendAsync(request);
            var cleanResponse = rarResponse.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Parent>(cleanResponse);
            return result.Data.Url;
        }

        private string ConvertFileToByteArray(IFormFile file)
        {
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();
            string s = Convert.ToBase64String(fileBytes);
            return s;

        }
    }
}
