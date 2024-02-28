using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Department
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int EmployeeCount { get; set; }

        public Department(string name, string location, int employeeCount)
        {
            Name = name;
            Location = location;
            EmployeeCount = employeeCount;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Подразделение: " + Name);
            Console.WriteLine("Местоположение: " + Location);
            Console.WriteLine("Количество сотрудников: " + EmployeeCount);
        }
}
    class Занятие
    {
        private DateTime дата_проведения;
        private string дисциплина;
        private string сотрудник;
        private string аудитория;
        private string группа;
        private string пара;
        private string вид_занятия;

        public Занятие(DateTime? дата_проведения = null, string дисциплина = "", string сотрудник = "", string аудитория = "", string группа = "", string пара = "", string вид_занятия = "")
        {
            if (дата_проведения == null)
            {
                this.дата_проведения = DateTime.Now;
            }
            else
            {
                this.дата_проведения = (DateTime)дата_проведения;
            }

            this.дисциплина = дисциплина;
            this.сотрудник = сотрудник;
            this.аудитория = аудитория;
            this.группа = группа;
            this.пара = пара;
            this.вид_занятия = вид_занятия;
            }

}
}

