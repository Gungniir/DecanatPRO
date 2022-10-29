using System;

namespace Model
{
    public class Student
    {
        private readonly string[] _names = {
            "Владимир Курусь",
            "Иван Арляпов",
            "Иван Ванюшкин",
            "Константин Калинин",
            "Софья Качаева",
            "Татьяна Викторова",
            "Юлия Викторова",
            "Кирилл Нагель"
        };

        private readonly string[] _specialities =
        {
            "Прикладная информатика",
            "Программная инженерия",
        };

        private readonly string[] _groups =
        {
            "1",
            "2",
        };

        public string Name { get; set; } = "";

        public string Speciality { get; set; } = "";

        public string Group { get; set; } = "";

        public void FillRandom(int seed)
        {
            Random random = new Random(seed);

            Name = _names[random.Next(_names.Length)];
            Speciality = _specialities[random.Next(_specialities.Length)];
            Group = _groups[random.Next(_groups.Length)];
        }
    }
}