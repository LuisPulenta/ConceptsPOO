using System;

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

            Console.WriteLine(employee1);

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

            Console.WriteLine(employee2);
        }
    }
}