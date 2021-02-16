using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAS_V1
{
    class Figuras       
    {

        // PROPIEDADES      ¿Qué tiene una figura?

        double area=0;
        double altura=0;
        double basee=0;
        double radio=0;


        // FUNCIONES

        public void areaCuadrado ()
        {
            Console.WriteLine("Ingresa la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            area = altura * altura;

            Console.WriteLine( "El resultado del area es: " + area);
        }

        public void areaRectangulo()       
        {
            Console.WriteLine("Ingresa la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingresa la base: ");
            basee = Convert.ToDouble(Console.ReadLine());
            area = basee * altura;

            Console.WriteLine("El resultado del area es: " + area);
        }

        public void areaCirculo()
        {
            double pi = Math.PI;

            Console.WriteLine("Ingresa el radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = pi * Math.Pow(radio, 2);

            Console.WriteLine("El resultado es: " + area );
        }




    }
}
