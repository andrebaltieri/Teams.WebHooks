using System.Text.Json.Serialization;

namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents a potential action for a Teams message card.
/// </summary>
public class PotentialAction
{
    [JsonPropertyName("@type")] 
    public string Type { get; set; } = "ActionCard";
    public string Name { get; set; } = string.Empty;
    public List<Input> Inputs { get; set; } = [];
    public List<ActionItem> Actions { get; set; } = [];
}