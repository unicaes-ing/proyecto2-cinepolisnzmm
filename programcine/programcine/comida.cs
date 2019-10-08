using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class comida
    {
        public string comida1 = "hot-dog", comida2 = "palomitas", comida3 = "palomitas dulces", comida4 = "soda pequeña", comida5 = "soda mediana", comida6 = "soda grande", comida7 = "Agua", comida8 = "nachos";
        public decimal total, precom1 = 1.75m, precom2 = 2.50m, precom3 = 2.00m, precom4 = 1.25m, precom5 = 1.75m, precom6 = 2.25m, precom7 = 0.75m, precom8 = 2.95m, pagocomida1, pagocomida2, pagocomida3, pagocomida4, pagocomida5, pagocomida6, pagocomida7, pagocomida8;
        public int cantidad1=0, cantidad2, cantidad3, cantidad4, cantidad5, cantidad6, cantidad7, cantidad8;
        public void venta_comida()
        {
            int dec;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Comida                ||      precio         ||    Cantidad seleccionada");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("1-)" + comida1 + "            || " + "      " + precom1.ToString("C2")+ "         ||             " + cantidad1);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("2-)" + comida2 + "          || " + "      " + precom2.ToString("C2") + "         ||             " + cantidad2);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("3-)" + comida3 + "   || " + "      " + precom3.ToString("C2") + "         ||             " + cantidad3);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("4-)" + comida4 + "       || " + "      " + precom4.ToString("C2") + "         ||             " + cantidad4);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("5-)" + comida5 + "       || " + "      " + precom5.ToString("C2") + "         ||             " + cantidad5);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("6-)" + comida6 + "        || " + "      " + precom6.ToString("C2") + "         ||             " + cantidad6);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("7-)" + comida7 + "               || " + "      " + precom7.ToString("C2") + "         ||             " + cantidad7);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("8-)" + comida8 + "             || " + "      " + precom8.ToString("C2") + "         ||             " + cantidad8);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("9-)Continuar");
                dec = Convert.ToInt32(Console.ReadLine());
                switch (dec)
                {
                    case 1:
                        Console.WriteLine(comida1);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad1 = Convert.ToInt32(Console.ReadLine());
                        pagocomida1 = cantidad1 * precom1;
                        break;
                    case 2:
                        Console.WriteLine(comida2);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad2 = Convert.ToInt32(Console.ReadLine());
                        pagocomida2 = cantidad2 * precom2;
                        break;
                    case 3:
                        Console.WriteLine(comida3);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad3 = Convert.ToInt32(Console.ReadLine());
                        pagocomida3 = cantidad3 * precom3;
                        break;
                    case 4:
                        Console.WriteLine(comida4);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad4 = Convert.ToInt32(Console.ReadLine());
                        pagocomida4 = cantidad4 * precom4;
                        break;
                    case 5:
                        Console.WriteLine(comida5);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad5 = Convert.ToInt32(Console.ReadLine());
                        pagocomida5 = cantidad5 * precom5;
                        break;
                    case 6:
                        Console.WriteLine(comida6);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad6 = Convert.ToInt32(Console.ReadLine());
                        pagocomida6 = cantidad6 * precom6;
                        break;
                    case 7:
                        Console.WriteLine(comida7);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad7 = Convert.ToInt32(Console.ReadLine());
                        pagocomida7 = cantidad7 * precom7;
                        break;
                    case 8:
                        Console.WriteLine(comida8);
                        Console.WriteLine("Ingrese cantidad deseada: ");
                        cantidad8 = Convert.ToInt32(Console.ReadLine());
                        pagocomida8 = cantidad8 * precom8;
                        break;
                    case 9:
                        break;
                    default:
                        break;
                }
            } while (dec != 9);
            total = pagocomida1+ pagocomida2+ pagocomida3+ pagocomida4+ pagocomida5+ pagocomida6+ pagocomida7+ pagocomida8;
            Console.ReadKey();


        }
    }
}
