using ConsoleAppExampleStateMachine.Bot.Router;
using ConsoleAppExampleStateMachine.Util;

namespace ConsoleAppExampleStateMachine.Bot.Service.Menu;

public class MainService
{
    public BotMessage ProcessCommandStart(string textData, TransmittedData transmittedData)
    {
        if (textData == SystemStringsStorage.CommandStart)
        {
            transmittedData.State = States.WaitingClickOnButtonInMainMenu;

            return new BotMessage(
                DialogsStringsStorage.CommandStartOk,
                InlineKeyboardsMarkupStorage.MenuMain
            );
        }
        else
        {
            return new BotMessage(
                DialogsStringsStorage.CommandStartError
            );
        }

        throw new Exception("Неизвестная ошибка в ProcessCommandStart");
    }

    public BotMessage ProcessClickOnButtonInMainMenu(string textData, TransmittedData transmittedData)
    {
        if (textData == BotButtonsStorage.FirstButtonInMenuMain.CallBackData)
        {
            return new BotMessage(
                DialogsStringsStorage.FirstButtonInMenuMainClick
            );
        }
        else if (textData == BotButtonsStorage.SecondButtonInMenuMain.CallBackData)
        {
            return new BotMessage(
                DialogsStringsStorage.SecondButtonInMenuMainClick
            );
        }
        else if (textData == BotButtonsStorage.BackButtonInMenuMain.CallBackData)
        {
            transmittedData.State = States.WaitingCommandStart;
            return new BotMessage(
                DialogsStringsStorage.BackButtonInMenuMainClick
            );
        }

        throw new Exception("Неизвестная ошибка в ProcessClickOnButtonInMainMenu");
    }
}