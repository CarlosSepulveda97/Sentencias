using System;

namespace Sentencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BLUEGLOBAL SPA");

            Console.WriteLine("==================================");

            Console.WriteLine("Bienvenido al programa que le permitirá\nseleccionar el tipo de trabajo que va a realizar");

            Console.WriteLine("==================================");

            Console.WriteLine("Para ser desarrollador presione A");

            Console.WriteLine("Para ser de marketing presione B");

            Console.WriteLine("==================================");

            Console.WriteLine("Porfavor digite una opción válida");

            string valor = Console.ReadLine().ToUpper();

            if (valor == "A")
            {
                Console.Clear();
                Console.WriteLine("Opcion Desarrollador\n\nCOMPROBAR SUELDO (Desarrollador)");
                Console.WriteLine("==================================");
                Console.WriteLine("Para mostrar sueldo presione s");
                string mostrar = Console.ReadLine().ToUpper();
                if (mostrar == "S")
                {
                    Desarrollador dev = new Desarrollador();
                    Console.WriteLine(dev.getSueldo());
                }
                
            }
            else if (valor=="B"){
                Console.Clear();
                Console.WriteLine("Opcion Marketing\n\nCOMPROBAR SUELDO (Marketing)");
                Console.WriteLine("==================================");
                Console.WriteLine("Para mostrar sueldo presione s");
                string mostrar = Console.ReadLine().ToUpper();
                if (mostrar == "S")
                {
                    Marketing mar = new Marketing();
                    Console.WriteLine(mar.getSueldo());
                }
            }
            else
            {
                Console.WriteLine("No se ingreso una opcion valida");
            }
              
        }
    }
}
