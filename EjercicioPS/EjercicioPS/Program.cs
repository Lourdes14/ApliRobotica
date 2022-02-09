using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int productos;
            double desc;
            double total;
            double porcentaje;
            double monto;
            char OP = 'S';

            Console.Write("Ingrese el numero de productos: ");
            productos = int.Parse(Console.ReadLine());

            if(productos<4)
            {
                for (int x = 0; x <= 3; x++)
                {
                    
                        Console.Write("Ingrese el valor de productos: ");
                        monto = double.Parse(Console.ReadLine());

                        if (monto > 150 && monto < 500)
                        {
                            desc = 10;
                            Console.WriteLine("El porcentaje de su descuento es de: " + desc);
                            porcentaje = (monto* (desc / 100));
                            Console.WriteLine("Su descuento es de : " + porcentaje);
                            total = monto - porcentaje;
                            Console.WriteLine("Su nuevo total es de: " + total);
                        }

                        else if (monto > 500 && monto < 1000)
                        {
                            desc = 15;
                            Console.WriteLine("El porcentaje de su descuento es de: " + desc);
                            porcentaje = (monto * (desc / 100));
                            Console.WriteLine("Su descuento es de : " + porcentaje);
                            total = monto - porcentaje;
                            Console.WriteLine("Su nuevo total es de: " + total);

                        }

                        else if (monto > 1001)
                        {
                            desc = 20;
                            Console.WriteLine("El porcentaje de su descuento es de: " + desc);
                            porcentaje = (monto * (desc / 100));
                            Console.WriteLine("Su descuento es de : " + porcentaje);
                            total = monto - porcentaje;
                            Console.WriteLine("Su nuevo total es de: " + total);
                        }
                        else if (monto < 500)
                        {
                            Console.WriteLine("Su monto es: "+monto);
                        }
                        
                        
                }

            }
            

        }
    }
}
