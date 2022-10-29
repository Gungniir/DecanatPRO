using BusinessLogic;

namespace ConsoleView.Commands
{
    internal class SeedStudent : AbstractCommand, ICommand
    {
        private readonly Logic _logic;

        public SeedStudent(Logic logic)
        {
            this._logic = logic;
        }

        public string Command { get; init; } = "student:seed";
        public string Description { get; init; } = "Заполнить систему тестовыми студентами";

        public void Execute()
        {
            _logic.FillStudents();

            WriteLine("Успешно заполнено");
        }
    }
}