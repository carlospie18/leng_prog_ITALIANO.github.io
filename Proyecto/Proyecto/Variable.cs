using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Variable
    {
        private string Nombre;
        private string Valor;

        public Variable(string nombre, string valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }

        public string nombre
        {
            get { return Nombre; }
            set { nombre = value; }
        }

        public string valor
        {
            get { return Valor; }
            set { valor = value; }
        }
    }
}
