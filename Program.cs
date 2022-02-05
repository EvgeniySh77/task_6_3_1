using System;

namespace task_6_3_1
{
    class Program
    {
        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }

        static void Main()
        {
            var department = GetCurrentDepartment();
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }

            Console.ReadKey();
        }

        static Department GetCurrentDepartment()
        {
            Company com = new Company { Type = "Банк", Name = "ВТБ" };
            City city = new City { Name = "Санкт-Петербург" };
            
            Department dep = new Department {Company = com, City = city };            
            return dep;
        }
    }
}
