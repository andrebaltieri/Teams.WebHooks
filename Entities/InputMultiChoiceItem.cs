namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents an item in a multiple-choice input field.
/// </summary>
public class InputMultiChoiceItem
{
    public string Display { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}