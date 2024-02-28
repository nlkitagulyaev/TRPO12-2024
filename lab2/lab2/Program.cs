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
}

