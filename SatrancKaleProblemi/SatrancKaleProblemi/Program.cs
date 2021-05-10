using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancKaleProblemi
{

    class Program
    {
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition( x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {

            Random random = new Random();
            int GenerateColumn = random.Next(0, 9);
            int GenerateRow = random.Next(0, 9);
            int x = 0;
            int column = 0;
            for(int r = 1 ; r <= 8 ; r++)
            {
                Console.SetCursorPosition(0, r);
                Console.Write("[" + " " + "]");
                 
                for(int c = 1; c <= 8; c++)
                {

                    WriteAt(" [ ] ",c , r);
                    x = x + 3;
                }
            }



            while (true)
            {
                int rockCounter = 0;
                int counter = 1;



                
                rockCounter++;

            }


        }
    }
}
