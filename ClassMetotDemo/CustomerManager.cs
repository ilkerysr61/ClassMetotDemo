using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer Added. " +" "+"TCNo: "+" "+customer.TCNo+", "+"Name and Surname: "+" "+customer.Name+" "+customer.Surname);
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.TCNo);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Name:"+" " +customer.Name+ " "+"**** Deleted");
        }
    }
}
