using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        struct Structura1
        {
            public int valoare;
        }
        class Clasa1
        {
            public int valoare = 0;
            public Clasa1 clone()
            {
                Clasa1 x = new Clasa1();
                x.valoare = this.valoare;
                return x;
            }
        }

        class Tuturial
        {
            private int id;
            private string denumire;
            private DateTime data_adaugarii;

            public int Id 
            { 
                get => id; 
                set => id = value; 
            }
            public string Denumire 
            { 
                get => denumire; 
                set => denumire = value; 
            }
            public DateTime Data_adaugarii 
            { 
                get => data_adaugarii; 
                set => data_adaugarii = value; 
            }
        }

        static void Main(string[] args)
        {
            //Structura1 s1;
            //s1.valoare = 0;
            //Structura1 s2 = s1;
            //s2.valoare = 14;

            Clasa1 c1;
            c1 = new Clasa1();
            //Clasa1 c2 = c1.clone();
            //c2.valoare = 14;

            //Console.WriteLine("Valorile din structura sunt: {0}, {1}", s1.valoare, s2.valoare);
            //Console.WriteLine("Valorile din clasa sunt: {0}, {1}", c1.valoare, c2.valoare);

            //Console.ReadLine();

            Clasa1[] vector;
            vector = new Clasa1[3];

            vector[0] = new Clasa1();
            vector[0].valoare = 15;

            Object x = vector[0];
            vector[1] = (Clasa1)x;
            vector[2] = new Clasa1();
            vector[2].valoare = 3;

            decimal[,] matrice;
            matrice = new decimal[2, 2];

            //for(int i = 0; i< 3; i++)
            //{
            //    Console.WriteLine("{0} ", vector[i].valoare);
            //}

            foreach (var c in vector)
            {
                Console.WriteLine("{0}", c.valoare);
            }

            Console.ReadLine();

            ArrayList al = new ArrayList();
            al.Add("string");
            al.Add(vector[0]);
            Object o = al[0];

            List<double> list = new List<double>();
            list.Add(2.5);
            list.Add((double)4.48);

            Dictionary<int, double> dictionary = new Dictionary<int, double>();
            dictionary.Add(1, 5.60);

            Object[] v;
            //v = al.ToArray();

            String s = "Anonim";
            string h = String.Empty;
            h = "Laborator1\r\nC#";
            string sql = @"SELECT coloana FROM tabele
                        WHERE conditie";
            char p = s[0];
            h = s.Substring(0, 2);
            h = s.ToLower();
            s.ToUpper();
            s.Trim();
            Console.WriteLine(s);
            Console.WriteLine(h);
            Console.WriteLine(sql);

            Console.ReadLine();

            Tuturial t = new Tuturial();
            t.Data_adaugarii = DateTime.Today;
            t.Denumire = "abc";

            Console.WriteLine(t.Denumire);



            t.Id = 3;
          
        }
    }
}
