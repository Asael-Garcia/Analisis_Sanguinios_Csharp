using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Herencia
{
    //creo la calse hija
    class Estudios_QS3 : Madre//y le paso todo lo de la clase madre con los dos puntos(:)
    {
        //metodo constructor para poder usar la bandera de la clase hija en los metodos de la madre
        public Estudios_QS3(int bandera) : base(bandera)
        {
        }
    }
}
