using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać temperature");
            int temp = Int32.Parse(Console.ReadLine());

            switch(temp)
            {
                case int t when t < 0:
                    {
                        Console.WriteLine("Cholernie piździ");
                        break;

                    }
                case int t when t < 0 && t > 10:
                    {
                        Console.WriteLine("Zimno");
                        break;

                    }
                case int t when t > 10 && t < 20:
                    Console.WriteLine("Chłodno");
                    break;

                case int t when t > 20 && t < 30:
                    Console.WriteLine("W sam raz");
                    break;
                case int t when t > 30 && t < 40:
                    Console.WriteLine("Zaczyna być słabo bo gorąco");
                    break;
               
                 default:
                    Console.WriteLine("A weź wyprowadzam się na Alaske");
                    break;





            }
            Console.ReadLine();
        }
    }
}
