using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n -------- Ejercicio Clase #10 --------");
            Console.WriteLine("\n Ingrese un número del 1 al 6 para obtener el nombre del mes: ");

            int MonthNumber = int.Parse(Console.ReadLine());

            string Month;

            switch (MonthNumber)
            {
                case 1:
                    Month = "Enero";
                    break;

                case 2:
                    Month = "Febrero";
                    break;

                case 3:
                    Month = "Marzo";
                    break;

                case 4:
                    Month = "Abril";
                    break;

                case 5:
                    Month = "Mayo";
                    break;

                case 6:
                    Month = "Julio";
                    break;
                default:
                    Console.WriteLine("Advertencia: Numero no valido, ingrese un número del 1 al 6.");
                    return;
            }

            Console.WriteLine($"El mes {MonthNumber} es {Month}.");
            Console.ReadKey();
        }
    }
}