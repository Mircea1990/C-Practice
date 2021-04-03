using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v = new int[5];
            for(int i = 0; i< v.Length; i++)
            {
                Console.Write("v[{0}] ", i);
                v[i] = Int32.Parse(Console.ReadLine());
            }
         
            Array.Sort(v);
            Console.WriteLine("\nFirst vector");
            foreach(int x in v)
            {
                Console.Write("{0}, ", x);
            }

            int[] w = new int[7];

            v.CopyTo(w, 1);
            Console.WriteLine();

            Console.WriteLine("\nSecond vector");
            foreach (int x in w)
            {
                Console.Write("{0}, ", x);
            }

            int[,] m = new int[2, 5];
            int k = 0;
            foreach(var x in v)
            {
                m[0, k] = x;
                m[1, k] = -x;
                k++;
            }

            Console.WriteLine("\nVector of vector");
            for(int i = 0; i <m.GetLength(0); i++)
            {
                for(int j = 0; j <m.GetLength(1); j++)
                {
                    Console.Write("{0} ", m[i, j]);
                }
                Console.WriteLine();
            }

            int[][] n = new int[2][];
            Persoana[] vect_pers = new Persoana[5];
            k = 0;
            foreach(int x in v)
            {
                vect_pers[k] = new Persoana();
                vect_pers[k].Id = x;
                Console.Write("Numele pentru id-ul {0}: ", x);
                vect_pers[k].Nume = Console.ReadLine();
                vect_pers[k].Data_nasterii = DateTime.Today;
                k++;
            }

            List<Persoana> lista = new List<Persoana>();
            lista.InsertRange(0, vect_pers);
            foreach(Persoana p in lista)
            {
                Console.WriteLine(p.Nume);
            }

            Dictionary<int, Persoana> dictionar = new Dictionary<int, Persoana>();
            foreach(var p in lista)
            {
                dictionar.Add(p.Id, p);
            }

            Console.WriteLine(dictionar[2].Nume);

            Console.ReadLine();

            


        }
    }
}
public class Persoana
{
    int id;
    string nume;
    DateTime data_nasterii;

    public int Id
    {
        get => id;
        set => id = value;
    }
    public string Nume
    {
        get => nume;
        set => nume = value;
    }
    public DateTime Data_nasterii
    {
        get => data_nasterii;
        set => data_nasterii = value;
    }
}
