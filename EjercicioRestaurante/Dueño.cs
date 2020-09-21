using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante
{
    public class Dueño
    {
        private string _nombre;
        
        public Dueño(string nombre)
        {
            this._nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
    }
}
