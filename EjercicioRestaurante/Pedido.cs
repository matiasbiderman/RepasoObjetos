using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante
{
   public class Pedido
    {
        private string _descripcion;
        private int _precio;
        private string _destinoPedido;
        private int _codigo;
        private DateTime _fecha;


        public Pedido(string descripcion,int precio, string destino, int codigo, DateTime fecha)
        {
            this._descripcion = descripcion;
            this._precio = precio;
            this._destinoPedido = destino;
            this._codigo = codigo;
            this._fecha = fecha;
        }


        public int Codigo //codigo secuencial
        {
            get
            {
                return this._codigo;
            }
        }

        public override string ToString()
        {
            return string.Format("Descripcion: {0}\nPrecio: {1}\nDestino Pedido: {2}\nCodigo: {3}\nFecha: {4}\n", this._descripcion, this._precio, this._destinoPedido, this._codigo, this._fecha);
        }


    }
}
