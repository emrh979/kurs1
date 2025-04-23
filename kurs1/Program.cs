using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kurs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else tasklari 
            // tasklari ise salmaq ucun en asagidaki setirde hansi taskin isledileceyini secin: Task2_(reqem)


            void Task2_1()
            {
                int a, b, c;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"eded a:{a}\neded b:{b}\neded c:{c}");
                Console.WriteLine();

                if (a < 1000 && b < 1000 && c < 1000)
                {
                    Console.WriteLine("Ededlerin ededi ortasi: " + (a + b + c) / 3);
                }
                else
                {
                    Console.WriteLine("1000-e qeder olan ededleri daxil edin");
                }
            }

            void Task2_2()
            {
                int terefA, terefB, terefC;

                terefA = Convert.ToInt32(Console.ReadLine()); //3
                terefB = Convert.ToInt32(Console.ReadLine()); //4
                terefC = Convert.ToInt32(Console.ReadLine()); //3

                if (terefA < 100 && terefB < 100 && terefC < 100)
                {
                    if (terefA == terefB && terefA == terefC)
                    {
                        Console.WriteLine("\n1");
                    }
                    else if (terefA == terefB && terefA != terefC || terefB == terefC && terefB != terefA || terefA == terefC && terefA != terefB)
                    {
                        Console.WriteLine("\n2");
                    }
                    else
                    {
                        Console.WriteLine("\n3");
                    }
                }

            }

            void Task2_3()
            {
                int a, b, c;

                a = Convert.ToInt32(Console.ReadLine()); //3
                b = Convert.ToInt32(Console.ReadLine()); //4
                c = Convert.ToInt32(Console.ReadLine()); //3

                if ((a < 100) && (b < 100) && (c < 100))
                {
                    if ((Math.Sqrt(a * a + b * b) == c) || (Math.Sqrt(b * b + c * c) == a) || (Math.Sqrt(a * a + c * c) == b))
                    {
                        Console.WriteLine("Duzbucaqlidir");
                    }
                    else
                    {
                        Console.WriteLine("Duzbucaqli deyil !!");
                    }
                }
            }

            void Task2_4()
            {
                Console.Write("Ayin gununu daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && a <= 12)
                {
                    if (a == 12 || a == 1 || a == 2)
                    {
                        Console.WriteLine("Winter");
                    }
                    else if (a == 3 || a == 4 || a == 5)
                    {
                        Console.WriteLine("Spring");
                    }
                    else if (a == 6 || a == 7 || a == 8)
                    {
                        Console.WriteLine("Summer");
                    }
                    else
                    {
                        Console.WriteLine("Autmn");
                    }

                }
                else 
                {
                    Console.WriteLine("Duzgun eded daxil edin(1-12 arasi eded olmalidir) ");
                }
            }

            void Task3_3()
            {
                Console.Write("Ededi daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a) 
                {
                    case 0: 
                        Console.WriteLine("sifir");
                        break;
                    case 1: Console.WriteLine("bir");
                        break;
                    case 2: Console.WriteLine("iki");
                        break;
                    case 3: Console.WriteLine("uc");
                        break;
                    case 4: Console.WriteLine("dord");
                        break;
                    case 5: Console.WriteLine("bes");
                        break;
                    case 6: Console.WriteLine("alti");
                        break;
                    case 7: Console.WriteLine("yeddi");
                        break;
                    case 8: Console.WriteLine("sekkiz");
                        break;
                    case 9: Console.WriteLine("doqquz");
                        break;
                    default: Console.WriteLine("0-9 arasi eded daxil edin");
                           break ;
                }

            }

            void Task3_5() //imtahan qiymetlendirme
            {
                string a = Console.ReadLine();
                switch (a) 
                {
                    case "A": Console.WriteLine("Ela");
                        break;
                    case "B": Console.WriteLine("Yaxsi");
                        break;
                    case "C": Console.WriteLine("Orta");
                        break;
                    case "D": Console.WriteLine("Kafi");
                        break;
                    case "E": Console.WriteLine("Pis");
                        break;
                }

            }



        }
    }
}
