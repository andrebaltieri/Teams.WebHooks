namespace Teams.WebHooks.Entities;

public class InputMultiChoice : Input
{
    public string Style { get; set; } = "expanded";
    public List<InputMultiChoiceItem> Choices { get; set; } = [];
}