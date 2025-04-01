namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents a section within a Teams message card.
/// </summary>
public class Section
{
    public string ActivityTitle { get; set; } = string.Empty;
    public string ActivitySubtitle { get; set; } = string.Empty;
    public string ActivityImage { get; set; } = string.Empty;
    public List<Fact> Facts { get; set; } = [];
    public bool Markdown { get; set; }
}