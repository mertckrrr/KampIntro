using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetothDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " isimli müşteri eklendi.");
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine("-------Listenen Müşteri-------");
            Console.WriteLine("Id\t\t:\t" + customer.Id);
            Console.WriteLine("TC Kimlik No\t:\t" + customer.TcKimlikNo);
            Console.WriteLine("Adı\t\t:\t" + customer.Adi);
            Console.WriteLine("Soyadı\t\t:\t" + customer.Soyadi);
            Console.WriteLine("Mesleği\t\t:\t" + customer.Meslegi);


        }
        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " isimli müşteri silindi.");
        }
    }
}
