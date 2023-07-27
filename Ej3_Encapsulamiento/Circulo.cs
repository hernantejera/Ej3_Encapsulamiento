using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_Encapsulamiento
{
    //Define una clase llamada "Círculo" con una propiedad privada "radio"
    //y métodos públicos para obtener y establecer el radio.
    //Asegúrate de validar que el radio no sea negativo en el método de establecimiento.

    public class Circulo
    {
        private double Radio { get; set; }

        public double EstablecerRadio(double radio)
        {
            while (radio > 0) ;
            return Radio = radio;
        }


        internal double ObtenerRadio()
        {
            return Radio;
        }
    }
}
