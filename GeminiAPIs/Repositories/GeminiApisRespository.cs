using GeminiAPIs.Interfaces;
using Newtonsoft.Json;
using System.Text;
using static GeminiAPIs.Models.GeminiAPIModels;

namespace GeminiAPIs.Repositories
{
    public class GeminiApisRespository : IAIRepository
    {
        private string apiKey = "AIzaSyCKTl74pIFhZx97Cvy2AXZXdQ9Thxmd6Xw";

        public async Task<string> DevuelveRespuestaAI(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key="+apiKey;

            Root request = new Root
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        parts = new List<Part>
                        {
                            new Part
                            {
                                text = prompt,
                            }
                        }
                    }
                }
            };

            string jsonData = JsonConvert.SerializeObject(request);

            using(HttpClient client = new HttpClient())
            {
                try
                {
                    var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, stringContent);
                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsStringAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
