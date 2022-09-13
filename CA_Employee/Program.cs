using System;

namespace CA_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karşilama();
            Employee employee = new Employee();
            employee.Create(employee);
            employee.Printing(employee);
            Console.Read();



            void Karşilama()
            {
                Console.WriteLine("Hoşgeldiniz");
            }
        }
    }
}
