using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcine
{
    class butacas
    {
        public void buta_cas()
        {
            int[] c = new int[pago.totalentradas], f = new int[pago.totalentradas];
      
            string[] fila = new string[10];
            fila[0] = "A"; fila[1] = "B"; fila[2] = "C"; fila[3] = "D"; fila[4] = "E";
            fila[5] = "F"; fila[6] = "G"; fila[7] = "H"; fila[8] = "I"; fila[9] = "J";


           
                for (int i = 0; i < pago.totalentradas; i++)
                {
                  
                    Console.WriteLine("Selecione fila");
                    f[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seleccione numero de asiento");
                    c[i] = Convert.ToInt32(Console.ReadLine());
                f[i] -= 1;
                c[i] -= 1;
            }
                
                for (int i = 0; i < fila.Length; i++)
                {
                    Console.WriteLine();
                for (int co = 0; co < 10; co++)
                {

                    if (fila[f.Length] == fila[i] && c.Length == co)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(" █▄" + fila[i] + "{0}" + "▄█   ",co+1);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");
                }
              
                Console.ReadKey();
              
            Console.ReadKey();
        }
    }
      
}
        
    


