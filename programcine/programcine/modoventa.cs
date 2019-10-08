using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    public class modoventa
    {
        
        venta_de_boletos venbol = new venta_de_boletos();
        public static int [] sala= new int [5];
            public static int op;
        public static string [] horario= new string [6];
        pago pag_o = new pago();
        #region peli1
        public void modo_venta_peli1()
        {
            
        
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("      " + Program.peli[1]);
                    Console.WriteLine("========================================");
                    Console.WriteLine();
                    Console.WriteLine("****************************************");
                    Console.WriteLine("*  Horario disponible   ||   sala      *");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("*1-)   12:30 pm          ||     5      *");
                    Console.WriteLine("*2-)    1:30 pm          ||     3      *");
                    Console.WriteLine("*3-)    2:30 pm          ||     4      *");
                    Console.WriteLine("*4-)    4:30 pm          ||     2      *");
                    Console.WriteLine("*5-)    6:30 pm          ||     1      *");
                    Console.WriteLine("****************************************");
                    Console.WriteLine(             "6-)Cancelar");
                    Console.WriteLine("****************************************");
                    op = Convert.ToInt32(Console.ReadLine());
                 
                    switch (op)
                    {
                        case 1:
                            horario[1] = "12:30 pm";
                            sala[1] = 5;
                        
                            break;
                        case 2:
                            horario[1] = "1:30 pm";
                            sala[1] = 3;
                            break;
                        case 3:
                            horario[1] = "2:30 pm";
                            sala[1] = 4;
                            break;
                        case 4:
                            horario[1] = "4:30 pm";
                            sala[1] = 2;
                            break;
                        case 5:
                            horario[1] = "6:30 pm";
                            sala[1] = 1;
                            break;
                        case 6:
                            venbol.venta();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción incorrecta!!");
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadKey();
                            break;
                    }
                pag_o.pagar();
            } while (op != 6);
         
        }
        #endregion

        #region peli2
        public void modo_venta_peli2()
        {
           
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("========================================");
                    Console.WriteLine("      " + Program.peli[2]);
                    Console.WriteLine("========================================");
                    Console.WriteLine();
                    Console.WriteLine("****************************************");
                    Console.WriteLine("*  Horario disponible    ||   sala     *");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("*1-)    2:30 pm          ||     5      *");
                    Console.WriteLine("*2-)    3:30 pm          ||     3      *");
                    Console.WriteLine("*3-)    4:30 pm          ||     1      *");
                    Console.WriteLine("*4-)    6:45 pm          ||     2      *");
                    Console.WriteLine("*5-)   10:30 pm          ||     1      *");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("6-)Cancelar");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            horario[2] = "2:30 pm";
                            sala[2] = 5;
                        
                        break;
                        case 2:
                            horario[2] = "3:30 pm";
                            sala[2] = 3;
                            break;
                        case 3:
                            horario[2] = "4:30 pm";
                            sala[2] = 1;
                            break;
                        case 4:
                            horario[2] = "6:45 pm";
                            sala[2] = 2;
                            break;
                        case 5:
                            horario[2] = "10:30 pm";
                            sala[2] = 1;
                            break;
                        case 6:
                            venbol.venta();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción incorrecta!!");
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadKey();
                            break;
                    }
                pag_o.pagar();
            } while (op != 6);

        }
        #endregion

        #region peli3
        public void modo_venta_peli3()
        {
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine("      "+Program.peli[3]);
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("*  Horario disponible    ||   sala     *");
                Console.WriteLine("****************************************");
                Console.WriteLine("*1-)   12:30 pm          ||     3      *");
                Console.WriteLine("*2-)   10:30 am          ||     1      *");
                Console.WriteLine("*3-)    9:30 am          ||     4      *");
                Console.WriteLine("*4-)   11:30 am          ||     2      *");
                Console.WriteLine("*5-)    5:30 pm          ||     1      *");
                Console.WriteLine("****************************************");
                Console.WriteLine("6-)Cancelar");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        horario[3] = "12:30 pm";
                        sala[3] = 3;
                        break;
                    case 2:
                        horario[3] = "10:30 am";
                        sala[3] = 1;
                        break;
                    case 3:
                        horario[3] = "9:30 am";
                        sala[3] = 4;
                        break;
                    case 4:
                        horario[3] = "11:30 am";
                        sala[3] = 2;
                        break;
                    case 5:
                        horario[3] = "5:30 pm";
                        sala[3] = 1;
                        break;
                    case 6:
                        venbol.venta();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción incorrecta!!");
                        Console.WriteLine("Ingrese una opción válida");
                        Console.ReadKey();
                        break;
                }
                pag_o.pagar();
            } while (op != 6);
        }
        #endregion

        #region peli4
        public void modo_venta_peli4()
        {
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine("      " + Program.peli[4]);
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("*  Horario disponible    ||   sala     *");
                Console.WriteLine("****************************************");
                Console.WriteLine("*1-)   12:30 pm          ||     3      *");
                Console.WriteLine("*2-)   10:30 am          ||     1      *");
                Console.WriteLine("*3-)    9:30 am          ||     4      *");
                Console.WriteLine("*4-)   11:30 am          ||     2      *");
                Console.WriteLine("*5-)    5:30 pm          ||     1      *");
                Console.WriteLine("****************************************");
                Console.WriteLine("6-)Cancelar");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        horario[4] = "12:30 pm";
                        sala[4] = 3;
                        break;
                    case 2:
                        horario[4] = "10:30 am";
                        sala[4] = 1;
                        break;
                    case 3:
                        horario[4] = "9:30 am";
                        sala[4] = 4;
                        break;
                    case 4:
                        horario[4] = "11:30 am";
                        sala[4] = 2;
                        break;
                    case 5:
                        horario[4] = "5:30 pm";
                        sala[4] = 1;
                        break;
                    case 6:
                        venbol.venta();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción incorrecta!!");
                        Console.WriteLine("Ingrese una opción válida");
                        Console.ReadKey();
                        break;
                }
                pag_o.pagar();
            } while (op != 6);
        }
        #endregion

    }
}
