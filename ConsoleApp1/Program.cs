using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Здравствуйте введите текст:");
            string inputTxt = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputTxt))
            {
                Console.WriteLine($"Первый символ: {inputTxt.Substring(0, 1)}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите текст");
            }

        }

       
    }
}
