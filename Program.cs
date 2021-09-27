using System;

namespace UnlockPatternII
{
    class Program
    {
        static void Main(string[] args)
        {


            // PATHS int
            int[,] paths = new int[,]

            {
                { 1, 2 }, { 1, 4 }, { 1, 5 }, { 1, 6 }, { 1, 8 }, { 2, 1 }, { 2, 3 }, { 2, 4 }, { 2, 5 }, { 2, 6 }, { 2, 7 }, { 2, 9 },
                { 3, 2 }, { 3, 4 }, { 3, 5 }, { 3, 6 }, { 3, 8 },{ 4, 1 }, { 4, 2 }, { 4, 3 }, { 4, 5 }, { 4, 7 }, { 4, 8 }, { 4, 9 },
                { 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 4 }, { 5, 6 }, { 5, 7 }, { 5, 8 }, { 5, 9 },
                { 6, 1 }, { 6, 2 }, { 6, 3 }, { 6, 5 }, {6, 7 }, { 6, 8 }, { 6, 9 },
                { 7, 2 }, { 7, 4 }, { 7, 5 }, { 7, 6 }, { 7, 8 },{ 8, 1 }, { 8, 3 }, { 8, 4 }, { 8, 5 }, { 8, 6 }, { 8, 7 }, { 8, 9 },
                { 9, 2 }, { 9, 4 }, { 9, 5 }, { 9, 6 }, { 9, 8 },


            };

            int[,] board = { { 1,2,3,
                               4,5,6,
                               7,8,9} };

            {

                // first read input
                string input = Console.ReadLine();

                // hold data
                char[] d = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    d[i] = input[i];
                }
            }
        }
    }
}
/* sudo code + ideas
 
                where CHAR d [“L”,” R”,” R”,” R”,” S”,” R”,” L”]
                For length of d # of ways to go left
                loop # of ways to go rightloop   
and

            
            Determining if going right(R) or left(L)
            if dir "L"
            move(x1,x2,y1,y2,dir)
            if (y2<y1 && x1 == x2)
            x3=x2-1
            y3 = y2
            return
            if(x2<x1 && y1==y2)
            y3=y2+1
            x3=x2
            return
            if(x2>x1 && y1==y2
            y3 = y2+1
            x3 = x1
            return
            if(x2>y1 && x2==x1
            x3 = x2+1
            y3 = y2

   - must make characters refer to pivot points
   - then clear array and count?
   - where all steps are hit -> success or if the points already been hit -> fail
   - must utilize back tracking functions
   - n queen problem used as example
    



