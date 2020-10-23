
namespace RomanCalc
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("     CALCULADORA ROMÁN");
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("1) Sumar una serie de números.");
            System.Console.WriteLine("2) Restar una serie de números.");
            System.Console.WriteLine("3) Multiplicar una serie de números.");
            System.Console.WriteLine("4) Dividir una serie de números.");
            System.Console.WriteLine("5) Resolver ecuación de primer grado.");
            System.Console.WriteLine("6) Resolver ecuación de segundo grado.");
            System.Console.WriteLine("7) Resolver raíz cuadrada.");
            System.Console.WriteLine("8) Mostrar serie de Fibonacci.");
            System.Console.WriteLine("9) Realizar sumatorio.");
            System.Console.WriteLine("0) Salir de la aplicación.");
                

        }

        public static void PrintAdditionMenu()
        {
            System.Console.WriteLine("       Menú de sumas");
            System.Console.WriteLine("----------------------");
        }

        public static void PrintAdditionSubmenu()
        {
            System.Console.WriteLine("0) Volver al menú principal");
            System.Console.WriteLine("1) Seguir sumando");
            System.Console.WriteLine("2) Reiniciar suma");
        }

        public static void PrintSubtractionMenu()
        {
            System.Console.WriteLine("        Menú de restas");
            System.Console.WriteLine("-----------------------");
        }

        public static void PrintSubtractionSubmenu()
        {
            System.Console.WriteLine("0) Volver al menú principal");
            System.Console.WriteLine("1) Seguir restando");
            System.Console.WriteLine("2) Reiniciar resta");
        }

        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }

        public static int ReadMenuOption(int MinOptionValue, int MaxOptionValue)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= MinOptionValue && option <= MaxOptionValue)
                    return option;
                else
                    System.Console.WriteLine("Opción no válida, introduce una opción entre "
                    + MinOptionValue + " y " + MaxOptionValue);
            }
        }
    }
}
