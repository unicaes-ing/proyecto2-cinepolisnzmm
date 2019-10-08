using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class Program
    {
        public static string[] peli = new string[5];
        public static void Main()
        {
            peli[1] = "Guasón";
            peli[2] = "Rambo";
            peli[3] = "Mi amigo abominable";
            peli[4] = "Dora la ciudad perdida";
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("   ***************************************************");
                Console.WriteLine("                   Bienvenido a cinepolis");
                Console.WriteLine("   ***************************************************");
                Console.WriteLine();
                Console.WriteLine("      Elija una opción:");
                Console.WriteLine();
                Console.WriteLine("         1-)Venta de boletos");
                Console.WriteLine("         2-)Estadísticas");
                Console.WriteLine("         3-)Configuración");
                Console.WriteLine("         4-)Salir");                
                Console.WriteLine();
                Console.WriteLine("   ***************************************************");
                Console.Write("opcion: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        venta_de_boletos venbol = new venta_de_boletos();
                        venbol.venta();
                        break;
                    case 2:
                        estadisticas esta = new estadisticas();
                        esta.menu_estadistica();
                        break;
                    case 3:
                        configuracion conf =new configuracion();
                        
                        conf.confi();
                        break;
                    case 4:
                        goto salir;
                      
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion válida");
                        Console.WriteLine("Presione <enter> para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (op!=4);
            salir:
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                     Gracias por utilizar el programa");
            Console.WriteLine("                  Presione <enter> para continuar y salir");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
