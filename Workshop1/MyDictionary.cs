using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] items;
        TValue[] items2;
        public MyDictionary()
        {
            items = new TKey[0];
            items2 = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArray = items;
            TValue[] tempArray2 = items2;
            
            items = new TKey[items.Length + 1];
            items2 = new TValue[items2.Length + 1];
            

            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i]; 
            }

            items[items.Length - 1] = key; 
            items2[items2.Length - 1] = value;
           
        }

        public void Listele()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + " " + items2[i]);
            }
        }
    }
}