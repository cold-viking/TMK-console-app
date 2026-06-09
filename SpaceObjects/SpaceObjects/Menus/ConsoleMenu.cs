using SpaceObjects.Commands;

namespace SpaceObjects.Menus;

public class ConsoleMenu
{
    private readonly List<ICommand> _commands;

    public ConsoleMenu(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("===== SPACE OBJECTS MENU =====");

            for (var i = 0; i < _commands.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_commands[i].Name}");
            }

            Console.WriteLine("0. Exit");
            Console.Write("Choose command: ");

            string? input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }

            if (!int.TryParse(input, out var commandNumber))
            {
                Console.WriteLine("Incorrect command");
                Console.WriteLine();
                continue;
            }

            if (commandNumber < 1 || commandNumber > _commands.Count)
            {
                Console.WriteLine("Command does not exist");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine();

            _commands[commandNumber - 1].Execute();

            Console.WriteLine();
        }
    }
}