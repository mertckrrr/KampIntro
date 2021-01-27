using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Türkçe");
            dictionary.Add(2, "Almanca");
            dictionary.Add(3, "Fransızca");
            dictionary.Add(4, "İngilizce");
            dictionary.Add(5, "İspanyolca");

            dictionary.Listele();


        }
    }
}