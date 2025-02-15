//Written by Bobbi Lovstad
// 1/30/25
namespace ConsoleApp2;
{
    public class SisterAndDuckbear
    {
        public static void Main(string[]args)
        {
            // ask how many chocolate eggs were gathered 
            Console.Writeline("how many chocolate eggs were gathered?")

            //convert string to int
            //assign input to varaible 
            string eggCountWord = Console.ReadLine();
            int eggCountNum = convert.Toint32(eggCountWord);

            // divide by 4 sisters and give the remainder to duckbear %=remainder
            int Sisters = eggCount / 4;
            int Duckbear = eggCount % 4;

            //Display who gets what 
            Console.Writeline ("Sisters get"+ Sisters)
            Console.Writeline ("Duckbear gets"+ Duckbear)
        }
    }
}
