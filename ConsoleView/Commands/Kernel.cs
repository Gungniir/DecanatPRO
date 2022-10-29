using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleView.Commands
{
    internal class Kernel
    {
        private readonly ICommand[] _commands;

        private const string StartUpMessage = "Добро пожаловать в систему DecanatPRO!" + "Введите команду или help";

        public Kernel(Logic logic)
        {
            _commands = new ICommand[]
            {
                new AddStudent(logic),
                new RemoveStudent(logic),
                new ListStudent(logic),
                new SeedStudent(logic),
                new GistStudent(logic),
            };
        }

        public void Run()
        {
            Console.WriteLine(StartUpMessage);
            Loop();
        }

        private void Loop()
        {
            while (true)
            {
                Console.Write("> ");

                string? commandInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(commandInput))
                {
                    continue;
                }

                if (commandInput == "help")
                {
                    PrintHelp();
                    continue;
                }

                if (commandInput == "exit")
                {
                    break;
                }

                ICommand? command = _commands.FirstOrDefault(command => command.Command == commandInput);

                if (command is null)
                {
                    PrintUnknownError();
                    continue;
                }

                command.Execute();
            }
        }

        private void PrintHelp()
        {
            List<ICommand> commands = new List<ICommand>(_commands);

            commands.Sort((a, b) => string.Compare(a.Command, b.Command, StringComparison.Ordinal));

            Console.WriteLine("Доступные команды: ");

            foreach (ICommand command in commands)
            {
                Console.WriteLine(command.Command + " - " + command.Description);
            }

            Console.WriteLine("help - Вывести это сообщение");
            Console.WriteLine("exit - Выйти");
        }

        private void PrintUnknownError()
        {
            Console.WriteLine("Неизвестная команда");
        }
    }
}