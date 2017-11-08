using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreadelCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int L;
            int area, volumen;
            Console.WriteLine("Ingresa el lado del cubo: ");
            L = int.Parse(Console.ReadLine());
            area = 6 * L * L;
            volumen = L * L * L;
            Console.WriteLine("El Area es: " + area);
            Console.WriteLine("El Volumen es: " + volumen);
            Console.ReadKey();
        }
    }
}
