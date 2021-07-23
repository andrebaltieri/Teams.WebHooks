using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Teams.WebHooks
{
    public static class MessageClient
    {
        public static async Task<bool> SendAsync(string url, Message card)
        {
            var json = JsonSerializer.Serialize(card);
            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            return result.IsSuccessStatusCode;
        }
    }
}