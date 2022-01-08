using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace turnuva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title=("Futbol Turnuvası");
            string t1, t2, t3, t4, f1, f2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            Console.WriteLine(" ");
            f1 = " ";
            f2 = " ";
            int s1, s2, s3, s4, s5, s6;
            Random rd = new Random();
            s1 = rd.Next(7);
            s2 = rd.Next(7);
            s3 = rd.Next(7);
            s4 = rd.Next(7);
            s5 = rd.Next(7);
            s6 = rd.Next(7);
            Console.WriteLine(t1 + " " + s1 + " - " + s2 + " " + t2);
            if (s1 > s2)
            {
                f1 = t1;
            }
            else if (s2 > s1)
            {
                f1 = t2;
            }
            else
            {
                int yazıtura = rd.Next(2);
                if (yazıtura == 0)
                {
                    f1 = t1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("pen");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    f1 = t2;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("pen");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(t3 + " " + s3 + " - " + s4 + " " + t4);
                if (s3 > s4)
                {
                    f2 = t3;
                }
                else if (s4 > s3)
                {
                    f2 = t4;
                }
                else
                {
                    int yazıtura1 = rd.Next(2);
                    if (yazıtura1 == 0)
                    {
                        f2 = t3;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("pen");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        f2 = t4;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("pen");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;           
            Console.WriteLine("============");
            Console.WriteLine("==Finaller==");
            Console.WriteLine("============");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(5000);
            Console.WriteLine(f1 + " " + s5 + " - " + s6 + " " + f2);
            if (s5 > s6)
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Şampiyon " + f1);
            }
            else if (s6 > s5)
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Şampiyon " + f2);     
            }
            else
            {
                int yazıtura1 = rd.Next(2);
                if (yazıtura1 == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Şampiyon " + f1);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("pen");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Şampiyon " + f2);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("pen");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
            Console.ReadKey();   
            }
        }
    }
