using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoDD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int deci2 = 0;
            int deci = 0;

            do
            {
               
                Console.WriteLine("Quieres jugar?");
                Console.WriteLine("0-SI");
                Console.WriteLine("1-NO");
          
                do
                {
        
                    try
                    {
                        Console.WriteLine("DECIDE....(escribe solo 0 y 1)");
                        deci = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debe ingresar obligatoriamente un número entero.");

                    }

                } while (deci != 0 && deci != 1);

                if (deci == 0)
                {
                    Campo_batalla camp = new Campo_batalla();
                }
                else if (deci == 1)
                {
                    Console.WriteLine("MUY BIEN.... ADIOS");
                    break;
                }

                Console.WriteLine("Quieres seguir jugando?");
                Console.WriteLine("0-SI");
                Console.WriteLine("1-NO");
                Console.WriteLine("DECIDE....(escribe solo 0 y 1)");

                deci = Convert.ToInt32(Console.ReadLine());

            } while (deci2 != 0 && deci2 != 1);
        }
    }
}
