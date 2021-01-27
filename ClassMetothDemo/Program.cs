using ClassMetothDemo;
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.TcKimlikNo = "123456789";
            customer1.Adi = "Mert";
            customer1.Soyadi = "Çakır";
            customer1.Meslegi = "Elektrik Elektronik Mühendisi";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.TcKimlikNo = "1234567800";
            customer2.Adi = "Müslüm";
            customer2.Soyadi = "Çakır";
            customer2.Meslegi = "Emekli";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.TcKimlikNo = "100000000";
            customer3.Adi = "Engin";
            customer3.Soyadi = "Demiroğ";
            customer3.Meslegi = "Yazılım Geliştirici";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(customer1);
            customerManager.Sil(customer2);
            customerManager.Listele(customer3);
        }
    }
}
