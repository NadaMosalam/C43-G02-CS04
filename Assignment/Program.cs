using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Assignment
{
    class Program
    {
        static void Main()
        {

            #region Question 1
            //1-Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the identity matrix (n): ");
            //if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0)
            //{
            //    Console.WriteLine("identity table of size:");
            //    for (int r = 0; r < Number; r++)
            //    {
            //        for (int c = 0; c < Number; c++)
            //        {
            //            if (r == c)
            //                Console.Write("1");
            //            else
            //                Console.Write("0");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Question 2 
            //2-Write a program in C# Sharp to find the sum of all elements of the array

            //int[] array = { 98, 95, 92, 97, 93, 95 };
            //int sum = 0;
            //foreach (int num in array)
            //{
            //    sum += num;
            //}
            //Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion

            #region Question 3
            //3-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 10, 3, 6, 7, 8 };
            //int[] arr02 = { 1, 4, 5, 9, 2 };
            //int[] mergedArr03= new int[arr01.Length + arr02.Length];
            //arr01.CopyTo(mergedArr03, 0); 
            //arr02.CopyTo(mergedArr03, arr01.Length);
            //Array.Sort(mergedArr03);
            //Console.WriteLine("array :");
            //foreach (int num in mergedArr03)
            //{
            //    Console.Write(num+" - ");
            //}
            #endregion

            #region Question 4
            //4-Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] array = { 5, 2, 5, 1, 7, 3, 2, 8, 7, 4, 5, 9, 1, 6, 9, 3 };
            //Console.WriteLine("Frequency of each element:");
            //for (int r = 0; r < array.Length; r++)
            //{
            //    int count = 1;
            //    if (array[r] == -1)
            //        continue;
            //    for (int c = r + 1; c < array.Length; c++)
            //    {
            //        if (array[r] == array[c])
            //        {
            //            count++;
            //            array[c] = -1;
            //        }
            //    }
            //    Console.WriteLine($"Element {array[r]} appears {count} time(s)");
            //}
            #endregion

            #region Question 5
            //5- Write a program in C# Sharp to find maximum and minimum element in an array.

            //int[] array = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = array[0];
            //int min = array[0];
            //foreach (int num in array)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"The maximum of element is: {max}");
            //Console.WriteLine($"The minimum of element is: {min}");
            #endregion

            #region Question 6
            //6- Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 25, 35, 45, 55, 65, 75 };
            //Array.Sort(arr);
            //int secondLargest = arr[arr.Length - 2];
            //Console.WriteLine("The second largest element in an array is: " + secondLargest);
            #endregion

            #region Question 7
            //7-Consider an Array of Integer values with size N, having values as
            //in this Example
            //7      0    0   0   0   5   6   7   5   0   7   5   3
            //write a program find the longest distance between Two equal cells.In this example
            //.The distance is measured by the number Of cells-for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.
            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.
            
            Console.Write("Entre Array Size =");
            int arraySize =int.Parse(Console.ReadLine());
            int[] nums=new int[arraySize];
            for(int i = 0; i < nums.Length; i++)
            {
                int index = i + 1;
                Console.Write("Num "+ index + "=");
                nums[i] = int.Parse(Console.ReadLine());
            }
            int longDistance = 0;
            int distance = 0;
            for (int i = 0; i < nums.Length-1; i++) {
             for(int j=i+1;j< nums.Length; j++)
                {
                    distance = 0;
                    if (nums[i] == nums[j])
                    {
                        distance = (j - i) - 1;
                        if (distance > longDistance)
                        {
                            longDistance= distance;
                        }
                    }
                }
            }
            Console.WriteLine("Long distance equal= " + longDistance);
            #endregion

            #region Question 8
            //8-Given a list of space separated words, reverse the order of the words.
            //Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word Output: Word
            //Note : 
            //Check the Split Function(Member in String Class) Output will be a Single Console. WriteLine Statement
            #endregion

            #region Question 9
            //9-Write a program to create two multidimensional arrays of same size.
            //Accept value from user and store them in first array.
            //Now copy all the elements of first array on second array and print second array

            //int[,] arr1 = new int[2, 3];
            //int[,] arr2 = new int[2, 3];
            //Console.WriteLine("Enter elements for the first array:");
            //for (int r = 0; r < 2; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        Console.Write($"Enter element the position ({r},{c}): ");
            //        arr1[r, c] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Array.Copy(arr1, arr2, arr1.Length);
            //Console.WriteLine("The second array is:");
            //for (int r = 0; r < 2; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        Console.Write(arr2[r, c] + " ");
            //    }
            //    Console.WriteLine();
            #endregion

            #region Question 10
            //10-Write a Program to Print One Dimensional Array in Reverse Order.

            //int[] arr = new int[5];
            //Console.WriteLine("Please enter 5 numbers:");
            //for (int r = 0; r < arr.Length; r++)
            //{
            //    arr[r] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Dimensional Array in Reverse Order are :");
            //for (int r = arr.Length - 1; r >= 0; r--)
            //{
            //    Console.Write(arr[r] + " ");
            //}

            #endregion

        }













    }

}


