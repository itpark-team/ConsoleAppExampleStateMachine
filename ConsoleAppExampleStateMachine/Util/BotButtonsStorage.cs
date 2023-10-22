namespace ConsoleAppExampleStateMachine.Util;

public class BotButtonsStorage
{
    public static BotButton FirstButtonInMenuMain { get; } = new BotButton("Первая кнопка", "FirstButtonInMenuMain");
    public static BotButton SecondButtonInMenuMain { get; } = new BotButton("Вторая кнопка", "SecondButtonInMenuMain");
    
    public static BotButton BackButtonInMenuMain { get; } = new BotButton("Кнопка назад", "BackButtonInMenuMain");
}