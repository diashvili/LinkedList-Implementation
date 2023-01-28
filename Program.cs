using System;
using System.Collections.Generic;

namespace GR15_05312022
{
    internal class Program
    {
        static void Main()
        {

            MyLinkedList<string> linkedList = new MyLinkedList<string>();
            linkedList.AddFirst("data");
            linkedList.AddFirst("gio");
            linkedList.AddFirst("saba");
            linkedList.AddLast("masho");
            linkedList.AddLast("toko");
            linkedList.AddLast("mari");
            linkedList.AddLast("gega");           
            linkedList.AddFirst("iashka");
            linkedList.AddFirst("iashvili");
            
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
   
        }

       
    }
}
