using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butacas
{
    class Class2
    {
       static void mostrar_asientos(string[][] butacas, int cantidad_asientos)
        {
            //PANTALLA PRINCIPAL
            Console.Write("  ------------------------------------------");
            Console.Write("\n                  PANTALLA\n");
            Console.Write("  ------------------------------------------\n");
            for (int i = 0; i < DefineConstants.columnas; i++)
            {
                Console.Write("  {0} ", i + 1); //Columnas contador
                if (i == 1)
                {
                    Console.Write("  ");
                }
                if (i == 7)
                {
                    Console.Write("  ");
                }

            }
            Console.Write("\n");
            for (int i = 0; i < DefineConstants.filas; i++)
            {
                Console.Write("{0} ", i + 1); //Contador filas
                for (int x = 0; x < DefineConstants.columnas; x++)
                {
                    Console.Write("{0}  ", butacas[i][x]);
                    if (x == 1)
                    {
                        Console.Write("  ");
                    }
                    if (x == 7)
                    {
                        Console.Write("  ");
                    }

                }
                Console.Write("\n");
            }
            Console.Write("\n");


        }


        static void Main(string[] args)
        {
            string[][] butacas = new string[DefineConstants.filas][]; //Declaración variables
            int fila_pedida;
            int columna_pedida;
            int opcion;
            int break_menu = 1;
            int asientos_libres = DefineConstants.filas * DefineConstants.columnas;
            int asientos_usados = 0;
            int cantidad_asientos = 0;
            int c_asientos_copy = 0;
            int asientos_a_eliminar = 0;
            int asientos_a_eliminar_copy;
            //Fin declaración variables

            for (int i = 0; i < DefineConstants.filas; i++)
            { //Rellenado de asientos 'O' libre 'X' ocupado.
                for (int x = 0; x < DefineConstants.columnas; x++)
                {
                    butacas[i][x] = "O";
                }
            }
            do
            {
                Console.Write("\nBIENVENIDO AL MENU DE LAS BUTACAS\n\n");
                Console.Write("1. Mostrar asientos\n");
                Console.Write("2. Solicitar asiento\n");
                Console.Write("3. Eliminar asiento\n");
                Console.Write("Eliga una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                { //Menú

                    case 1:
                        mostrar_asientos(butacas, cantidad_asientos);
                        break;
                    case 2:
                        Console.Write("Cantidad de asientos: ");
                        cantidad_asientos = Convert.ToInt32(Console.ReadLine());
                        //MOSTRAR ASIENTOS
                        mostrar_asientos(butacas, cantidad_asientos);
                        c_asientos_copy = cantidad_asientos;
                        for (int x = 0; x < cantidad_asientos; x++)
                        {
                            Console.Write("Asientos por elegir: {0}\n", c_asientos_copy);
                            Console.Write("Ingrese la fila de la butaca: ");
                            fila_pedida = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese la columna de la butuca: ");
                            columna_pedida = Convert.ToInt32(Console.ReadLine());
                            if (butacas[fila_pedida - 1][columna_pedida - 1] == "O")
                            {
                                butacas[fila_pedida - 1][columna_pedida - 1] = "X";
                                asientos_libres--;
                                asientos_usados++;

                                c_asientos_copy--;
                                mostrar_asientos(butacas, cantidad_asientos);



                            }
                        }

                        Console.Write("Asientos disponibles: {0}\n", asientos_libres);
                        Console.Write("Asientos usados: {0}\n", asientos_usados);
                        break;
                    case 3:
                        Console.Write("Cantidad a eliminar: ");
                        asientos_a_eliminar = Convert.ToInt32(Console.ReadLine());
                        asientos_a_eliminar_copy = asientos_a_eliminar;
                        mostrar_asientos(butacas, cantidad_asientos);
                        for (int x = 0; x < asientos_a_eliminar; x++)
                        {
                            Console.Write("Asientos por eliminar: {0}\n", asientos_a_eliminar_copy);
                            Console.Write("\nIngrese la fila de la butaca: ");
                            fila_pedida = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese la columna de la batuca: ");
                            columna_pedida = Convert.ToInt32(Console.ReadLine()); ;
                            if (butacas[fila_pedida - 1][columna_pedida - 1] == "X")
                            {
                                butacas[fila_pedida - 1][columna_pedida - 1] = "O";
                                asientos_libres++;
                                asientos_usados--;
                            }
                            mostrar_asientos(butacas, cantidad_asientos); // mostrar asientos
                            Console.Write("Asientos disponibles: {0}\n", asientos_libres);
                            Console.Write("Asientos usados: {0}\n", asientos_usados);
                            asientos_a_eliminar_copy--;
                        }
                        break;
                    case 4:
                        break_menu++;

                        break;
                }
            } while (break_menu < 2);
        }


        internal static class DefineConstants
        {
            public const int filas = 10;
            public const int columnas = 10;
        }
    }

}