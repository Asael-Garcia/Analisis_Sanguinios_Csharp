using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Herencia
{
    //creacion de la clase hija
    class Estudios_QS6 : Madre//nombro la clase hija y le heredo todo lo de la Madre con los dos puntos(:)
    {
        //metodo constructor para poder usar la bandera de la clase hija en los metodos de la madre
        public Estudios_QS6(int bandera) : base(bandera)
        {
        }
    }
}
