using System.Text.Json.Serialization;

namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents an action item for a potential action in a Teams message card.
/// </summary>
public class ActionItem
{
    [JsonPropertyName("@type")] 
    public string Type { get; set; } = "HttpPOST";
    public string Name { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}