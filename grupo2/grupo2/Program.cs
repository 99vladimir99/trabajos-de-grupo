using System;

namespace grupo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Title = " El sexo de una persona";
                Int32 edad;
                String nombre, sexo;
                Console.WriteLine("escribe tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("escribe tu edad");
                edad = Int32.Parse(Console.ReadLine());
                Console.WriteLine("escribe tu sexo ( Hombre=M y Mujer=F )");
                sexo = Console.ReadLine();
                if (sexo == "M" || sexo == "m") // instruccion lógica OR
                {
                    Console.WriteLine("\nEl Sr {0} ha sido registrado", nombre); // v 
                }
                else
                {
                    Console.WriteLine("\nLa Sra {0} ha sido registrada", nombre); // f
                }
                Console.WriteLine("\n\n");
                Console.ReadKey();
            
        }
    }
}
