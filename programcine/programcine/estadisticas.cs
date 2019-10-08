using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class estadisticas
    {
        
    
            public void menu_estadistica()
        {
            pago pag = new pago();
            estadisticas esta = new estadisticas();
            // venta_de_boletos venbol = new venta_de_boletos();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("cuales ventas de voletos desea ver??");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Pelicula 1: "+Program.peli[1]);
            Console.WriteLine();
            Console.WriteLine("Pelicula 2: " + Program.peli[2]);
            Console.WriteLine();
            Console.WriteLine("Pelicula 3: " + Program.peli[3]);
            Console.WriteLine();
            Console.WriteLine("Pelicula 4: " + Program.peli[4]);
            Console.WriteLine();
            Console.WriteLine("Estadistica de mas vendida");
            Console.WriteLine();
            int dec = Convert.ToInt32(Console.ReadLine());
            switch (dec)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("  Ventas total por la pelicula: "+ Program.peli[1]);
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por niño:"+pago.bnp1);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto: "+pago.bap1);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto mayor: "+pago.bamp1);
                    Console.WriteLine();
                    Console.WriteLine("  Total de ventas por pelicula: "+pago.peli1);
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("  Ventas total por la pelicula: " + Program.peli[2]);
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por niño:" + pago.bnp2);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto: " + pago.bap2);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto mayor: " + pago.bamp2);
                    Console.WriteLine();
                    Console.WriteLine("  Total de ventas por pelicula: " + pago.peli2);
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("  Ventas total por la pelicula: " + Program.peli[3]);
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por niño:" + pago.bnp3);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto: " + pago.bap3);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto mayor: " + pago.bamp3);
                    Console.WriteLine();
                    Console.WriteLine("  Total de ventas por pelicula: " + pago.peli3);
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("  Ventas total por la pelicula: " + Program.peli[4]);
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por niño:" + pago.bnp4);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto: " + pago.bap4);
                    Console.WriteLine();
                    Console.WriteLine("  Cantidad de ventas por adulto mayor: " + pago.bamp4);
                    Console.WriteLine();
                    Console.WriteLine("  Total de ventas por pelicula: " + pago.peli4);
                    Console.WriteLine();
                    Console.WriteLine("**************************************************************");
                    break;
                case 5:
                    esta_peli1();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        public void esta_peli1()
        {
            int mayor=0, medio=0, mediomedio=0, menor=0;
            //pago pag_o = new pago();
            Console.WriteLine("Cantidad de entredas vendidas");
            Console.WriteLine();
            Console.WriteLine("Adulto: "+pago.can_vole_adul);
            Console.WriteLine();
            Console.WriteLine("Adulto Mayor: "+pago.can_vole_adulmayor);
            Console.WriteLine();
            Console.WriteLine("Niños: "+pago.can_vole_nin);
            Console.WriteLine();
            Console.WriteLine("*******************************************");
            if (pago.peli1>pago.peli2 && pago.peli1 > pago.peli3 && pago.peli1 > pago.peli4)
            {
                mayor = pago.peli1;
                Console.WriteLine(Program.peli[1]+"*****************************");
                if ( pago.peli2 > pago.peli3 && pago.peli2 > pago.peli4)
                {
                    medio = pago.peli2;
                    Console.WriteLine(Program.peli[2] + "*********************");
                    if ( pago.peli3 > pago.peli4)
                    {
                        mediomedio = pago.peli3;
                        Console.WriteLine(Program.peli[3] + "*****************");
                        menor = pago.peli4;
                        Console.WriteLine(Program.peli[4] + "*********");
                    }
                }
            }else
                if (pago.peli2 > pago.peli1 && pago.peli2 > pago.peli3 && pago.peli2 > pago.peli4)
            {
                mayor = pago.peli2;
                Console.WriteLine(Program.peli[2] + "*****************************");
                if (pago.peli1 > pago.peli3 && pago.peli1 > pago.peli4)
                {
                    medio = pago.peli1;
                    Console.WriteLine(Program.peli[1] + "*********************");
                    if (pago.peli3 > pago.peli4)
                    {
                        mediomedio = pago.peli4;
                        Console.WriteLine(Program.peli[3] + "*****************");
                        menor = pago.peli3;
                        Console.WriteLine(Program.peli[4] + "*********");
                    }
                }
            }
            else
                if (pago.peli3 > pago.peli1 && pago.peli3 > pago.peli2 && pago.peli3 > pago.peli4)
            {
                mayor = pago.peli3;
                Console.WriteLine(Program.peli[3] + "*****************************");
                if (pago.peli1 > pago.peli2 && pago.peli1 > pago.peli4)
                {
                    medio = pago.peli1;
                    Console.WriteLine(Program.peli[1] + "*********************");
                    if (pago.peli2 > pago.peli4)
                    {
                        mediomedio = pago.peli2;
                        Console.WriteLine(Program.peli[2] + "*****************");
                        menor = pago.peli4;
                        Console.WriteLine(Program.peli[4] + "*********");
                    }
                }
            }
            else
                if (pago.peli4 > pago.peli1 && pago.peli4 > pago.peli2 && pago.peli4 > pago.peli3)
            {
                mayor = pago.peli4;
                Console.WriteLine(Program.peli[4] + "*****************************");
                if (pago.peli1 > pago.peli2 && pago.peli1 > pago.peli3)
                {
                    medio = pago.peli1;
                    Console.WriteLine(Program.peli[1] + "*********************");
                    if (pago.peli2 > pago.peli3)
                    {
                        mediomedio = pago.peli2;
                        Console.WriteLine(Program.peli[2] + "*****************");
                        menor = pago.peli3;
                        Console.WriteLine(Program.peli[3] + "*********");
                    }
                }
            }
            Console.WriteLine(""+mayor);
            Console.WriteLine(""+medio);
            Console.WriteLine(""+mediomedio);
            Console.WriteLine(""+menor);
            Console.ReadKey();
        }
       
          
           
        
    }
}
