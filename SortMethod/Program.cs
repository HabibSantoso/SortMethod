﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMethod
{
    class Program
    {
        private int[] a = new int[20];
        private int n;

        public void read()
        {
            while(true)
            {
                Console.Write("Masukkan banyak elemen pada array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen. \n");
                }

                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Masukan elemen array");
                Console.WriteLine("----------------------------");

                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    a[i] = Int32.Parse(s1);
                } 
            }
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Element array yang telah terseusun");
            Console.WriteLine("----------------------------");

            for (int j = 0; j<n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        

        static void Main(string[] args)
        {
            
        }
    }
}
