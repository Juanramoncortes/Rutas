using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    class Base
    {
        string _nombre,_hrInicio,_hrFin;
        public string nombre { get { return _nombre; }}
        public string hrInicio { get { return _hrInicio; } }
        public string hrFin { get { return _hrFin; } }
        private Base _siguiente;
        private Base _anterior;
        public Base siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Base anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public Base(string nombre, string hrInicio,string hrFin)
        {
            this._nombre = nombre;
            this._hrInicio = hrInicio;
            this._hrFin = hrFin;
        }
        public Base()
        {
            this._nombre = "";
            this._hrInicio = "";
            this._hrFin = "";
        }

        public override string ToString()
        {
            return _nombre + "\t\t" + _hrInicio + "\t\t" + _hrFin ;
        }
    }
}
