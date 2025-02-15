namespace ConsoleApp5
{
    public class Clocktower
    {
        public static void Main(string[]args)
        {
            Console.Write("enter a number:");
            int number = Convert.Toint32(Console.ReadLine());

            if (number % 2 ==0)
                Console.WriteLine("Tick");
            else 
                Console.WriteLine("Tock");
        }
    }
}

        

