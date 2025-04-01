using System.Text;
using System.Text.Json;
using Teams.WebHooks.Entities;

namespace Teams.WebHooks;

/// <summary>
/// Sends messages to Microsoft Teams webhooks.
/// </summary>
public static class MessageClient
{
    /// <summary>
    /// Sends a message card to the specified Microsoft Teams webhook URL.
    /// </summary>
    /// <param name="url">The webhook URL.</param>
    /// <param name="card">The message card to send.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>True if the message was sent successfully; otherwise, false.</returns>
    public static async Task<bool> SendAsync(string url, Message card, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(card);
        var client = new HttpClient();
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var result = await client.PostAsync(url, content, cancellationToken);
        return result.IsSuccessStatusCode;
    }
}