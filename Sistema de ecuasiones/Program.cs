using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istema_de_ecuasiones
{
    class Program
    {
        static void Main(string[] args)
        {
            int co = 1, sig = 0;
            int h;
            double[,] matriz;
            double fila_2;
            int n = 0, v = 0;
            Console.WriteLine("INGRESE N INCÓGNITAS: ");
            n = int.Parse(Console.ReadLine());
            int i = n + 1;
            //i filas  y n columnas
            matriz = new double[i, n];
            Console.WriteLine("INGRESO DE VALORES: ");
            for (h = 0; h < n; h++)
            {
                Console.WriteLine("ECUACIÓN {0}", h);
                for (v = 0; v < n; v++)
                {

                    Console.Write("x{0}: ", v); matriz[v, h] = int.Parse(Console.ReadLine());
                }
                //Para ingresar el término indepente
                Console.Write("T.I. "); matriz[n, h] = int.Parse(Console.ReadLine());
            }
            for (h = 0; h < n; h++)
            {
                for (v = 0; v < n + 1; v++)
                {
                    Console.Write("{0,5}", matriz[v, h]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.WriteLine("");
            int u = 0;
            double primera_fila;
            for (int y = 0; y < n; y++)
            {

                primera_fila = matriz[y, y];
                for (u = 0; u < n + 1; u++)
                {

                    matriz[u, y] = matriz[u, y] / primera_fila;
                }
                for (sig = 0; sig < n; sig++)
                {
                    if (sig != y)
                    {
                        fila_2 = matriz[sig, y];
                        for (co = 0; co < i; co++)
                        {
                            matriz[co, sig] = matriz[co, sig] - (fila_2 * matriz[co, y]);
                        }
                    }
                }



                for (h = 0; h < n; h++)
                {
                    for (v = 0; v < n + 1; v++)
                    {
                        Console.Write("{0,5}", matriz[v, h]);
                    }
                    Console.WriteLine("");
                }
                Console.ReadKey();
                Console.WriteLine("");
            } Console.ReadKey();
        }
    }
}
