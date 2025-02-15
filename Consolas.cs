// Written by Bobbi Lovstad
// 1/30/25

using System.Collections.Generic;

namespace ConsoleApp4;
{
    public class Consolas
    {
        public static void Main (string[]args)
        {
            // set title 
            Console.Title = "Defense of Consolas";

            //ask user for row and column
            //convert from string to number for both column and row

            Console.Write ("what row?");
            int row = Convert.Toint32(Console.ReadLine());

            Console.Write ("what column?");
            int column = Convert.Toint32(Console.ReadLine());

            //Change deployment instructions to yellow

            Console.ForegroundColor = ConsoleColor.yellow;
            
            //computing rows and columns 

            Console.Writeline ($" ({row}, {column -1})");
            Console.Writeline ($" ({row-1}, {column})");
            Console.Writeline ($" ({row}, {column +1})");
            Console.Writeline ($" ({row + 1}, {column})");

            // make a beep sound 
            Console.Beep();
        }
    }
}



