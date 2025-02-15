// Wirtten By Bobbi Lovstad
// 1/30/25
namespace Triangle Problem
{
    public class Triangle
    {
        public static void Main(string[]args)
        {
            // Ask user to input base size of triangle
            Console.Writeline("Enter the base size of the triangle");

            // convert user input from string to number
            string BaseText = Console.Readline();
            float Base = Convert.Tosingle(BaseText);

            // Ask user to input height of triangle
            Console.Writeline("Enter the height of the triangle");
        
            // Convert user input from string to number
            string HeightText = Console.Readline();
            float Height = Convert.Tosingle(HeightText);

            // calculate area of triangle
            float Area =(Base * Height) / 2;

            // Return area to user 
            Console.Writeline ("The Area is" + Area);
        }
    }
}




