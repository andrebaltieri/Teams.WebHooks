namespace Teams.WebHooks.Entities;

/// <summary>
/// Represents a multiple-choice input field for Teams message cards.
/// </summary>
public class InputMultiChoice : Input
{
    public InputMultiChoice()
    {
        Type = "MultiChoiceInput";
    }
    
    public string Style { get; set; } = "expanded";
    public List<InputMultiChoiceItem> Choices { get; set; } = [];
}