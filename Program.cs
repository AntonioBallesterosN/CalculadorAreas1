class Program
{

    static void Main(string[] args)
    {
        byte exit;
        string exit1 = "";
        string[] instrucciones = { "Ingrese numero de la forma que desea calcular", "1 Cuadrado", "2 Rectangulo", "3 Triangulo", "4 Paralelogramo", "5 Rombo", "6 Trapecio", "7 Exit" };

        MensajeInicial(instrucciones);
        do
        {
            string figuraCadena = Console.ReadLine();

            if (!byte.TryParse(figuraCadena, out exit) || (exit <= 0) || (exit >= 8))
            {
                Console.WriteLine("ingrese un dato correcto");
            }
            switch (exit)
            {
                case 1:
                    exit1 = Cuadrado(exit1, instrucciones);
                    break;

                case 2:
                    exit1 = Rectangulo(exit1, instrucciones);
                    break;

                case 3:
                    exit1 = Triangulo(exit1, instrucciones);
                    break;

                case 4:
                    exit1 = Paralelogramo(exit1, instrucciones);
                    break;

                case 5:
                    exit1 = Rombo(exit1, instrucciones);
                    break;

                case 6:
                    exit1 = Trapecio(exit1, instrucciones);
                    break;
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

    static void MensajeInicial(string[] instrucciones)
    {
        foreach (var item in instrucciones)
        {
            Console.WriteLine(item);
        }
    }

    static string Cuadrado(string exit1, string[] instrucciones)
    {
        Console.WriteLine("Ha elegido cuadrado");
        Console.WriteLine("Ingrese la medida de uno de los lados: ");


        string ladoCadena;
        double ladoDouble;
        do
        {
            ladoCadena = Console.ReadLine();
            if (!double.TryParse(ladoCadena, out ladoDouble))
            {
                Console.WriteLine("ingrese una medida correcta");
            }
        }
        while (!double.TryParse(ladoCadena, out ladoDouble));

        Console.WriteLine("El area del cuadrado es: {0}", AreaCuadrado(ladoDouble));

        exit1 = ControlSalida(exit1, instrucciones);

        return exit1;
    }

    static string Rectangulo(string exit1, string[] instrucciones)
    {

        Console.WriteLine("Ha elegido Rectangulo");
        Console.WriteLine("Ingrese la medida de la base: ");

        do
        {
            string baseCadena = Console.ReadLine();
            double baseDouble = IngresoDePrimerMedida(baseCadena);

            Console.WriteLine("Ingrese la medida de la altura: ");
            string alturaCadena = Console.ReadLine();
            double alturaDouble = IngresoDeSegundaMedida(alturaCadena);

            Console.WriteLine("El area del Rectangulo es: {0}", AreaRectangulo(baseDouble, alturaDouble));

            exit1 = ControlSalida(exit1, instrucciones);
        }

        while (exit1 != "n" && exit1 != "y");
        return exit1;
    }

    static string Triangulo(string exit1, string[] instrucciones)
    {

        Console.WriteLine("Ha elegido triangulo");
        Console.WriteLine("Ingrese la medida de la base: ");

        do
        {
            string baseCadena = Console.ReadLine();
            double baseDouble = IngresoDePrimerMedida(baseCadena);

            Console.WriteLine("Ingrese la medida de la altura: ");
            string alturaCadena = Console.ReadLine();
            double alturaDouble = IngresoDeSegundaMedida(alturaCadena);

            Console.WriteLine("El area del Triangulo es: {0}", AreaTriangulo(baseDouble, alturaDouble));

            exit1 = ControlSalida(exit1, instrucciones);
        }

        while (exit1 != "n" && exit1 != "y");
        return exit1;
    }

    static string Paralelogramo(string exit1, string[] instrucciones)
    {

        Console.WriteLine("Ha elegido paralelogramo");
        Console.WriteLine("Ingrese la medida de la base: ");

        do
        {
            string baseCadena = Console.ReadLine();
            double baseDouble = IngresoDePrimerMedida(baseCadena);

            Console.WriteLine("Ingrese la medida de la altura: ");
            string alturaCadena = Console.ReadLine();
            double alturaDouble = IngresoDeSegundaMedida(alturaCadena);

            Console.WriteLine("El area del Paralelogramo es: {0}", AreaParalelogramo(baseDouble, alturaDouble));

            exit1 = ControlSalida(exit1, instrucciones);
        }

        while (exit1 != "n" && exit1 != "y");
        return exit1;
    }

    static string Rombo(string exit1, string[] instrucciones)
    {

        Console.WriteLine("Ha elegido rombo");
        Console.WriteLine("Ingrese la medida de la base: ");

        do
        {
            string baseCadena = Console.ReadLine();
            double baseDouble = IngresoDePrimerMedida(baseCadena);

            Console.WriteLine("Ingrese la medida de la altura: ");
            string alturaCadena = Console.ReadLine();
            double alturaDouble = IngresoDeSegundaMedida(alturaCadena);

            Console.WriteLine("El area del Rombo es: {0}", AreaRombo(baseDouble, alturaDouble));

            exit1 = ControlSalida(exit1, instrucciones);
        }

        while (exit1 != "n" && exit1 != "y");
        return exit1;
    }

    static string Trapecio(string exit1, string[] instrucciones)
    {

        Console.WriteLine("Ha elegido trapecio");
        Console.WriteLine("Ingrese la medida de la base: ");

        do
        {
            string baseCadena = Console.ReadLine();
            double baseDouble = IngresoDePrimerMedida(baseCadena);

            Console.WriteLine("Ingrese la medida de la altura: ");
            string alturaCadena = Console.ReadLine();
            double alturaDouble = IngresoDeSegundaMedida(alturaCadena);

            Console.WriteLine("El area del Trapecio es: {0}", AreaTrapecio(baseDouble, alturaDouble));

            exit1 = ControlSalida(exit1, instrucciones);
        }

        while (exit1 != "n" && exit1 != "y");
        return exit1;
    }

    static double IngresoDePrimerMedida(string baseCadena)
    {
        double baseDouble;

        do
        {
            if (!double.TryParse(baseCadena, out baseDouble))
            {
                Console.WriteLine("Ingrese un numero correcto");
                baseCadena = Console.ReadLine();
            }
        }
        while (!double.TryParse(baseCadena, out baseDouble));
        return baseDouble;
    }

    static double IngresoDeSegundaMedida(string alturaCadena)
    {
        double alturaDouble;

        do
        {
            if (!double.TryParse(alturaCadena, out alturaDouble))
            {
                Console.WriteLine("Ingrese un numero correcto");
                alturaCadena = Console.ReadLine();
            }
        }
        while (!double.TryParse(alturaCadena, out alturaDouble));
        return alturaDouble;
    }

    static string ControlSalida(string exit1, string[] instrucciones)
    {
        do
        {
            Console.WriteLine("Desea Calcular el Area de otra figura? (Y/N)");
            exit1 = Console.ReadLine().ToLower().Trim();

            if (exit1 != "n" && exit1 != "y")
            {
                Console.WriteLine("Ingrese un dato corretcto");
            }
        }

        while (exit1 != "y" && exit1 != "n");

        if (exit1 == "y")
        {
            MensajeInicial(instrucciones);
        }
        return exit1;
    }

}


