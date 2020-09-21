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
        private int _empleados;
        private string _direccion;
        private Dueño dueño;
        private Mesa mesa;
        private string estado;
        private List<Pedido> pedidos;
        private double _recaudacion;
     
        public Restaurante(string nombre, int empleados, string direccion, string duenio)
        {

            this._nombre = nombre;
            this._empleados = empleados;
            this._direccion = direccion;
            estado = "nuevo";
            this._recaudacion = 0;
            this.dueño = new Dueño(duenio);
            this.mesa = new Mesa();
            this.pedidos = new List<Pedido>();
        }
        public Restaurante( string nombre, int empleados, string direccion,double recaudacion,string duenio)
        {
            this._nombre = nombre;
            this._empleados = empleados;
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
            this.dueño = new Dueño(duenio);
            this.mesa = new Mesa();
            this.pedidos = new List<Pedido>();
        }
        public string getNombreDuenio()
        {
            return this.dueño.Nombre;
        }
        public void CambioDuenio(string duenio)
        {
            this.dueño.Nombre = duenio;
        }
        public void RealizarPedido(string descrip, int precio, string destino)
        {
            int nroPedido = getUltimoPedido();
            this.pedidos.Add(new Pedido(descrip, precio, destino, nroPedido, DateTime.Now));
        }

        public int getUltimoPedido()
        {
            Pedido p = pedidos.LastOrDefault();

            if (p == null)
                return 1;

            return p.Codigo + 1;
        }

        public int getCantMesas()
        {
            return this.mesa.CantidadMesa;
        }
        public int getCantPedidos()
        {
            return this.pedidos.Count;
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
                estado = "quebrado, se busca nuevo duenio";
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
                this.mesa.CantidadMesa = SumarMesas() *2;
            }
        }

        public int SumarMesas()
        {
            int cantidad = 0;
            cantidad = getCantMesas();
            return cantidad++;
        }
        public int SacarMesas()
        {
            int cantidad = 0;
            cantidad = getCantMesas();
            return cantidad--;
        }
        /* public string CambioDuenio(string nombreDuenio)
         {
             this.dueño.Nombre = nombreDuenio;
             return " el nuevio duenio de  " + this._nombre + " es " + this.dueño.Nombre ;    
         }*/

        public string ListarPedido()
        {
            string lista = "";
            
            if(pedidos.Count == 0)
            {
                lista += "No Hay pedidos para este restaurante";
            }
            else
            {
                for (int i = 0; i < pedidos.Count; i++)
                {
                    lista += pedidos[i];
                }
            }
            

            return lista;
        }

        public override string ToString()
        {
            
            return string.Format("\nNombre: {0}\ncantempleados: {1}\nCantMesas : {2}\nDireccion: {3}\nEstado: {4}\nRecaudacion: {5}\nPedidos: {6}\nDuenio: {7}\n",
                this._nombre, this._empleados,  this.mesa.CantidadMesa, this._direccion,this.estado, this._recaudacion, ListarPedido(), getNombreDuenio());

            //(int empleados, string nombre, int cantmesas, string direccion,double recaudacion, string duenio)
        }

    }
}
