// written by Bobbi Lovstad
// 1/30/25
using System.Collections.Generic;

namespace KingsHW;
{
     public class Kings
     {
        public static void Main(string[] args)
        {
            // write how many provinces, duchys, and estates 
            // convert from string to int

            Console.WriteLine("How many estates do you have?");
            int estateCount = Convert.Toint32(Console.ReadLine());

            Console.WriteLine("How many Duchies do you have?");
            int duchyCount = Convert.Toint32(Console.ReadLine());

            Console.WriteLine("How many Provinces do you have?");
            int provinceCount = Convert.Toint32(Console.ReadLine());

            // add the total and multiply be respective integer
            int Total =estateCount * 1 + duchyCount * 3 + provinceCount * 6;

            // displays total for the user 
            Console.WriteLine ("Your total points:" + Total)
        }
     }
}

            
