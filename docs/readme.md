# Telegram-API NET Documentation
[![NuGet version (Telegram_API)](https://img.shields.io/nuget/v/Telegram_API.svg?style=flat-square)](https://www.nuget.org/packages/Telegram_API/)

## Getting started
To get started you just need to start a new BotClient as follows.
```CSharp
var MyBot = new BotClient(YoutAccessTokenString);
```
By adding the respective namespaces you will be able to use the extension methods for the instance you just created. For example, if you want to use the "GetChat" method you should include the namespace "TelegramAPI.Available_Methods" to use method as follows.
```CSharp
using TelegramAPI.Available_Methods; //Contains methods
```
```CSharp
var result = Bot.GetChat(chat_id); //returns a Chat object available in "TelegramAPI.Available_Types"
```
In the event of any error in any request, a BotRequestException will be thrown, which will include an object with the error information.
## Namespaces
All methods and object types used in the Telegram Bot API are separated into namespaces, with the same names of the sections in which they are organized on the official Telegram Bot API website. The available namespaces are shown below.

| Name | Description |
| :---|:---|
| TelegramAPI | Contains the BotClient and other base utilities |
| TelegramAPI.Getting_updates |Contains methods and types for getting updates |
| TelegramAPI.Available_Types | Contains available types |
| TelegramAPI.Available_Methods | Contains available methods |
| TelegramAPI.Updating_messages | Contains methods and types for updating messages |
| TelegramAPI.Stickers | Contains methods and types for stickers |
| TelegramAPI.Inline_mode | Contains methods and types for inline mode |
| TelegramAPI.Payments | Contains methods and types for payments |
| TelegramAPI.Telegram_Passport | Contains methods and types for Telegram Pasport |
| TelegramAPI.Games | Contains methods and types for games |

For more detail of what each method does and the properties of each type, it is recommended to consult on the official website of the [Telegram Bot API](https://core.telegram.org/bots/api) while using the library.

## Examples
- [Send Messages](###Send-Messages)
- [Upload files](###Upload-files)
- [Asynchronous methods](###Asynchronous-methods)

### Send Messages
Sending messages examples

#### Send message text

```CSharp
using TelegramAPI;
using TelegramAPI.Available_Methods

var bot = new BotClient(token);
bot.SendMessage(chat_id, "Message Text");
```
#### Send message photo
```CSharp
using TelegramAPI.Available_Methods

var bot = new BotClient(token);
bot.SendPhoto(new SendPhotoArgs
    {
        Chat_id = chat_id,
        Photo = photoid
    });
```

### Upload files
Depending on the method used. You can send attach files in two ways.

The first way is to pass an inputfile object in the respective field. The second way is to add AttachFile objects in the AttachFiles field and pass "attach://\<attachfilename\>" in all the file fields you require.

#### Option 1
```CSharp
using TelegramAPI;
using TelegramAPI.Available_Types;
using TelegramAPI.Available_Methods

var bot = new BotClient(token);
bot.SendDocument(
    new SendDocumentArgs
    {
        Chat_id = chat_id,
        Document = new InputFile(filebytes, "file.zip")
    }); //upload document
```
#### Option 2
```CSharp
using TelegramAPI;
using TelegramAPI.Available_Types;
using TelegramAPI.Available_Methods

var bot = bot.SendDocument(
    new SendDocumentArgs
    {
        Chat_id = chat_id,
        Document = "attach://file56",
        AttachFiles = new AttachFile[]
        {
            new AttachFile("file56",
                new InputFile(filebytes, "file.zip"))
        }
    }); //upload document
```
### Asynchronous methods
All available methods have an alternative asynchronous method. These methods have the same name but with Async termination. The way you pass parameters is exactly the same as normal methods.

For example, sending a text message asynchronously would be something like this:
```CSharp
using TelegramAPI;
using TelegramAPI.Available_Methods

var bot = new BotClient(token);
await bot.SendMessageAsync(chat_id, "Message Text");
```