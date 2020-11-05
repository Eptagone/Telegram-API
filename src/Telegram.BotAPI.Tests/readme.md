# Telegram.BotAPI NET Tests
[![NuGet version (Telegram.BotAPI)](https://img.shields.io/nuget/v/Telegram.BotAPI.svg?style=flat-square)](https://www.nuget.org/packages/Telegram.BotAPI/)
[![Compatible with Bot API v5.0](https://img.shields.io/badge/Bot%20API%20version-v5.0-blue?style=flat-square)](https://core.telegram.org/bots/api#november-4-2020)

## Summary
This is a unit test project in which you run test procedures using the Telegram API NET project.

## Important
If you want to run the unit tests, you must edit the following fields in the **Settings.cs** file so that the tests can run successfully.

| Field | Description |
|-----|-----|
| Bot | Use your own access token to initialize the bot client. You must first create a test bot with botfather and get the access token. |
| PChatId | Write the private chat id where you will run the unit tests |
| ChatId | Write the group chat id where you will run the unit tests |
| ChannelId | Write the channel chat id where you will run the unit tests |
| PhotoFileId | Replace with a photo file id from telegram servers. |
| VideoFileId | Replace with a video file id from telegram servers. |
| DocFileId | Replace with a document file id from telegram servers. |

