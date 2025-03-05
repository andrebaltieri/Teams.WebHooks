using System.Text.Json.Serialization;

namespace Teams.WebHooks.Entities;

public class Message
{
    [JsonPropertyName("@type")] 
    public string Type { get; set; } = "MessageCard";
    [JsonPropertyName("@context")] 
    public string Context { get; set; } = "http://schema.org/extensions";
    public string ThemeColor { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public List<Section> Sections { get; set; } = [];
    public List<PotentialAction> PotentialAction { get; set; } = [];
}