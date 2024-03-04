using System.Net.Http.Json;
using TestProject.Model;

namespace TestProject.Services
{
    public class MonkeyService
    {
        HttpClient _httpClient;

        public MonkeyService()
        {
            _httpClient = new HttpClient();
        }

        List<Monkey> monkeys = new();
        public async Task<List<Monkey>> GetMonkeys()
        {
            if (monkeys?.Count > 0)
                return monkeys;
            var url = "https://montemagno.com/monkeys.json";

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                monkeys = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            return monkeys;
        }
    }
}
