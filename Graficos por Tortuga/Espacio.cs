using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_Tortuga
{
    class Espacio
    {
        Tortuga tort = new Tortuga();
        private int[,] _matriz;
        private int _accross = 10, _down = 10;
        private string output;

        public Espacio()
        {
             _matriz = new int[20, 20];
            _matriz[_down, _accross] = 1;
           
        }
        public void llenar()
        {
            for (int i = 0; i < _matriz.Length; i++)
            {
                for (int j = 0; j < _matriz.Length; j++)
                {
                    _matriz[i, j] = 0;
                }
            }
        }
        public void Avanzar(int pasos, int plumaEstado)
        {   
                if (tort.direccion == 2)
                {
                    for (int i = _down; i < _down + pasos; i++)
                    {
                        _matriz[i, _accross] = plumaEstado;
                    }
                    _down+= pasos;
                }
                else if (tort.direccion == 4)
                {
                    for (int i = _down; i >= _down - pasos; i--)
                    {
                        _matriz[i, _accross] = plumaEstado;
                    }
                    _down-= pasos;
                }
                else if (tort.direccion == 1)
                {
                    for (int j = _accross; j < _accross + pasos; j++)
                    {
                        _matriz[_down, j] = plumaEstado;
                    }
                    _accross+= pasos;
                }
                else if (tort.direccion == 3)
                {
                    for (int j = _accross; j > _accross - pasos; j--)
                    {
                        _matriz[_down, j] = plumaEstado;
                    }
                    _accross -= pasos;
                }
        }
        public string Mostar()
        {
            output = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    output += _matriz[i, j] + "  ";
                }
                output += "\r\n";
            }
            return output;
        }

        // 1 = Derecha
        // 2 = Arriba
        // 3   Izquierda
        // 4 = Abajo

        public void GirarDerecha()
        {
            if (tort.direccion == 4)
            {
                tort.direccion = 1;
            }
            else
            {
            tort.direccion++;
            }
        }

        public void GirarIzquierda()
        {
            if (tort.direccion == 1)
            {
                tort.direccion = 4;
            }
            else
            {
                tort.direccion--;
            }
        }
    }
}
