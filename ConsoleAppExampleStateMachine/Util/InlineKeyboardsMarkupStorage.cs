using Telegram.Bot.Types.ReplyMarkups;

namespace ConsoleAppExampleStateMachine.Util;

public class InlineKeyboardsMarkupStorage
{
    public static InlineKeyboardMarkup MenuMain = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonsStorage.FirstButtonInMenuMain.Name,
                BotButtonsStorage.FirstButtonInMenuMain.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonsStorage.SecondButtonInMenuMain.Name,
                BotButtonsStorage.SecondButtonInMenuMain.CallBackData),
        },
        new[]
        {
        InlineKeyboardButton.WithCallbackData(BotButtonsStorage.BackButtonInMenuMain.Name,
        BotButtonsStorage.BackButtonInMenuMain.CallBackData),
        }
    });
}