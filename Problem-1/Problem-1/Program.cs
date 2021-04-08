using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{    
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] twoDArray = new int[2, 3]
                {
                    {  1,  2,  3 },
                    {  4,  5,  6 }
                };

            
            //Console.Write("Enter row size for 2D Array : ");
            //int rowSize= Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter column size for 2D Array : ");
            //int rcolumnSize = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter 2D Array Elements : ");
            //for (int i = 0; i < rowSize; i++)
            //{
            //    for (int j = 0; j < rcolumnSize; j++)
            //    {
            //        twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            int index = 0;

            //Getting rows from 2D Array 
            int rows = twoDArray.GetLength(0);

            //Getting columns from 2D Array 
            int columns = twoDArray.GetLength(1);

            
            int[] oneDArray = new int[rows * columns];

            // Assigning element from 2D array to 1D array. 
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    oneDArray[index] = twoDArray[y, x];
                    index++;
                }
            }

            Console.WriteLine("1D Array elements are: ");
            foreach (int item in oneDArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
