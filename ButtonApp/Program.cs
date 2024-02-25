
var state = new StateManager();
var mainMenu = new MainMenuState();
state.Run(mainMenu);
mainMenu.Execute();

class StateManager
{
    private IState? _state;
    public void Run(IState state)
    {
        _state = state;
        while (true)
        {

        }
    }
}

class MainMenuState : IState
{
    public void Execute()
    {
        Console.WriteLine("Main menu");
    }
    public ICommand Command()
    {
        return new InvalidCommand();
    }
}

class InvalidCommand : ICommand
{
    public void Run()
    {
        Console.WriteLine("Invalid command");
    }
}
class HelpCommand : ICommand
{
    public void Run()
    {
        Console.WriteLine("HELP!");
    }
}

interface IState
{
    void Execute();
    ICommand Command();
}

public interface ICommand
{
    void Run();
}
