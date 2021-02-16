using System;

namespace FIGURAS_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Figuras figura_cuad = new Figuras();      // Instanciando una clase
            figura_cuad.areaCuadrado();               //acedemos al método creado
            Console.ReadKey();
  
            Figuras figura_rec = new Figuras();
            figura_rec.areaRectangulo();
            Console.ReadKey();
            */

            Figuras figura_cir = new Figuras();
            figura_cir.areaCirculo();
            Console.ReadKey();

        }
    }
}
