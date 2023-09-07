using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кажется_вторая_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую числовую переменную: "); 
           string number0 = Console.ReadLine();
            Console.Write("Введите вторую числовую переменную: ");
            string number1 = Console.ReadLine();
            Console.WriteLine(number1 + number0);
            

            Console.ReadKey();
            
        }
    }
}
