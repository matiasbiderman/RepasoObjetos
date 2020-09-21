using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante
{
    public class Mesa
    {
        private int cantmesas;

        public Mesa()
        {
            cantmesas = 5;
        }

        public int CantidadMesa
        {
            get
            {
                return cantmesas;
            }
            set
            {
                cantmesas = value;
            }
        }
    }
}
