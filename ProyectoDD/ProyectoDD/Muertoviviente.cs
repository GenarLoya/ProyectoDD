using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDD
{
    class Muertoviviente:monstruo
    {
        public int convocacion = 0;

        public Muertoviviente(int poder)
        {
            convocacion = poder;
        }
    }
}
