using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
    {
        class venta_de_boletos
        {


           
        public static int elepeli;//elipeli es eleccion de pelicula
        public void venta()
            {
                butacas but = new butacas();
                modoventa modven = new modoventa();
            
                
                do {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================================");
                        Console.WriteLine("       Cartelera de peliculas");
                        Console.WriteLine("======================================");
                        Console.WriteLine("1-)" + Program.peli[1]);
                        Console.WriteLine("2-)" + Program.peli[2]);
                        Console.WriteLine("3-)" + Program.peli[3]);
                        Console.WriteLine("4-)" + Program.peli[4]);
                        Console.WriteLine("*************************************");
                        Console.WriteLine("5-)Regresar");
                        elepeli = Convert.ToInt32(Console.ReadLine());
                        switch (elepeli)
                        {
                            case 1:
                                modven.modo_venta_peli1();

                                break;
                            case 2:
                                modven.modo_venta_peli2();
                                break;
                            case 3:
                                modven.modo_venta_peli3(); ;
                                break;
                            case 4:
                                Console.WriteLine(Program.peli[4]);
                                break;
                            case 5:
                           
                                break;
                            default:
                                Console.Clear();
                                Console.SetCursorPosition(15,8);
                                Console.WriteLine("****************************************");
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("Ingrese una opción válida!!");
                                Console.SetCursorPosition(19, 12);
                                Console.WriteLine("Presione <enter> para continuar");
                                Console.SetCursorPosition(15, 14);
                                Console.WriteLine("****************************************");
                                Console.ReadKey();
                                break;
                        }
                    } while (elepeli!=5);
                Console.Clear();
                Console.SetCursorPosition(9, 10);
                Console.WriteLine("Presione <enter> para continuar");
                Console.ReadKey();
            Program.Main();
            }
        }
       
    }

