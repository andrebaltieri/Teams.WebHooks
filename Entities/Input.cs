using System.Text.Json.Serialization;

namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents an input field for Teams message cards.
/// </summary>
public class Input
{
    [JsonPropertyName("@type")] 
    public string Type { get; set; } = "TextInput";
    public string Id { get; set; } = string.Empty;
    public bool IsMultiline { get; set; }
    public string Title { get; set; } = string.Empty;
}