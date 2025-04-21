namespace DI.Basics.Console;

internal sealed class DefaultConsole : IConsole
{
    public bool IsEnabled { get; set; } = true;

    void IConsole.WriteLine(string message)
    {
        if (IsEnabled is false)
        {
            return;
        }

        System.Console.WriteLine(message);
    }
}
