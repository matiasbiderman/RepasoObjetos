using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante
{
    class Restaurante
    {
        private string _nombre;
        private double _recaudacion;
        private int _cantmesas;
        private int _empleados;
        private string _direccion;
        private string _duenio;
        private string estado;
        public Restaurante(int empleados, string nombre, int cantmesas, string direccion)
        {
            this._empleados = empleados;
            this._nombre = nombre;
            this._cantmesas = cantmesas;
            this._direccion = direccion;
            this._recaudacion = 0;
            estado = "nuevo";
            _duenio = "Sociedad Anonima";
        }
        public Restaurante(int empleados, string nombre, int cantmesas, string direccion,double recaudacion, string duenio)
        {
            this._empleados = empleados;
            this._nombre = nombre;
            this._cantmesas = cantmesas;
            this._direccion = direccion;
            if (recaudacion < 0)
            {
                estado = "quebrado";
            }
            else
            {
                estado = "buen pasar";
                this._recaudacion = recaudacion;
            }
            this._duenio = duenio;
        }

        public double Recaudacion
        {
            get
            {   return this._recaudacion;}
            set
            {
                this.Recaudacion = value;
            }
        }
        public string Duenio
        {
            get
            { return this._duenio; }
            set
            {
                this._duenio = value;
            }
        }
        public int Empleados
        {
            get
            { return this._empleados; }
            set
            {
                this._empleados = value;
            }
        }

        public string Estado
        {
            get
            { return this.estado; }
            set
            {
                this.estado = value;
            }
        }

        public void ContratarEmpleados()
        {
           this._empleados++;
        }
        public void DespedirEmpleados()
        {
            this._empleados--;
        }
        public double RenovarRecaucion(double recaudacion)
        {
            this._recaudacion = this._recaudacion + recaudacion;
            return this._recaudacion;
        }

        public void RevisarNumerosLocal(double recaudacion)
        {
            if(recaudacion < 0)
            {
                estado = "quebrado";
                SacarMesas();
                DespedirEmpleados();
            }
            else if(recaudacion ==0)
            {
                estado = "nuevo";
                ContratarEmpleados();
                SumarMesas();
            }
            else if (recaudacion > 10)
            {
                estado = "buen pasar";
                ContratarEmpleados();
               this._empleados = this._empleados *2;

                this._cantmesas = SumarMesas() *2;
            }
        }

        public int SumarMesas()
        {
            return this._cantmesas++;
        }
        public int SacarMesas()
        {
           return this._cantmesas--;
        }
        public string CambioDuenio(string duenio)
        {
            this._duenio = duenio;
            return " el nuevio duenio de  " + this._nombre + " es " + this._duenio;    
        }

        public override string ToString()
        {
            
                return string.Format("cantempleados: {0}\nNombre: {1}\nCantMesas : {2}\nDireccion: {3}\nRecaudacion {4}\nDuenio {5}\nEstado {6} \n", 
                    this._empleados, this._nombre, this._cantmesas, this._direccion, this._recaudacion, this._duenio,this.estado);
            //(int empleados, string nombre, int cantmesas, string direccion,double recaudacion, string duenio)
        }

    }
}
