using System;

namespace trad
{
    internal class Program
    {
        public const double pi = 3.14;
        public static double resultado;
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("******************");
                Console.WriteLine(" PROGRAMA PARA GEOMETRIA ");
                Console.WriteLine("******************");
                Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir");
                var opcion = Console.ReadLine();
                if (opcion == "s")
                {
                    break;
                }
                if( opcion == "c" ){
                    Console.WriteLine("Ingrese Radio");
                    var vradio = Int32.Parse(Console.ReadLine());
                    resultado = pi * (vradio * vradio);

                }
                else if( opcion == "r" ){
                    Console.WriteLine("Ingrese la Base");
                    var vbase = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Altura");
                    var valtura = Int32.Parse(Console.ReadLine());
                    resultado = vbase * valtura;
                }
                else{
                    Console.WriteLine("Ingrese la Base");
                    var vbase = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Altura");
                    var valtura = Int32.Parse(Console.ReadLine());
                    resultado = (vbase * valtura) / 2;
                }

                Console.WriteLine("El resultado es : "+ resultado);
            }

            Console.WriteLine("Gracias por usar el programa de cálculo geométrico");
        }
    }
}