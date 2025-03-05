using System.Text.Json.Serialization;

namespace Teams.WebHooks.Entities;

public class ActionItem
{
    [JsonPropertyName("@type")] 
    public string Type { get; set; } = "HttpPOST";
    public string Name { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}