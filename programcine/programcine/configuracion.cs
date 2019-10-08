using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class configuracion
    {
       
        public void confi()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("1-)Configuracion de cartelera");
            Console.WriteLine();
            Console.WriteLine("2-)Vaciar las salas");
            Console.WriteLine();
            Console.WriteLine("3-)Volver al inicio");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)

            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("               **********************************");
                    Console.WriteLine("                Seleccione la pelicula a cambiar");
                    Console.WriteLine("               **********************************");
                    Console.WriteLine();
                    Console.WriteLine("Pelicula 1"+Program.peli[1]);
                    Console.WriteLine("Pelicula 2" + Program.peli[2]);
                    Console.WriteLine("Pelicula 3" + Program.peli[3]);
                    Console.WriteLine("Pelicula 4" + Program.peli[4]);
                    int  dec = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Cambiar nombre de pelicula " + dec);
                    Console.WriteLine();
                    Console.WriteLine("Nombre actual: " + Program.peli[dec]);
                    Console.WriteLine();
                    Console.Write("Nuevo nombre: ");
                    Program.peli[dec] = Console.ReadLine();
                    
                    break;
                case 2:
                    break;
                case 3:
                    Program.Main();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
