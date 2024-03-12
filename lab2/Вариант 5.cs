using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_5variant
{
    class Student
    {
        private string Surname;

        private string Name;

        private string Patronymic;

        private string Group;

        private string DateOfBirthday;

        public Student(string surname1, string name1, string patronymic1, string group1, string DateOfBirthday1)
        {
            Surname = surname1;
            Name = name1;
            Patronymic = patronymic1;
            Group = group1;
            DateOfBirthday = DateOfBirthday1;
        }
    }
}
