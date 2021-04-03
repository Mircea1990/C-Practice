using System;

namespace ConsoleApp4
{
    class Program
    {
        #region clase
        public class Tutorial : ICloneable, IComparable
        {
            public string name;
            public DateTime date_add;

            public Tutorial()
            {

            }

            public Tutorial(string n, DateTime d)
            {
                this.name = n;
                this.date_add = d;
            }
            
            public virtual int Function()
            {
                return 0;
            }

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            public int CompareTo(object obj)
            {
                if (obj is Tutorial)
                {
                    Tutorial t = (Tutorial)obj;
                    if (this.date_add < t.date_add)
                    {
                        return -1;
                    }
                    else if (this.date_add > t.date_add)
                    {
                        return 1;
                    }
                    else return 0;
                }
                throw new NotImplementedException();
            }

            #region

            public static explicit operator int(Tutorial t)
            {
                TimeSpan ts = t.date_add - new DateTime(t.date_add.Year, 1, 1);
                return ts.Days;
            }

            public static Tutorial operator++(Tutorial t)
            {
                t.date_add = t.date_add.AddDays(1);
                return t;
            }

            public static int operator+(Tutorial t1, Tutorial t2)
            {
                return (int)t1 + (int)t2;
            }

            #endregion

        }

        public class Laborator:Tutorial
        {
            int number;

            public Laborator()
            {

            }

            public Laborator(string n, DateTime d, int x): base(n,d)
            {
                this.number = x;
            }

            public override int Function()
            {
                return 1;
            }
        }

        #endregion



        public delegate int BynaryOp(int x, int y);

        public class Operations
        {
            public static int Add(int x, int y)
            {
                return x + y;
            }

            public static int Substract(int x, int y)
            {
                return x - y;
            }
        }

        public class ClasaCalcule
        {
            public event BynaryOp EfectueazaCalcule;
            public int Calculeaza(int x, int y)
            {
                if(EfectueazaCalcule != null)
                {
                    return  EfectueazaCalcule(x,y);
                }
                else
                {
                    throw new Exception("Event is null");
                }

            }
        }

        static void Main(string[] args)
        {
            Tutorial t1 = new Tutorial();
            t1.name = "Tutorial 1";
            t1.date_add = DateTime.Now;
            Tutorial t2 = (Tutorial)t1.Clone();
            if (t1.CompareTo(t2) == 0)
            {
                Console.WriteLine("Sunt egale");
            }

            Console.WriteLine((int)t2);

            t2++;
            Console.WriteLine(t2.date_add);

            Console.WriteLine(t1 + t2);

            Laborator l = new Laborator();
            t1 = (Tutorial)l;

            Console.WriteLine(t2.Function());

            BynaryOp b = new BynaryOp(Operations.Add);
            Console.WriteLine(b(1, 2));

            BynaryOp b2 = new BynaryOp(Operations.Substract);
            Console.WriteLine(b2(4, 5));

            ClasaCalcule c = new ClasaCalcule();
            c.EfectueazaCalcule += new BynaryOp(Operations.Add);
            c.EfectueazaCalcule += new BynaryOp(Operations.Substract);

            Console.WriteLine(c.Calculeaza(1, 2));

        }
    }
}
