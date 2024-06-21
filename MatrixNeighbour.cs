using System;

class Program
{
    static void Main()
    {
        // Input matrix
        int[,] inputMatrix = {
            { 9, 4 },
            { 6, 3 },
            { 5, 8 }
        };

        int rows = inputMatrix.GetLength(0);
        int cols = inputMatrix.GetLength(1);
        int[,] outputMatrix = new int[rows * cols + 1, rows * cols + 1];

        // Fill the first row and column of outputMatrix with input matrix values
        for (int i = 1; i <= rows * cols; i++)
        {
            outputMatrix[0, i] = inputMatrix[(i - 1) % rows, (i - 1) /rows];
            outputMatrix[i, 0] = inputMatrix[(i - 1) % rows, (i - 1) / rows];
        }

        bool IsNeighbor(int r1, int c1, int r2, int c2)
        {
            // Sadece yatay ve dikey komşulukları kontrol eder
            return (Math.Abs(r1 - r2) == 1 && c1 == c2) || (Math.Abs(c1 - c2) == 1 && r1 == r2);
        }


        // Fill the output matrix
        for (int i = 1; i <= rows * cols; i++)
        {
            int r1 = (i - 1) % rows;
            int c1 = (i - 1) / rows;

            for (int j = 1; j <= rows * cols; j++)
            {
                int r2 = (j - 1) % rows;
                int c2 = (j - 1) / rows;

                if (IsNeighbor(r1, c1, r2, c2))
                {
                    outputMatrix[i, j] = 1;
                }
                else
                {
                    outputMatrix[i, j] = 0;
                }
            }
        }

        // Print the output matrix
        for (int i = 0; i <= rows * cols; i++)
        {
            for (int j = 0; j <= rows * cols; j++)
            {
                Console.Write(outputMatrix[i, j] + " "+ " ");
            }
            Console.WriteLine();
        }
    }
}
