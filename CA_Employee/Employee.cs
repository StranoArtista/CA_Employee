using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }



        public void Create(Employee employee)
        {
            Console.WriteLine("Lütfen çalışan adı girin");

            employee.EmployeeFirstName = Console.ReadLine();
            Validation(employee.EmployeeFirstName);
            Console.WriteLine("Lütfen çalışanın soyadını girin");
            employee.EmployeeLastName = Console.ReadLine();
            Validation(employee.EmployeeLastName);
            Console.WriteLine("Çalışan oluşturuldu");
        }

        void Validation(string deger)
        {
            if(string.IsNullOrEmpty(deger))
            {
                Console.WriteLine("Değer boş bırakılamaz");
                Environment.Exit(0);

            }
        }
        public void Printing(Employee employee)
        {
            Console.WriteLine($"Çalışanın ismi:{employee.EmployeeFirstName}\nÇalışanın soyismi: {employee.EmployeeLastName}");
        }
    }
}
