using ConsoleAppExampleStateMachine.Bot.Router;
using ConsoleAppExampleStateMachine.Bot.Service.Menu;

namespace ConsoleAppExampleStateMachine.Bot.Service;

public class ServicesManager
{
    private Dictionary<string, Func<string, TransmittedData, BotMessage>>
        _methods;

    public ServicesManager()
    {
        MainService mainService = new MainService();

        _methods =
            new Dictionary<string, Func<string, TransmittedData, BotMessage>>();

        _methods[States.WaitingCommandStart] = mainService.ProcessCommandStart;
        _methods[States.WaitingClickOnButtonInMainMenu] = mainService.ProcessClickOnButtonInMainMenu;
    }

    public BotMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        Func<string, TransmittedData, BotMessage> serviceMethod = _methods[transmittedData.State];
        return serviceMethod.Invoke(textData, transmittedData);
    }
}