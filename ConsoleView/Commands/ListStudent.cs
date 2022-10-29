using BusinessLogic;
using ConsoleTableExt;
using Model;

namespace ConsoleView.Commands
{
    internal class ListStudent : AbstractCommand, ICommand
    {
        private readonly Logic _logic;

        public ListStudent(Logic logic)
        {
            this._logic = logic;
        }

        public string Command { get; init; } = "student:list";
        public string Description { get; init; } = "Вывести всех студентов в системе";

        public void Execute()
        {
            List<Student> students = _logic.ShowTable();

            if (students.Count == 0)
            {
                WriteLine("В системе нет студентов");
                return;
            }

            ConsoleTableBuilder.From(students).ExportAndWriteLine();
        }
    }
}