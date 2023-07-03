using System;
using System.IO;
using System.Net.Http;

namespace Bounceless
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            VerifySingleEmail("PUT YOUR KEY HERE", "emailtoverify@example.com");
            UploadFile("PUT YOUR KEY HERE", "path\\to\\your\\file.csv");
            GetFileInfo("PUT YOUR KEY HERE", "FILE_ID");
        }

        static void VerifySingleEmail(string key, string email)
        {
            string url = $"https://apps.bounceless.io/api/singlemaildetails?secret={key}&email={email}";
            var response = client.GetAsync(url).Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }

        static void UploadFile(string key, string filePath)
        {
            string url = $"https://apps.bounceless.io/api/verifyApiFile?secret={key}&filename={Path.GetFileName(filePath)}";
            using var content = new MultipartFormDataContent();
            using var fileStream = File.OpenRead(filePath);
            content.Add(new StreamContent(fileStream), "file", Path.GetFileName(filePath));
            var response = client.PostAsync(url, content).Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }

        static void GetFileInfo(string key, string fileId)
        {
            string url = $"https://apps.bounceless.io/api/getApiFileInfo?secret={key}&id={fileId}";
            var response = client.GetAsync(url).Result;
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }
}
