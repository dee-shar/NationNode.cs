using System.Net.Http;

namespace NationNodeApi
{
    public class NationNode
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://countries-api-abhishek.vercel.app";
        public NationNode()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetCountries()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/countries");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCountry(string country)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/countries/{country}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
