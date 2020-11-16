using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;

namespace DSA
{
    public class Recurssion
    {
        private Recurssion(int s)
        {
            System.Console.WriteLine("hello");
        }

        List<int> lst = new List<int>();
        const int a = 0;
        readonly int ab = 1;        

        public Recurssion()
        {            
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.Add(7);
            lst.Add(8);
            ab = 1;
        }
        public void Recurse(int i)
        {
            string s = string.Empty;
            Hashtable hashtable = new Hashtable();
            hashtable.Add("", "");
            hashtable.Add(3, 2);
            if (i >= 3)
            {
                return;
            }            
            Recurse(++i);
            System.Console.WriteLine(lst[i]);
            //Recurse(++i);
        }
    }

    class B : Recurssion
    {

    }
}
