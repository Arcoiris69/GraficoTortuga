using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_Tortuga
{
    class Tortuga
    {
        private static int _pasos = 5;
        public int pasos{ get { return _pasos; } }
        private static int _direccion = 4;
        public int direccion = _direccion;

        public Tortuga()
        {
            _pasos = 0;
            direccion = 1;
        }
    }
}
