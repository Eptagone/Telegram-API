# Telegram-API
 Telegram API NET.
 
 Telegram API NET is one of the most complete libraries available to interact with the Telegram Bot API in your .NET projects. Free and open source.

 It contains all the methods available in the API 4.4 Bot released on July 29, 2019. In addition, it has a complete set of classes with all the objects used.

 All objects and methods are sorted in namespaces in the same order of sections as on the official Website of the [Telegram Bot API](https://core.telegram.org/bots/api).

 ## Features
* Contains pre-defined methods for all Bot API 4.4 methods.
* Contains classes for each object type used in the Bot API 4.4
* Uses [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## How to use
You just need to initialize a new instance as follows.
```
var Bot = new BotClient(accessTokenString);
```
By adding the respective namespaces you will be able to use the extension methods for the instance you just created. For example, if you want to use the "GetChat" method you should include the namespace "TelegramAPI.Available_Methods" to use method as follows.
```
using TelegramAPI.Available_Methods; //Contains methods
...

var result = Bot.GetChat(chat_id); //returns a Chat object available in "TelegramAPI.Available_Types"
```
In the event of any error in any request, a BotRequestException will be thrown, which will include an object with the error information.
### Namespaces list
| Name | Description |
| :---|:---|
| TelegramAPI | Constains BotClient |
| TelegramAPI.Getting_updates |Contains methods and types for getting updates |
| TelegramAPI.Available_Types | Contains available types |
| TelegramAPI.Available_Methods | Contains available methods |
| TelegramAPI.Updating_messages | Contains methods and types for updating messages |
| TelegramAPI.Stickers | Contains methods and types for stickers |
| TelegramAPI.Inline_mode | Contains methods and types for inline mode |
| TelegramAPI.Payments | Contains methods and types for payments |
| TelegramAPI.Telegram_Passport | Contains methods and types for Telegram Pasport |
| TelegramAPI.Games | Contains methods and types for games |

## License
MIT

## Version
**1.0.5**