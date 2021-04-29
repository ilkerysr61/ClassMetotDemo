using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "İlker";
            customer1.Surname = "Yaşar";
            customer1.TCNo = 12354621458;

            Customer customer2 = new Customer();
            customer2.Name = "Ayşe";
            customer2.Surname = "Yazıcı";
            customer2.TCNo = 12345687421;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer2);
            customerManager.ListCustomer(customer1);
            customerManager.DeleteCustomer(customer2);


            Console.ReadLine();

        }
    }
}
