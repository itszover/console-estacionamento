public static class Color
{
    public static void Write(string message, MessageType type)
    {
        switch (type)
        {
            case MessageType.Success:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case MessageType.Warn:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case MessageType.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case MessageType.Info:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case MessageType.Debug:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case MessageType.Critical:
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case MessageType.Notice:
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

        Console.WriteLine(message);
        Console.ResetColor();
    }
}

public enum MessageType
{
    Success,
    Warn,
    Error,
    Info,
    Debug,
    Critical,
    Notice
}
