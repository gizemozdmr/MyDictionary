using System;
using System.Collections.Generic;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<Object, string> product = new MyDictionary<Object, string>();
            product.Add(1, "Etek");
            product.Add(3, "Kazak");
            product.Add(4, "Pantolon");
            product.Add(150, "Şapka");
            product.Add(5, "Ayakkabı");
            
            Console.WriteLine("Product Name:" + product.keyCount);
            Console.WriteLine("Product No:" + product.valueCount);



            for (int i = 0; i < product.keyCount; i++)
            {
                Console.WriteLine(product.valueArray[i]);
            }
        }
    }
}
