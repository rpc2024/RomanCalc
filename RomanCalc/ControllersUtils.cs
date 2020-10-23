
namespace RomanCalc
{
    class ControllersUtils
    {
        public static int ReadIntegerInput(string Message)
        {
            while (true)
            {
                System.Console.WriteLine(Message);
                string number = System.Console.ReadLine();
                try
                {
                    return System.Convert.ToInt32(number);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("La entrada es incorrecta");
                }

            }
        }
    }
}
