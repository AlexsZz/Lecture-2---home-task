using System;

namespace Pyramide
{
    class Pyramide
    {
        static void Main(string[] args)
        {
            string[] row1 = { " ", " ", " ", " ", " ", " ", " ", "*" };
            string[] row2 = { " ", " ", " ", " ", " ", " ", "*", "*", "*" };
            string[] row3 = { " ", " ", " ", " ", " ", "*", "*", "*", "*", "*" };
            string[] row4 = { " ", " ", " ", " ", "*", "*", "*", "*", "*", "*", "*" };
            string[] row5 = { " ", " ", " ", "*", "*", "*", "*", "*", "*", "*", "*", "*" };
            string[] row6 = { " ", " ", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" };
            string[] row7 = { " ", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" };
            string[][] pyramide = { row1, row2, row3, row4, row5, row6, row7 };


            for (int i = 0; i < pyramide.Length; i++)
            {
                for (int j = 0; j < pyramide[i].Length; j++)
                {
                    Console.Write(pyramide[i][j].ToString() + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
