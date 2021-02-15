using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAS_V1
{
    class Figuras       // class Figuras:Program  => Estoy diciendo que herede todo de program por ejemplo
    {

        // PROPIEDADES      ¿Qué tiene una figura?

        public decimal area {get; set;}      // 'get' y 'set' son de tipo lectura y escritura. Sintaxis para declarar un atributo
        decimal lado;
        decimal ancho;
        decimal radio;

        // FUNCIONES

        public void areaCuadrado ()
        {
            Console.WriteLine("Ingresa el número: ");
            lado = Convert.ToDecimal(Console.ReadLine());
            area = lado * lado;

            Console.WriteLine( "El resultado del area es: " + area);
        }





    }
}
