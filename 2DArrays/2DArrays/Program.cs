using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // leeon (C++ boy) asked me if
            // we can use 2D for project 2...
            // meh, why not.

            // to create 2D arrays
            // [ROW,COL]
            // you cannot mix up different types in 2D arrays
            int[,] twoDimensionalArray = new int[2,5];

            // how to use 2D is the same as how you used
            // 1D
            twoDimensionalArray[0, 0] = 10;
            twoDimensionalArray[0, 1] = 12;
            twoDimensionalArray[1, 0] = 15;
            twoDimensionalArray[1, 1] = 20;

            // this is a little bit different when
            // you want to loop through 2D
            // you will require to use nested loops

            // if you want to know the LENGTH of the ROW or COLUMN...
            // use GetLength()
            // GetLength(0) -> focuses on the length of the row -> [row,]
            // GetLength(1) -> focuses on the length of the column -> [,column]
            Console.WriteLine($"The length of row is {twoDimensionalArray.GetLength(0)}");
            Console.WriteLine($"The length of column is {twoDimensionalArray.GetLength(1)}");

            // REMEMBER the Length Property is different from the GetLength method
            Console.WriteLine($"The size of the 2D array is {twoDimensionalArray.Length}");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Row Index: {i}\nColumn Index: {j}\nValue: {twoDimensionalArray[i,j]}");
                }
            }



            // different from 1D array
            int[] oneDimensionalArray = new int[2];
            oneDimensionalArray[0] = 10;
            oneDimensionalArray[1] = 12;
        }
    }
}
