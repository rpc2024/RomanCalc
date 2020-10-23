
//Este es el controlador principal
namespace RomanCalc
{
    class Program
    {
        //Addition function controller
        //This function manages the addition menu loop, and their options 

        public static void LaunchSubadditionMenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number = ControllersUtils.ReadIntegerInput("Introduce el número a acumular");
                Accumuled += number;
                System.Console.WriteLine("El número acumulado es " + Accumuled);
                UserInterface.PrintAdditionSubmenu();
                switch (UserInterface.ReadMenuOption(0, 2))
                {
                    case 0:
                    case 2:
                        System.Console.Clear();
                        return;
                }
            }
        }

        public static void LaunchAdditionMenu()
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number1 = ControllersUtils.ReadIntegerInput("Introduce el primer número");
                int number2 = ControllersUtils.ReadIntegerInput("Introduce el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El total de la suma es: " + result);
                UserInterface.PrintAdditionSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return;
                    case 1:
                          int surma= LaunchSubadditionMenu(result);
                            if (surma == 0)
                                return;
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
                }
            }
        }

        public static void LaunchSubtractionMenu()
        {
            while (true)
            {
                UserInterface.PrintSubtractionMenu();
                int number1 = ControllersUtils.ReadIntegerInput("Introduce el primer número");
                int number2 = ControllersUtils.ReadIntegerInput("Introduce el segundo número");
                int result = number1 - number2;
                System.Console.WriteLine("El total de la resta es: " + result);
                UserInterface.PrintSubtractionSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return;
                    case 1:
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
                }
            }
        }

        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption(0, 9);
                System.Console.Clear();

                if (option == 0)
                    break;
                else if (option == -1)
                    System.Console.WriteLine("Opción no válida");
                else if (option > 9 || option < 0)
                    System.Console.WriteLine("Opción no válida. Introduce un número entre el 0 y el 9");
                else if (option == 1)
                    LaunchAdditionMenu();
                else if (option == 2)
                    LaunchSubtractionMenu();
            }
        }

        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
