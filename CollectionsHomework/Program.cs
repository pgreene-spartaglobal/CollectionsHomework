using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

*/

namespace CollectionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lab 1 : Cubic Array 10x10x10
             * Build a three dimensional array and populate it with numbers which are products of the input numbers.
             * Make the size of the cube to be 10x10x10 and your numbers will run from 1 at (1,1,1) through 1000 at (10,10,10).
             * Numbering starts at 1 here instead of 0.
             * Tip : use a loop within a loop within a loop to accomplish this!
             * Finally output the value at (2,3,7) and check it has value 2x3x7=42
             */

            // A cubic array that is 10 in each dimension will have indexes starting at [0, 0, 0] and ending at [9, 9, 9]
            int[,,] cubicArray = new int[10, 10, 10];

            for (int x = 0; x < cubicArray.GetLength(0); x++)
            {
                for (int y = 0; y < cubicArray.GetLength(1); y++)
                {
                    for (int z = 0; z < cubicArray.GetLength(2); z++)
                    {
                        cubicArray[x, y, z] = (x + 1) * (y + 1) * (z + 1); // + 1 is added to the index to begin counting from 1 instead of 0
                        //Console.WriteLine(String.Format("cubicArray[{0}, {1}, {2}] | ({3},{4},{5}) | {6}", x, y, z, x+1,y+1,z+1, cubicArray[x, y, z]));
                    }
                }
            }

            //Console.WriteLine(String.Format("(2,3,7) : {0}", cubicArray[1,2,6]));

            /* Lab 2 : List
             * Create a one-dimensional list of integers called List01.
             * Iterate over the three dimensional array above, and for every number in the array, add it to the list.
             * Finally add up the total sum of all numbers in the list and output the result.
             */

            List<int> List01 = new List<int>();
            int listIndex = 0;
            int totalSum = 0;

            foreach (int arrayValue in cubicArray)
            {
                List01.Add(arrayValue);
                totalSum += List01[listIndex];
                //Console.WriteLine(List01[listIndex]);
                listIndex++;
            }
            
            //Console.WriteLine("Total Sum: " + totalSum);

            /* Lab 3 : Dictionary
             * Create a dictionary of 10 countries as the index, with the capital city as the data.
             * Iterate over the data and display it.
             * Return the completed dictionary to complete the test
             */

            Dictionary<string, string> countryCapital = new Dictionary<string, string>()
            {
                {"United Kingdom", "London"},
                {"United States", "Washington D.C."},
                {"France", "Paris"},
                {"Germany", "Berlin"},
                {"China", "Beijing"},
                {"Japan", "Tokyo"},
                {"Russia", "Moscow"},
                {"Australia", "Canberra"},
                {"India", "New Delhi"},
                {"Italy", "Rome"}
            };

            foreach (var pair in countryCapital)
            {
                //Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            /* Lab 4 : Queue
             * Count from 1 to 100 and add the cubes of each number to a queue.
             * Run dequeue 10 times and sum the output
             * Return this sum.
             */

            Queue<int> cubeQueue = new Queue<int>();
            int cubeSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                cubeQueue.Enqueue((int)Math.Pow(i, 3));
                Console.WriteLine(String.Format("{0}^3 = {1}", i, (int)Math.Pow(i, 3)));
            }

            for (int j = 0; j < 10; j++)
            {
                cubeSum += cubeQueue.Dequeue();
            }

            Console.WriteLine("cubeSum: " + cubeSum);

            /* Lab 5 : Stack
             * Repeat this for a stack ie count from 1 to 100, add the cube of each number to the stack, then pop 10 items off the top of the stack and sum the output of those 10 numbers.
             *  Return this sum        
             */

        }
    }
}
