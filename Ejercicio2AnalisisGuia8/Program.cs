using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Double radio, angulo, x, y;


            Console.Title = "Convertir coordenadas polares a rectangulares.";

            Console.WriteLine("Ingrese el valor del radio:");
            radio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del ángulo:");
            angulo = Double.Parse(Console.ReadLine());


            x = radio * Math.Cos(angulo);
            y = radio * Math.Sin(angulo);

            Console.Write("Las coordenadas rectangulares son: ");
            Console.Write("X = "+(x.ToString("#.##")));
            Console.Write(" , Y = " + (y.ToString("#.##")));
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
