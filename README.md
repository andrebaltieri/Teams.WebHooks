# Microsoft Teams - Send a message to a channel
This package will help you to send a message to a channel in Microsoft Teams.

## Creating a WebHook
The first step you need to do is create an **Incoming WebHook** in your Teams channel. Just open a teams channel and click on the **..** button on top right corner and select **Connectors**.

On the new screen, search for **Incoming WebHooks** and click on **Add**. Copy the generated URL.

## Installing the package
To install the package, run the following command in the root of your project:
```
dotnet add package Teams.WebHooks
```

## Creating a message
Moving to your code, first we`ll need to create a card like this:
```csharp
var card = new Message();
card.ThemeColor = "8625D2";
card.Summary = "Some summary here";
```

### Sections
A card can be composed of many sections and we need at least one section to send a message.

```csharp
card.Sections.Add(new Section
{
    ActivityTitle = "Section Title here",
    ActivitySubtitle = "Section Subtitle here",
    ActivityImage = "https://some-image.png",    
    Markdown = true,
});
```

#### Facts
You can have as many facts as you want, they will be shown in a separeted place of the card.

```csharp
card.Sections.Add(new Section
{
    ActivityTitle = "Section Title here",
    ActivitySubtitle = "Section Subtitle here",
    ActivityImage = "https://some-image.png",    
    Markdown = true,
    Facts = new List<Fact>()
    {
        new()
        {
            Name = "Assigned to",
            Value = "some@email.com"
        },
        new()
        {
            Name = "Due date",
            Value = "27/07/2021"
        },
        new()
        {
            Name = "Status",
            Value = "Active"
        }
    },
});

```

## Potential Actions
Cards can have potential actions, which are actions that can be taken when clicking on the buttons.

```csharp
card.PotentialAction.Add(new PotentialAction
{
    Name = "Comentar",
    Inputs = new List<Input>()
    {
        new() {Id = "email", Title = "Email here", Type = "TextInput", IsMultiline = false},
        new() {Id = "date", Title = "Date", Type = "DateInput", IsMultiline = false},
        new InputMultiChoice()
        {
            Id = "mult", Title = "Data", Type = "DateInput", IsMultiline = false, Choices =
                new List<InputMultiChoiceItem>()
                {
                    new() {Display = "item 1", Value = "1"},
                    new() {Display = "item 2", Value = "2"},
                }
        },
    },
    Actions = new List<ActionItem>()
    {
        new()
        {
            Body = "comment={{email.value}}", // Capture the value of the input
            Name = "Aprove",
            Target = "https://your-api-endpoint"
        }
    }
});
```

## Sending the message

```csharp
var result = await MessageClient.SendAsync(YOUR_WEBHOOK_URL, card);
Console.WriteLine(result);
```