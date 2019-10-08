using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class pago
    {
        public static int totalentradas=0;
        public decimal precioadul = 4.25m, precioadulmayor = 3.25m, precionino = 2.25m,efectivo,totalpago, cantidadtotal,cambio;
        public int op, can_adul, can_nino, can_adulmayor;
        public static int can_vole_adul=0, can_vole_adulmayor, can_vole_nin;
        public string tarjeta= String.Format("{0: #### #### #### ####}", 5146653919097121);
        venta_de_boletos venbol = new venta_de_boletos();
        comida com = new comida();
        public string[] tarjetas = new string[5];
       public static int peli1, peli2, peli3, peli4, bap1 = 0, bamp1 = 0,
      bnp1 = 0, bap2 = 0, bamp2 = 0, bnp2 = 0, bap3 = 0,
      bamp3 = 0, bnp3 = 0, bap4 = 0, bamp4 = 0, bnp4 = 0;

        public void pagar()
        {
            pago pag_o = new pago();
            decimal din;
            int cvc = 263,cvc1=619,codigo;
            //string fecha = "01 / 2025";
            tarjetas[0] = "5146653919097121";
            tarjetas[1] = "51143169704119731";
            do
            {
                
                    Console.Clear();
                    Console.WriteLine("   *******************************************************************");
                    Console.WriteLine("         Tipo de entrada     ||  Precio    || Cantidad seleccionada");
                    Console.WriteLine("   *******************************************************************");
                    Console.WriteLine("      1-) Adulto             ||   $4.25    ||        " + can_adul);
                    Console.WriteLine();
                    Console.WriteLine("      2-) Adulto Mayor       ||   $3.25    ||        " + can_adulmayor);
                    Console.WriteLine();
                    Console.WriteLine("      3-) Niño               ||   $2.25    ||        " + can_nino);
                    Console.WriteLine();
                    Console.WriteLine("   *******************************************************************");
                    Console.WriteLine("      4-)Continuar         5-)Cancelar       6-)comida");
                    Console.WriteLine("   *******************************************************************");
                totalentradas = can_adul + can_adulmayor + can_nino;
                op = Convert.ToInt32(Console.ReadLine());
                
                switch (op)

                    {
                        case 1:

                            can_adul = can_adul + 1;
                            break;
                        case 2:

                            can_adulmayor = can_adulmayor + 1;


                            break;
                        case 3:

                            can_nino = can_nino + 1;
                            break;
                    
                        case 4:
                            butacas buta = new butacas();
                            if (can_adul> 0 || can_adulmayor > 0 || can_nino > 0 )
                            {
                            buta.buta_cas();

                                Console.WriteLine("¿¿Seguro que desea continuar con el pago??");
                                Console.WriteLine("1-)Si        2-)No");
                                int dec = Convert.ToInt32(Console.ReadLine());
                                if (dec == 1)
                                {
                                    op = 5;
                                    goto recibo;
                                }
                                else
                                {
                                    Console.WriteLine("Presione <enter> para continuar");
                                    Console.ReadKey();

                                }
                            }
                           
                            break;
                        case 5:
                            op = 7;
                            break;
                        case 6:

                            com.venta_comida();
                            break;
                        default:
                            break;
                    }
             
            } while (op != 7);
            goto salir;
        recibo:

            
            Console.Clear();
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Seleccione modo de pago");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1-)Tarjeta de crédito o debito");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2-)Efectivo");
            int dec2 = Convert.ToInt32(Console.ReadLine());
            switch (dec2)
            {
                case 1:
                    cantidadtotal = (can_adul * precioadul) + (can_adulmayor * precioadulmayor) + (can_nino * precionino);
                    totalpago = cantidadtotal + com.total;
                    do
                    {
                        Console.WriteLine("Ingrese su numero de tarjeta:");
                        tarjeta = Console.ReadLine();
                        if (tarjeta != tarjetas[0] && tarjeta != tarjetas[1])
                        {
                            Console.WriteLine("Numero de tarjeta incorrecta");
                        }
                    } while (tarjeta != tarjetas[0] && tarjeta != tarjetas[1]);
                    do
                    {
                        Console.WriteLine("Ingrese codigo de seguridad ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        if (codigo!=cvc && codigo!=cvc1)
                        {
                            Console.Clear();
                            Console.WriteLine("Codigo inccorecto incorrecto");
                        }
                    } while ((codigo != cvc) && (codigo != cvc1));

                    if (tarjeta== "5146653919097121")
                    {
                        decimal dintar1 = 100.55m;
                         din = dintar1;
                    }
                    else
                    {
                       decimal dintar2 = 3.50m;
                        din = dintar2;
                    }
                    if (din < totalpago)
                    {
                        Console.WriteLine("El saldo de su tarjeta es insuficiente");
                        Console.WriteLine("Desea continuar con el pago en efectivo???");
                        Console.WriteLine("1-)Si        2-)No");
                        int dec = Convert.ToInt32(Console.ReadLine());
                        if (dec == 1)
                        {
                            goto case 2;
                        }
                        else
                        {
                            Program.Main();
                        }
                    }
                   
                    break;
                case 2:
                    Console.WriteLine("Ingrese Cantidad de dinero entregado");
                    efectivo = Convert.ToDecimal(Console.ReadLine());
                    cantidadtotal = (can_adul * precioadul) + (can_adulmayor * precioadulmayor) + (can_nino * precionino);
                    totalpago = cantidadtotal + com.total;
                    if (efectivo < totalpago)
                    {
                        Console.WriteLine("Dinero insuficiente");
                        goto case 2;
                    }
                    break;
                default:
                   
                    break;
            }

           
            cambio = efectivo-totalpago ;
           
            Console.Clear();
            Console.WriteLine("Recibibo");
            Console.WriteLine("*****************************");
            Console.WriteLine("  Cinepolis El Salvador");
            Console.WriteLine("*****************************");
            Console.WriteLine("Pelicula: "+ Program.peli[venta_de_boletos.elepeli]);
            Console.WriteLine("*****************************");
            Console.WriteLine("Hora: "+modoventa.horario[venta_de_boletos.elepeli]);
            Console.WriteLine("Sala: "+modoventa.sala[venta_de_boletos.elepeli]);
            Console.WriteLine("*****************************");
            if (can_nino > 0)
            {
                Console.WriteLine("Entradas para niño: " + can_nino);
                Console.WriteLine();
            }
            if (can_adul > 0)
            {
                Console.WriteLine("Entradas para Adulto: " + can_adul);
                Console.WriteLine();
            }
            if (can_adulmayor > 0)
            {
                Console.WriteLine("Entradas para Adulto mayor: " + can_adulmayor);
                Console.WriteLine();
            }
            Console.WriteLine("*****************************");
            Console.WriteLine("Total en Entradas:    "+cantidadtotal.ToString("C2"));
            Console.WriteLine("*****************************");
            Console.WriteLine("Gasto en comida:      "+com.total.ToString("C2"));
            Console.WriteLine("*****************************");
            Console.WriteLine("Total a pagar:        "+totalpago.ToString("C2"));
            Console.WriteLine("*****************************");
            if (dec2==2)
            {
                Console.WriteLine("Cambio:               " + cambio.ToString("C2"));
                Console.WriteLine("*****************************");
            }
            else
            {
                Console.WriteLine("Pago hecho con tarjeta");
            }
            Console.WriteLine();
            Console.WriteLine("Gracias por preferirnos!!!!");
            can_vole_adul = can_vole_adul+can_adul;
            can_vole_adulmayor = can_vole_adulmayor+ can_adulmayor;
            can_vole_nin =can_vole_nin+ can_nino;
          
            venta_de_boletos venbol = new venta_de_boletos();
            

            switch (venta_de_boletos.elepeli)
            {
                case 1:
                    bap1 = bap1 + can_adul;
                    bamp1 = bamp1 + can_adulmayor;
                    bnp1 = bnp1 + can_nino;
                    peli1 = bamp1 + bap1 + bnp1;
                    break;
                case 2:
                    bap2 = bap2 + can_adul;
                    bamp2 = bamp2 + can_adulmayor;
                    bnp2 = bnp2 + can_nino;
                    peli2 = bamp2 + bap2 + bnp2;
                    break;
                case 3:
                    bap3 = bap3 + can_adul;
                    bamp3 = bamp3 + can_adulmayor;
                    bnp3 = bnp3 + can_nino;
                    peli3 = bamp3 + bap3 + bnp3;
                    break;
                case 4:
                    bap4 = bap4 + can_adul;
                    bamp4 = bamp4 + can_adulmayor;
                    bnp4 = bnp4 + can_nino;
                    peli4 = bamp4 + bap4 + bnp4;
                    break;
                default:
                    break;

            }
            Console.ReadKey();
        salir:
            Program.Main();


        }
      
        
      
    }
}
