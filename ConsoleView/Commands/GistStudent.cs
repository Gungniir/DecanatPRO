using BusinessLogic;
using Model;

namespace ConsoleView.Commands
{
    internal class GistStudent : AbstractCommand, ICommand
    {
        private readonly Logic _logic;

        public GistStudent(Logic logic)
        {
            this._logic = logic;
        }

        public string Command { get; init; } = "student:gist";
        public string Description { get; init; } = "Вывести гистограмму распределения студентов по специальности";

        public void Execute()
        {
            IEnumerable<IGrouping<string, Student>> students = _logic.ShowGist();

            int[] data = students.Select(grouping => grouping.ToList().Count).ToArray();
            int[] normalized = students.Select(grouping => grouping.ToList().Count * 25 / data.Sum()).ToArray();
            string[] names = students.Select(grouping => grouping.Key).ToArray();

            List<String> labels = new();

            if (data.Length == 0)
            {
                WriteLine("В системе нет студентов");
                return;
            }

            for (int i = 0; i < names.Length; i++)
            {
                labels.Add($"{names[i]} ({data[i]})");
            }

            int maxLabelLength = labels.Max(s => s.Length);

            for (int i = 0; i < names.Length; i++)
            {
                WriteLine($"{labels[i]}{new string(' ', maxLabelLength - labels[i].Length)}: [{new String('#', normalized[i])}{new String(' ', 25 - normalized[i])}]");
            }
        }
    }
}