namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents a fact entry in a Teams message section.
/// </summary>
public class Fact
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}