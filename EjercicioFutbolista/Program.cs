using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFutbolista
{
    class Program
    {
        static void Main(string[] args)
        {
            string jugador;
            string equipo;

            List<Futbolista> futbolistas = new List<Futbolista>();


            Futbolista maradona = new Futbolista(10, "Diego Maradona", 60, "volante", true);
            Futbolista messi = new Futbolista(10, "Lionel Messi", 32, "delantero", false);
            Futbolista ronaldo = new Futbolista(10, "Cristiano Ronaldo", 32, "delantero", true, 70, 7);

            maradona.EquipoActual = "Retirados FC";
            messi.EquipoActual = "Barcelona";

            

            futbolistas.Add(maradona);
            futbolistas.Add(messi);
            futbolistas.Add(ronaldo);


            foreach (Futbolista futbolista in futbolistas)
            {
                Console.WriteLine(futbolista.ToString());
            }


            Console.WriteLine(maradona.CambioPosicion("enganche"));


           Console.WriteLine("Inserte Jugador para transferir" + "\n");
            jugador = Console.ReadLine().ToUpper();
                if (jugador == "")
                {
                    Console.WriteLine("Inserte Jugador valido");
                }
            

            Console.WriteLine("Inserte Equipo de destino");
                equipo = Console.ReadLine().ToUpper();

                if (equipo == "")
                {
                    Console.WriteLine("Inserte equipo valido");
                }
                else
                {
                    Console.WriteLine(messi.TraspasoEquipo(equipo, true) + "\n");
                }
                
            Console.WriteLine(ronaldo.PonerComoTitular(ronaldo.Nombre));
            Console.WriteLine(messi.RetirarJugador(32));
           
        }
    }
}
