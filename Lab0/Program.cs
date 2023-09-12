using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        /// <summary>
        /// 18. Реализовать функцию возведения в куб целого числа
        /// </summary>
        /// <param name="x">Число которое возводим в степень</param>
        /// <returns>возведение в куб целого числа</returns>
        private static double Power3(int x)
        {
            return Math.Pow(x, 3);
        }
           
        static void Main(string[] args)
        {
        
            Random rnd = new Random();
            int x = rnd.Next(-10,10);
            Console.WriteLine($"Число в которое возводиться степерь:{x}; \nВозведение в степень целого чилса: { Power3(x)}");
            Console.ReadLine();

        }
    }
}
