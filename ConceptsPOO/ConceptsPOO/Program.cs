using System;

namespace ConceptsPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO COncepts");
            Console.WriteLine("============");

            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(2022, 11, 30));
                Console.WriteLine(new Date(1965, 6, 23));
                Console.WriteLine(new Date(1985, 11, 5));
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}