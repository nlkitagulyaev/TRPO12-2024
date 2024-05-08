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

    /// <summary>
    /// класс дисциплина
    /// вариант 3
    /// сделал Гачин Иван
    /// </summary>
    class DISCIPLINA
    {
        private string name;
        private string sokrasch;

        public DISCIPLINA(string name, string sokrasch)
        {
            this.name = name;
            this.sokrasch = sokrasch;
        }
        public string Name()
        {
            return name;
        }
        public string Sokrasch()
        {
            return sokrasch;
        }
    }
    /// <summary>
    /// Класс Должность
    /// Вариант 10
    /// Сделал Ли Михаил
    /// </summary>
    public class Dolznost
    {
        private string nazvanie;
        private double oklad;
        private Podrazdelenie podrozdelenie;

        public Dolznost(string nazvanie, double oklad, Podrazdelenie podrazdelenie)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.podrozdelenie = podrazdelenie;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }
    }

    /// <summary>
    /// Класс Подразделение
    /// Вариант 11
    /// Сделал ...
    /// </summary>
    public class Podrazdelenie
    {
        private string nazvanie;
        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }
    }
    /// <summary>
    /// Класс организация
    /// Вариант 12
    /// Тарасов Илья
    /// </summary>
    public class Organizaciya
    {
        private string _nazvanie;
        private string _yuridicheskiyAdres;
        private string _fakticheskiyAdres;
        //private Sotrudnik _rukovoditel; //класс сотрудник еще не создан

        public Organizaciya(string nazvanie, string yuridicheskiyAdres, string fakticheskiyAdres /*Sotrudnik rukovoditel*/)// класс пока еще не создан
        {
            _nazvanie = nazvanie;
            _yuridicheskiyAdres = yuridicheskiyAdres;
            _fakticheskiyAdres = fakticheskiyAdres;
            //_rukovoditel = rukovoditel;
        }
    }

    public class Group
    {
        private string name;
        private string sokrasch;
        private int amount;
        private int year;
        private string link;
        private string boss;

        public Group(string name, string sokrasch, int amount, int year, string link, string boss)
        {
            this.name = name;
            this.sokrasch = sokrasch;
            this.amount = amount;
            if (year == null)
            {
                this.year = year;
            }
            else
            {
                this.year = DateTime.Now.Year;
            }
            this.link = link;
            this.boss = boss;
        }
    }
}

