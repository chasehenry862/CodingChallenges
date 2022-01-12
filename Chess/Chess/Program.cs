using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var white = new ArrayList(); //creates the arraylist for the white part of the board
            var black = new ArrayList(); //creates the arraylist for the black part of the board

            white.AddRange(new string[] { "a2", "a4", "a6", "a8", "b1", "b3", "b5", "b7", "c2", "c4", "c6", "c8", "d1", "d3", "d5", "d7",
            "e2", "e4", "e6", "e8", "f1", "f3", "f5", "f7", "g2", "g4", "g6", "g8", "h1", "h3", "h5", "h7",}); //adds white board values

            black.AddRange(new string[] { "a1", "a3", "a5", "a7", "b2", "b4", "b6", "b8", "c1", "c3", "c5", "c7", "d2", "d4", "d6", "d8",
            "e1", "e3", "e5", "e7", "f2", "f4", "f6", "f8", "g1", "g3", "g5", "g7", "h2", "h4", "h6", "h8",}); //adds black board values

            Console.WriteLine("Enter a position where the Bishop will start (ex. a2)");
            string start = Console.ReadLine();

            Console.WriteLine("Enter a position where the Bishop will end (ex. f5)");
            string end = Console.ReadLine();

            Console.WriteLine("Enter a maximum number of moves allowed (ex. 1)");
            string moves = Console.ReadLine();
            int move = Int32.Parse(moves); //converts moves to an int.

            int startingX = start.ToCharArray()[0]; //converts start string at index 0 to a unicode decimal. (IE. a = 97)
            int endingX = end.ToCharArray()[0];

           
            int startingY = start.ToCharArray()[1];
            int endingY = end.ToCharArray()[1];

            int val1 = startingX - endingX;
            int val2 = startingY - endingY;

            //Console.WriteLine(startingX); Used to print out the values to compare for testing.
            //Console.WriteLine(endingX);
            //Console.WriteLine(startingY);
            //Console.WriteLine(endingY);
            //Console.WriteLine(val1);
            //Console.WriteLine(val2);

            if (start == end) //same starting/ending point
            {
                Console.WriteLine("true");
            }
            else if (white.Contains(start) && white.Contains(end) && move >= 2)//a bishop can reach any white square in 2 moves if it starts on one.
            {
                Console.WriteLine("true");
            }
            else if (white.Contains(start) && white.Contains(end) && move == 1)//a bishop can only reach squares diagonal of it in 1 move.
            {
                if ((val1) == (val2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else if (black.Contains(start) && black.Contains(end) && move >= 2)//a bishop can reach any black square in 2 moves if it starts on one.
            {
                Console.WriteLine("true");
            }
            else if (black.Contains(start) && black.Contains(end) && move == 1)//a bishop can only reach squares diagonal of it in 1 move.
            {
                if ((val1) == (val2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();


        }

    }
}
