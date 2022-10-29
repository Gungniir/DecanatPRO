using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleView.Commands
{
    internal class RemoveStudent : AbstractCommand, ICommand
    {
        private readonly Logic _logic;

        public RemoveStudent(Logic logic)
        {
            this._logic = logic;
        }

        public string Command { get; init; } = "student:delete";
        public string Description { get; init; } = "Удалить студента из системы";

        public void Execute()
        {
            int id = ReadInt("Введите идентификатор студента");


            bool result = _logic.DeleteStudent(id);

            if (result)
            {
                WriteLine($"Студент №{id} был успешно удален из системы");
            }
            else
            {
                WriteLine($"Студент №{id} не найден в системе");
            }
        }
    }
}