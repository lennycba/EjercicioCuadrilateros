using EjercicioCuadrilateros.Modelo;

int respuesta = 0;
string repetir = "s";


while (repetir != "n")
{
    while (respuesta != 4)
    {

        Console.WriteLine("Bienvenido al programa Cuadrilateros donde todos estamos obsesionados con los CUADRILATEROS");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("A continuación se le pediran las coordenadas de los cuatro vértices");
        Console.WriteLine("Comenzando por el vértice superior izquierdo y continuando en sentido HORARIO");
        Console.WriteLine("--------------------------------------------------------------------------------------------");

        Console.WriteLine("ingrese la coordenada X del punto A");
        double XA = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada Y del punto A");
        double YA = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada X del punto B");
        double XB = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada Y del punto B");
        double YB = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada X del punto C");
        double XC = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada Y del punto C");
        double YC = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada X del punto D");
        double XD = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese la coordenada Y del punto D");
        double YD = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Excelente!!! ahora ingrese por favor el TIPO de cuadrilatero");

        Console.WriteLine("1. Trapecio");
        Console.WriteLine("2. Rectangulo");
        Console.WriteLine("3. Cuadrado");
        Console.WriteLine("4. salir");
        
        int eleccion = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (eleccion)
        {
            case 1:
                {
                    Console.WriteLine("usted eligió un trapecio");

                    var trapecio = new Trapecio(XA, YA, XB, YB, XC, YC, XD, YD);

                    double areaTrapecio = trapecio.Area();

                    Console.WriteLine("El area del trapecio es: " + areaTrapecio);

                    break;
                }
            case 2:
                {
                    Console.WriteLine("Usted eligió Rectangulo");

                    var rectangulo = new Rectangulo(XA, YA, XB, YB, XC, YC, XD, YD);

                    double areaRectangulo = rectangulo.Area();

                    Console.WriteLine("El area del rectangulo es: " + areaRectangulo);

                    break;
                }
            case 3:
                {
                    Console.WriteLine("Usted eligió Cuadrado");

                    var cuadrado = new Cuadrado(XA, YA, XB, YB, XC, YC, XD, YD);

                    double areaCuadrado = cuadrado.Area();

                    Console.WriteLine("El area del cuadrado es: " + areaCuadrado);

                    break;
                }
            case 4:
                {
                    Console.WriteLine("Muchas gracias por utilizar el programa Cuadriláteros");
                    Console.WriteLine("Ahora el programa se cerrará");
                    break;
                }
            default:
                {
                    Console.WriteLine("Usted no eligió ninguna opción válida");
                    break;
                }


        }

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Esta tan obsesionado que desea repetir el programa?");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("n para no");
        Console.WriteLine("cualquier tecla para si");
        
        repetir = Console.ReadLine();
        Console.Clear();
    }
}


