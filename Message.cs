using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Teams.WebHooks
{
    public class Fact
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Section
    {
        public string ActivityTitle { get; set; }
        public string ActivitySubtitle { get; set; }
        public string ActivityImage { get; set; }
        public List<Fact> Facts { get; set; } = new();
        public bool Markdown { get; set; }
    }

    public class Input
    {
        [JsonPropertyName("@type")] public string Type { get; set; } = "TextInput";
        public string Id { get; set; }
        public bool IsMultiline { get; set; }
        public string Title { get; set; }
    }

    public class InputMultiChoiceItem
    {
        public string Display { get; set; }
        public string Value { get; set; }
    }

    public class InputMultiChoice : Input
    {
        public string Style { get; set; } = "expanded";
        public List<InputMultiChoiceItem> Choices { get; set; } = new();
    }

    public class ActionItem
    {
        [JsonPropertyName("@type")] public string Type { get; set; } = "HttpPOST";

        public string Name { get; set; }
        public string Target { get; set; }
        public string Body { get; set; }
    }

    public class PotentialAction
    {
        [JsonPropertyName("@type")] public string Type { get; set; } = "ActionCard";
        public string Name { get; set; }
        public List<Input> Inputs { get; set; } = new();
        public List<ActionItem> Actions { get; set; } = new();
    }

    public class Message
    {
        [JsonPropertyName("@type")] public string Type { get; set; } = "MessageCard";
        [JsonPropertyName("@context")] public string Context { get; set; } = "http://schema.org/extensions";
        public string ThemeColor { get; set; }
        public string Summary { get; set; }
        public List<Section> Sections { get; set; } = new();
        public List<PotentialAction> PotentialAction { get; set; } = new();
    }
}