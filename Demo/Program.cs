using System.Numerics;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    class Employee
    {
        public int id { get; set; }
        public string? Name { get; set; } = null;
        public int? age { get; set; }
        public decimal salary { get; set; }
        public Department? department { get; set; }
    }

    class Department
    {
        public int id { get; set; }
        public string Name { get; set; } =string.Empty;
    }
    class Program
    {
        private static int c;
        private static bool index;
        private static object not;

        public static bool Is { get; private set; }

        static void Main()
        {

            #region Part 01 One Dimensional Array

            //int[] Numbers;
            //Numbers = new int[3];                           // Way 1
            ////int[] Numbers02 = new int[3] { 1, 2, 3 };     // Way 2
            ////int[] Numbers03 = new int[] {1,2,3};          // Way 3
            ////int[] Numbers04 = { 1, 2, 3 };                // Way 4
            ////int[] Numbers05 = [ 1, 2, 3 ];                // Way 5 (start .Net 8.0 - c# 12.0)

            //Console.WriteLine($"the size of array ={Numbers.Length}, Num of dimention ={Numbers.Rank}");
            ////for ( int i = 0; i < Numbers.Length; i++ )
            ////    Console.WriteLine( Numbers[i] );

            //foreach (int Number in Numbers)     //print elements of Array
            //    Console.WriteLine(Numbers);

            #endregion

            #region Part 02 Two D Array - Rectangular 
            //Example 1
            //uint[,] Grades = new uint[3, 5];
            //for (int r = 0; r < Grades.GetLength(0); r++)
            //{
            //    Console.WriteLine($"please insert the Grades of students number : ({r + 1})");
            //    for (uint c = 0; c < Grades.GetLength(1); c++)
            //    {
            //        Console.Write($"The Grades for student num : ({c + 1}) = ");
            //        Grades[r, c] = (uint)int.Parse(Console.ReadLine() ?? "0");
            //    }
            //}

            //Example 3
            //int[,] Grades = new int[3, 5];
            //for (int n = 0; n < Grades.Length; n++)
            //{
            //    Console.WriteLine(Grades[n / 5, n % 5]);
            //}


            //Example 2
            //uint[,] Grades = new uint[3, 5];
            //bool flag;
            //for (int r = 0; r < Grades.GetLength(0); r++)
            //{
            //    Console.WriteLine($"please insert the Grades of students number : ({r + 1})");
            //    for (uint c = 0; c < Grades.GetLength(1);)
            //    {
            //        Console.Write($"The Grades for student num : ({c + 1}) = ");
            //        flag = uint.TryParse(Console.ReadLine(), out Grades[r, c]);
            //        if (flag)
            //        {
            //            c++;
            //        }
            //    }
            //}

            #endregion

            #region Part 03 Two D Array - Judged Array
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[3] { 1, 2, 3 };
            //Marks[1] = new int[2] { 1, 2 };
            //Marks[3] = new int[1] { 1 };
            //Console.WriteLine(Marks);

            #endregion

            #region Part 04 Array Methods
            //class Member Method :
            //int[] Numbers = { 1, 9, 3, 8, 5, 7, 2, 4, 6, };
            //Array.Sort(Numbers);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //int[] arr01 = { 1, 9, 3};
            //int[] arr02 = {5, 7};
            //Array.Copy(arr01, arr02, 2);
            //foreach(int Number in arr02)
            //Console.WriteLine(Number);

            //int[] Numbers = { 1, 9, 3, 8, 5, 7, 2, 4, 6, };
            //Array.Clear(Numbers);
            //foreach (int Number in Numbers)
            //    Console.WriteLine(Number);

            //int[] arr01 = { 1, 9, 3 };
            //int[] arr02 = { 5, 7 };
            //Array.Copy(arr01,1, arr02,0, 2);
            //foreach (int Number in arr02)
            //    Console.WriteLine(Number);

            //int[] Numbers = { 1, 9, 3, 8, 5, 7, 2, 4, 6 };
            //int index = Array.IndexOf(Numbers, 8); 
            //Console.WriteLine(index);

            //object Member Method :
            //int[] arr01 = { 1, 9, 3 };
            //int[] arr02 = new int[5];
            //arr01.CopyTo(arr02, 1);
            //foreach (int Number in arr02)
            //    Console.WriteLine(Number);
            #endregion

            #region Part 05 Boxing, UnBoxing
            //Boxing

            //object obj;
            //obj = new object();
            //obj = new string("Nada");
            //obj = 5;    //Boxing
            //obj = 5.5;  //Boxing
            //obj = true; //Boxing
            //obj = 'A';  //Boxing
            //Console.WriteLine($"obj = {obj}");

            //un Boxing
            //object obj;
            //obj = new object();
            //int Number;
            //Number = (int)obj;  //unBoxing (un safe casting)
            //Number = obj.GetType() == typeof(int) ? (int)obj : 0; //safe
            //Number = obj is int ? (int)obj : 0;  //syntax suger
            //Console.WriteLine(Number);
            #endregion

            #region Part 07 Nullable - Value Types
            //Example 1

            //Nullable<int> Age;
            //int? Age; //syntax suger
            //Age = null;
            //Console.WriteLine(Age is null? 0: Age);
            //Console.WriteLine(Age.HasValue? Age: 0);

            //Example 2

            //Nullable<decimal> salary;
            //decimal? salary;
            //salary = null;
            //salary = 5_000;
            //Console.WriteLine(salary is null? 0: salary);
            //Console.WriteLine(salary.HasValue? salary: 0);

            //Example 3

            //int x = 10;             //x Allows int only
            //int? y = x;          //y Allows int + null
            //Console.WriteLine(y);
            //casting from int [value type] to Nullable<int>[Nullable value type}
            //safe castiing

            //Example 4

            //int? x = 10;             //x Allows int only + null
            //x = null;
            //int y =(int)x ;          //y Allows int
            //Console.WriteLine(y);
            //casting from Nullable<int>[Nullable value type} to int [value type]
            //safe castiing

            /*protective code*/ //casting from Nullable<int>[Nullable value type} to int [value type]
                                //Way 1

            //int? x = 10;
            //x = null;
            //int y;
            //if (x is not null)
            //    y = (int)x;
            //else
            //    y = 0;
            //Console.WriteLine(y);

            //Way 2
            //int? x = 10;
            //x = null;
            //int y;
            //if (x.HasValue)
            //    y = x.Value;
            //else
            //    y = 0;
            //Console.WriteLine(y);

            //Way 3
            //int? x = 10;
            //x = null;
            //int y;
            //y =x.HasValue ? x.Value : 0;     //y = x ?? 0; (syntax suger)
            //Console.WriteLine(y);

            #endregion

            #region Part 08 Nullable - Reference Types  

            //string  Message01=null!;  //! null forgiveness operator
            //string? Message02=null;
            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02);

            #endregion

            #region Part 09 Null Propagation Operator

            //Example 1

            //int[]? Numbers = { 1, 2, 3, 4, 5 };
            //if (Numbers is not null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            //Example 2

            //int[]? Numbers = { 1, 2, 3, 4, 5 };
            //int length;
            //if (Numbers is not null)
            //    length = Numbers.Length;
            //else
            //    length = 0;

            //length = Numbers?.Length ?? 0;

            #endregion

        }
    }

}
