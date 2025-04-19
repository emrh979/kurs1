using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             void Task1()
            {
                Console.Write("birinci reqem: ");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.Write("ikinci reqem: ");
                int b=Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 1 && b % 2 == 1)
                {
                    Console.WriteLine("Her iki eded tekdir");
                }
                else if (a % 2 == 0 && b % 2 == 0)
                {
                    Console.WriteLine("her iki eded cutdur");
                }
                else 
                {
                    Console.Write("Her iki eded cut ve ya tekdir: ");
                    Console.WriteLine(false);
                }

            }

            void Task2() 
            {
                Console.Write("birinci sozu daxil edin: ");
                 string soz1 = Console.ReadLine();
                Console.Write("sozun icinde axtarmaq istediyiniz hisse: ");
                 string soz2 = Console.ReadLine();

                if (soz1.Contains(soz2))
                {
                    Console.WriteLine(true);
                }
                else 
                {
                    Console.WriteLine(false);
                }
            }

            void Task3() 
            {
                Console.Write("birinci reqem: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("ikinci reqem: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Netice: ");
               double c = (double)a / b;
                Console.WriteLine(c);
            }

            //isledilecek task-i secin
            Task1();


        }
    }
}
