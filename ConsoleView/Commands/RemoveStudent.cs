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
            string name = ReadString("Введите имя студента");
            string speciality = ReadString("Введите специальность студента");
            string group = ReadString("Введите группу студента");


            bool result = _logic.DeleteStudent(name, speciality, group);

            if (result)
            {
                WriteLine($"Студент {name} был успешно удален из системы");
            }
            else
            {
                WriteLine($"Студент {name} не найден в системе");
            }
        }
    }
}