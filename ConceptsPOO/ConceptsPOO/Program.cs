using System;
using System.Collections.Generic;

namespace ConceptsPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO COncepts");
            Console.WriteLine("============");

            Employee employee1 = new SalaryEmployee()
            {
                Id=1010,
                Active = true,
                BirthDate = new Date(1990,5,23),
                FirstName ="Sandra",
                LastName ="Morales",
                HiringDate = new Date(2022, 1, 15),
                Salary=1863453.45M
            };

            //Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee
            {
                Id = 2020,
                Active = true,
                BirthDate = new Date(1995, 5, 23),
                FirstName = "Patricia",
                LastName = "Gutierrez",
                HiringDate = new Date(2022, 2, 5),
                Sales = 320000000M,
                CommissionPercentaje =0.03F
            };

            //Console.WriteLine(employee2);

            Employee employee3 = new HourlyEmployee
            {
                Id = 3030,
                Active = true,
                BirthDate = new Date(1985, 5, 23),
                FirstName = "Gonzalo",
                LastName = "Cardona",
                HiringDate = new Date(2022, 2, 5),
                HourValue = 12356.56M,
                Hours = 123.5F
            };

            //Console.WriteLine(employee3);

            Employee employee4 = new BaseCommissionEmployee
            {
                Id = 4040,
                Active = true,
                BirthDate = new Date(1985, 5, 23),
                FirstName = "Jazmín",
                LastName = "Salazar",
                HiringDate = new Date(2022, 2, 5),
                Base = 860678.45M,
                Sales = 58000000M,
                CommissionPercentaje = 0.015F,
            };

            //Console.WriteLine(employee4);

            ICollection<Employee> employees = new List<Employee>() {
                employee1,employee2,employee3,employee4
            };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }
            Console.WriteLine("                                   ===============");
            Console.WriteLine($"TOTAL                              {$"{payroll:C2}",15}");

            Invoice invoice1 = new Invoice()
            {
                Description = "iPhone 13",
                Id = 1,
                Price = 5300000M,
                Quantity = 6
            };

            Invoice invoice2 = new Invoice()
            {
                Description = "Posta Premium",
                Id = 2,
                Price = 32000M,
                Quantity = 17.5F
            };

            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
        }
    }
}