using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurante> restaurantes = new List<Restaurante>();

            Restaurante r1 = new Restaurante(5, "La farola", 10, "Villa Crespo");
            Restaurante r2 = new Restaurante(7, "La Continental", 12, "Palermo", 1000, "Matias");

            restaurantes.Add(r1);
            restaurantes.Add(r2);

            double recaudar; 
            foreach (Restaurante resto in restaurantes)
            {
                Console.WriteLine(resto.ToString());
            }

           //r1.Recaudacion = 5000;
            recaudar = restaurantes[0].RenovarRecaucion(50000);
            restaurantes[0].RevisarNumerosLocal(recaudar);
            restaurantes[1].CambioDuenio("Empresa Offshore");



            Console.WriteLine("Verificar Cambios");
            foreach (Restaurante resto in restaurantes)
            {
                Console.WriteLine(resto.ToString());
            }
            Console.ReadKey();
        }
    }
}
