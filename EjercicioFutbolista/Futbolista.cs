using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFutbolista
{
    class Futbolista
    {

        private int Camiseta;
        private string NombreJugador;
        private int Edad;
        private string PosicionJugador;
        private string EquipoJugador;
        private int Goles;
        private bool AcuerdoPorTraspaso;
        private bool Titular;
        private string retirado;
        private int Trofeos;
        private const int maximoedad = 33;
        public string EquipoActual
        {
            get
            {return this.EquipoJugador;}
            set
            {
                this.EquipoJugador = value;
            }
        }
        public string Posicion
        {
            get
            {return PosicionJugador;}
            set
            {
                if (value == "aguatero")
                    throw new Exception();
                else
                    PosicionJugador = value;
            }
        }

        public string Nombre
        {
            get
            { return this.NombreJugador; }
            
        }
        public Futbolista(int camiseta, string nombre, int edad, string posicion, bool titularidad)
        {
            this.Camiseta = camiseta;
            this.NombreJugador = nombre;
            this.Edad = edad;
            if (posicion == "aguatero")
                throw new Exception();
            else
                this.PosicionJugador = posicion;

            this.Titular = titularidad;
        }

        public Futbolista(int camiseta, string nombre, int edad, string posicion, bool titularidad, int goles, int trofeosGanados)
        {
            this.Camiseta = camiseta;
            this.NombreJugador = nombre;
            this.Edad = edad;
            if (posicion == "aguatero")
                throw new Exception();
            else
                this.PosicionJugador = posicion;

            this.Titular = titularidad;
            this.Goles = goles;
            this.Trofeos = trofeosGanados;

        }

        public string RetirarJugador(int edad)
        {
            if (edad >= maximoedad)
            {
                retirado = "El jugador se ha retirado";
            }
            else
            {
                retirado = " El jugador continua con su carrera, le quedan " + (maximoedad - edad) + " anios";
            }
            return retirado;
        }
        public override string ToString()
        {
            string titular;
            if (this.Titular)
                titular = "Titular";
            else
                titular = "Suplente";

            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", this.Camiseta, this.NombreJugador, this.Edad, this.PosicionJugador, titular, RetirarJugador(this.Edad));
        }

        public Futbolista()
        {
            this.AcuerdoPorTraspaso = false;
            this.Goles = 0;
        }

        public int MeterGol()
        {
            bool metioGol = false;

            if (metioGol)
            {
                this.Goles++;
            }

            return this.Goles;
        }

        public string CambioPosicion(string posicion) //cambia de posicion en la cancha
        {           
           this.PosicionJugador = posicion;
          
           return "La nueva posicion de " + this.Nombre + " es " + this.PosicionJugador;
        }
        public string TraspasoEquipo(string equipo, bool confirmacion) //se mueve de equipo
        {
            string mensaje = "";
            this.AcuerdoPorTraspaso = confirmacion;
            if (this.AcuerdoPorTraspaso)
            {
                mensaje = "El jugador " + this.Nombre + " llego a un acuerdo salarial con " + equipo + " y deja el FC " + this.EquipoActual;
            }
            else
            {
                mensaje = "El jugador " + this.Nombre + " no pudo llegar a un acuerdo salarial con el FC " + equipo;
            }
            return mensaje;
        }

        public string PonerComoTitular(string nombre) // pasa de titular a suplente
        {
            int contTitulares = 0;
            string retorno;
            if(contTitulares <= 11)
            {
                this.Titular = true;
                contTitulares++;
                retorno = nombre + " es ahora Titular"; 

            }
            else
            {
                retorno = "No hay lugar para mas titulares en el equipo";   
            }

            return retorno;
        }
    }
}
