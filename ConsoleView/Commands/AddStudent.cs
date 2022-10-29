using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace ConsoleView.Commands
{
    internal class AddStudent : AbstractCommand, ICommand
    {
        private readonly Logic _logic;

        public AddStudent(Logic logic)
        {
            this._logic = logic;
        }

        public string Command { get; init; } = "student:add";
        public string Description { get; init; } = "Добавить нового студента в систему";

        public void Execute()
        {
            string name = ReadString("Введите имя студента");
            string speciality = ReadString("Введите специальность студента");
            string group = ReadString("Введите группу студента");


            _logic.AddStudent(name, speciality, group);
            WriteLine($"Студент {name} был успешно добавлен в систему");
        }
    }
}