using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6; //deklaracja i nadanie wartości a na 6
            int b = a; //skopiowanie za pomocą operatora przypisania

            // wyświetlenie wartości a i b po skopiowaniu
            Console.WriteLine("a={0}, b={1}", a, b);

            b++; //inkrementacja zmiennej b

            //wyświetlenie wartości a i b po zmianie
            Console.WriteLine("Po zmianie");
            Console.WriteLine("a={0}, b={1}", a, b);

            Console.ReadKey();
        }
    }
}
