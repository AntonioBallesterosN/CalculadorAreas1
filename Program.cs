class Program
{

    static void Main(string[] args)
    {
        byte exit;
        string exit1;
        string[] instrucciones = { "Ingrese numero de la forma que desea calcular", "1 Cuadrado", "2 Rectangulo", "3 Triangulo", "4 Paralelogramo", "5 Rombo", "6 Trapecio", "7 Exit" };

        foreach (var item in instrucciones)
        {
            Console.WriteLine(item);
        }
        do
        {
            exit1 = "";
            string figuraCadena = Console.ReadLine();

            if (byte.TryParse(figuraCadena, out exit) && (exit > 0) && (exit < 8))
            {
                byte figuraByte = exit;
                switch (figuraByte)
                {
                    case 1:

                        Console.WriteLine("Ha elegido cuadrado");
                        Console.WriteLine("Ingrese la medida de uno de los lados: ");

                        do
                        {
                            string ladoCadena = Console.ReadLine();

                            if (double.TryParse(ladoCadena, out double ladoDouble))
                            {
                                Console.WriteLine("El area del cuadrado es: {0}", AreaCuadrado(ladoDouble));

                                do
                                {
                                    Console.WriteLine("Desea Calcular el Area de otra figura? (Y/N)");
                                    exit1 = Console.ReadLine().ToLower().Trim();

                                    if (exit1 != "n" && exit1 != "y")
                                    {
                                        Console.WriteLine("Ingrese un dato corretcto");
                                    }
                                }

                                while (exit1 != "n" && exit1 != "y");
                                {
                                    foreach (var item in instrucciones)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("ingrese una medida correcta");
                            }
                        }
                        while (exit1 != "n" && exit1 != "y");
                        break;

                    case 2:

                        Console.WriteLine("Ha elegido rectangulo");
                        Console.WriteLine("Ingrese la medida de la base: ");

                        do
                        {
                            string basecadena = Console.ReadLine();

                            if (double.TryParse(basecadena, out double baseDouble))
                            {
                                Console.WriteLine("Ingrese la medida de la altura: ");
                                do
                                {
                                    string altura = Console.ReadLine();

                                    if (double.TryParse(altura, out double alturaDouble))
                                    {
                                        Console.WriteLine("El area del rectangulo es: {0}", AreaRectangulo(baseDouble, alturaDouble));

                                        do
                                        {
                                            Console.WriteLine("Desea Calcular el Area de otra figura? (Y/N)");
                                            exit1 = Console.ReadLine().ToLower().Trim();

                                            if (exit1 != "n" && exit1 != "y")
                                            {
                                                Console.WriteLine("Ingrese una medida corretcta");
                                            }
                                        }

                                        while (exit1 != "n" && exit1 != "y");
                                        {
                                            foreach (var item in instrucciones)
                                            {
                                                Console.WriteLine(item);
                                            }
                                        }
                                    }
                                    
                                    else
                                    {
                                        Console.WriteLine("Ingrese un numero correcto");
                                    }
                                }
                                while (exit1 != "n" && exit1 != "y");
                            }

                            else
                            {
                                Console.WriteLine("Ingrese un dato correcto");
                            }
                        }
                        while (exit1 != "n" && exit1 != "y");
                        break;

                }
            }
            else
            {
                Console.WriteLine("ingrese un dato correcto");
            }
        }
        while (exit != 7 && exit1 != "n");
    }

    static double AreaCuadrado(double lado)
    {
        double area = lado * lado;
        return area;
    }

    static double AreaRectangulo(double basee, double altura)
    {
        double area = basee * altura;
        return area;
    }

    static double AreaTriangulo(double basee, double altura)
    {
        double area = (basee * altura) / 2;
        return area;
    }

    static double AreaParalelogramo(double basee, double altura)
    {
        double area = basee * altura;
        return area;
    }

    static double AreaRombo(double diagonalMenor, double diagonalMayor)
    {
        double area = (diagonalMenor * diagonalMayor) / 2;
        return area;
    }

    static double AreaTrapecio(double baseMenor, double baseMayor)
    {
        double area = (baseMenor + baseMayor) / 2;
        return area;
    }
}


