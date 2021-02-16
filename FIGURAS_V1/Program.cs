using System;

namespace FIGURAS_V1
{
    class Program
    {
        static void Main(string[] args)
        {


            Figuras figura_cuad = new Figuras();        

            int contador = 1;
            try
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("Desea iniciar la aplicación <S/N>: ");
                    string valor_elegido=Console.ReadLine();

                    if (valor_elegido.ToUpper() == "S")     
                    {
                        Console.WriteLine("Presiona el número de la opción que prefieras: ");
                        Console.WriteLine(" 1  Área del cuadrado");
                        Console.WriteLine(" 2  Área del rectángulo");
                        Console.WriteLine(" 3  Área del circulo");


                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                figura_cuad.areaCuadrado();
                                Console.ReadKey();
                                break;
                            case 2:
                                figura_cuad.areaRectangulo();
                                Console.ReadKey();
                                break;
                            case 3:
                                figura_cuad.areaCirculo();
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("La opción elegida no es la correcta. Presione INTRO para a iniciar la aplicación.");
                                Console.ReadKey();
                                break;

                        }
                        contador++;
                        Console.Clear();

                    }
                    else if (valor_elegido.ToUpper() == "N")
                    {
                        //Console.WriteLine("Presione cualquier para salir de la aplicación");
                        return;      
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida. Presione INTRO para volver a seleccionar");
                        Console.ReadLine();
                        contador++;
                        Console.Clear();

                    }

                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Debes ingresar caracteres numéricos. Contacte con Soporte. " + ex.Message);
                Console.ReadKey();
            }
             
        }
    }
}
