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
            Restaurante r1 = new Restaurante("La farola",  10, "Villa Crespo", "matiasss");
            Restaurante r2 = new Restaurante("La Continental", 12, "Palermo", 1000, "pablooo");
         //   Restaurante r3 = new Restaurante(new Dueño("sdsdsdsdsd"));

            restaurantes.Add(r1);
            restaurantes.Add(r2);
         //   restaurantes.Add(r3);

            double recaudar; 
            
           //r1.Recaudacion = 5000;
            recaudar = restaurantes[0].RenovarRecaucion(50000);
            restaurantes[0].RevisarNumerosLocal(recaudar);
            restaurantes[0].CambioDuenio("Empresa Offshore");
           // restaurantes[0].RealizarPedido("Milanesa con pure", "camargo 732");
            restaurantes[1].RealizarPedido("choripan", 500, "gurrucha 1616");
            restaurantes[1].RealizarPedido("asado", 700, "soler 2222");


            Console.WriteLine("RESTAURANTES DE ARGENTINA");
            foreach (Restaurante resto in restaurantes)
            {
                Console.WriteLine(resto.ToString());
            }
            Console.ReadKey();
        }
    }
}
