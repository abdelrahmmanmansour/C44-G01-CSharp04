using System.Collections.Immutable;
using System.Drawing;
using System.Text;

namespace Assignment04
{
    internal class Program
    {
        // Example of Passing by Value(Value type parameters):
        static void Swap_Value(int a, int b)
        {
            // Swap the values
            int z = a;
            a = b;
            b = z;
        }
        // Example of Passing by Reference(Value type parameters):
        static void Swap_Reference(ref int a,ref int b)
        {
            // Swap the values
            int z = a;
            a = b;
            b = z;
        }
        // Example of Passing by Value(Reference type parameters):
        static int Sum_Array_Value(int[]arr)
        {
            int sum = 0;
            arr[0] = 40;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        // Example of Passing by Reference(Reference type parameters):
        static int Sum_Array_Reference(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 40, 50, 60 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        // Function that accept 4 parameters from user && return summation and subtracting of two numbers:
        // Passing By Output Parameters:
        static void Return_Sum_Sub(int a, int b, int c, int d, out int sum, out int sub)
        {
            sum = a + b;
            sub = c - d;
        }
        // Function to calculate the sum of the individual digits of a given number:
        static int Sum_Of_Individual_Digits(int Number)
        {
            int Sum = 0; // Initialize the sum of digits
            while (Number > 0)
            {
                int digit = Number % 10; // Get the last digit
                Number /= 10; // Remove the last digit
                Sum += digit; // Add the digit to the sum
            }
            return Sum;
        }
        // Function to know prime or not:
        static void IS_Prime(int Number)
        {
            int Counter = 0;
            for (int i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Counter++;
                }
            }
            if (Counter == 2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        // Function to return the minimum and maximum values stored in an array, using reference parameters:
        static void Min_Max_Array(int[] arr, ref int Max, ref int Min)
        {
            Max = int.MinValue; // Initialize Max to the smallest possible value
            Min = int.MaxValue; // Initialize Min to the largest possible value
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
        }
        // Function to return the minimum and maximum values stored in an array, using Out parameters:
        static void MinMaxArray(int[] arr, out int Max, out int Min)
        {
            Max = int.MinValue; // Initialize Max to the smallest possible value
            Min = int.MaxValue; // Initialize Min to the largest possible value
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
        }
        // Function to calculate the factorial of the number specified as parameter:
        static int Factorial_Number(int Number)
        {
            int Factorial = 1;
            for (int i = Number; i >= 1; i--)  // 4: 4 * 3 * 2 * 1 = 24
            {
                Factorial *= i; // Calculate the factorial
            }
            return Factorial; // Return the calculated factorial
        }
        // Function to modify a letter in a certain position (0 based) of a string, replacing it with a different letter:
        static void Change_Char(StringBuilder s, int p, char c)
        {
            // Check if the position is valid
            if (p < 0 || p >= s.Length)
            {
                Console.WriteLine("Invalid position");
                return; // Exit the function if the position is invalid
            }
            // if the position is valid, change the character
            s[p] = c; // Change the character at position p to c
            Console.WriteLine($"The Result: {s}");
        }
        // Function to print an identity matrix of size n * n:
        static void Print_Identity_Matrix(int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j) // Check i==j for diagonal elements
                    {

                        Console.Write($"{1} ");
                    }
                    else
                    {
                        Console.Write($"{0} ");
                    }
                }
                Console.WriteLine();
            }
        }
        // Function to find the sum of all elements of the array:
        static int Sum_Of_Array(int[] arr)
        {
            int sum = 0; // Initialize the sum
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; // Add each element to the sum
            }
            return sum; // Return the total sum
        }
        static void Main(string[] args)
        {
            #region 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example:
            // The Difference between passing by value and passing by reference in C# is as follows:
            // Passing By Value: A copy of the value is passed to the function.
            // Changes made to the parameter inside the function do not affect the original value.
            // Passing By Reference: A reference to the original value is passed to the function.
            // Changes made to the parameter inside the function affect the original value.
            // Example of Passing by Value(Value type parameters):
            //int a = 10, b = 20;
            //Console.WriteLine("Before-Swap_Value: ");
            //Console.WriteLine($"a: {a} b: {b}"); // 10 20
            //Swap_Value(a, b);
            //Console.WriteLine("After-Swap_Value: ");
            //Console.WriteLine($"a: {a} b: {b}"); // 10 20
            // Example of Passing by Reference(Value type parameters):
            //Console.WriteLine("Before-Swap_Reference: ");
            //Console.WriteLine($"a: {a} b: {b}"); // 10 20
            //Swap_Reference(ref a,ref b);
            //Console.WriteLine("After-Swap_Reference: ");
            //Console.WriteLine($"a: {a} b: {b}"); // 20 10
            #endregion
            #region 2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example:
            // The Difference between passing by value and passing by reference in C# is as follows:
            // Passing By Value: A copy of the value is passed to the function.
            // Changes made to the parameter inside the function do not affect the original value.
            // Passing By Reference: A reference to the original value is passed to the function.
            // Changes made to the parameter inside the function affect the original value.
            // Example of Passing by Value(Reference type parameters):
            //int[] arr = { 10, 20, 30 };
            //Console.WriteLine($"Sum is: {Sum_Array_Value(arr)}"); // 90
            //Console.WriteLine($"The First Element is: {arr[0]}"); // 40 (Changed inside the method)
            // Example of Passing by Reference(Reference type parameters):
            //int[] arr1 = { 10, 20, 30 };
            //Console.WriteLine($"Sum is: {Sum_Array_Reference(ref arr1)}"); // 150
            //Console.WriteLine($"The First Element is: {arr1[0]}"); //40 (Changed inside the method)
            #endregion
            #region 3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers:
            //int Num1, Num2, Num3, Num4,sum,sub;
            //Console.Write("Enter First Number: ");
            //Num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //Num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Third Number: ");
            //Num3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Fourth Number: ");
            //Num4 = Convert.ToInt32(Console.ReadLine());
            // Passing By Output Parameters:
            //Return_Sum_Sub(Num1, Num2, Num3, Num4, out sum, out sub);
            //Console.WriteLine($"Summation of Two Numbers: {sum}");
            //Console.WriteLine($"Subtracting of Two Numbers: {sub}");
            #endregion
            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number:
            //Console.Write("Please Enter A Number: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Sum Of The Individual Digits: {Sum_Of_Individual_Digits(Number)}");
            #endregion
            #region 5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Please Enter A Number: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //IS_Prime(Number);
            #endregion
            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters:
            //int[] arr = { 10, -20, 30, 40, 50,-30 };
            //int max=0, min=0;
            //Min_Max_Array(arr, ref max, ref min);
            //Console.WriteLine($"The Max is: {max}"); // 50
            //Console.WriteLine($"The Min is: {min}"); // -30
            #endregion
            #region 7. Create function to calculate the factorial of the number specified as parameter:
            //Console.Write("Please Enter A Number: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Factorial is: {Factorial_Number(Number)}");
            #endregion
            #region 8. Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter:
            //Console.Write("Please Enter String: ");
            //StringBuilder Word = new StringBuilder(Console.ReadLine()); // Use StringBuilder for mutable string
            //Console.Write("Please Enter Position: ");
            //int Position = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please Enter Character: ");
            //char c = Console.ReadLine()[0]; // Read the first character from the input
            //Change_Char(Word, Position, c);
            #endregion
            #region 9. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n:
            // Identity Matrix is a square matrix with 1s on the diagonal and 0s elsewhere.
            //     0 1 2
            // 0-> 1 0 0
            // 1-> 0 1 0
            // 2-> 0 0 1
            //Console.Write("Please Enter A Size: "); 
            //int Size = int.Parse(Console.ReadLine());
            //Print_Identity_Matrix(Size);
            #endregion
            #region 10. Write a program in C# Sharp to find the sum of all elements of the array:
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Please Enter Element {i + 1}: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"The Sum_Of_Array is: {Sum_Of_Array(arr)}");
            #endregion
            #region 11. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order:
            //int[] arr1 = { 10, 6, 5, -2 };
            //int[] arr2 = { 7, 3, 4, 8 };
            //int[] Merge = new int[arr1.Length + arr2.Length]; // Merge two arrays of the same size
            //Console.WriteLine(Merge.Length); // 8 (4 + 4)
            // i make to put the elements of the arr1,arr2 in the merged array,then sort it:
            //for (int i = 0; i < Merge.Length; i++)
            //{
            //    //if (i = 0,1,2,3) -< arr1
            //    //else if (i = 4,5,6,7) -< arr2
            //    Merge[i] = (i < arr1.Length) ? arr1[i] : arr2[i - arr1.Length];
            //}
            //Array.Sort(Merge); // Sort the merged array in ascending order
            //foreach (int i in Merge)
            //{
            //    Console.Write($"{i} "); // Print the merged array
            //}
            #endregion
            #region 12. Write a program in C# Sharp to find maximum and minimum element in an array:
            // Using Out parameters to find max and min in an array
            //int[] arr = { 10, -20, 30, 40, 50, -30 };
            //int max,min;
            //MinMaxArray(arr, out max, out min);
            //Console.WriteLine($"The Max is: {max}"); // 50
            //Console.WriteLine($"The Min is: {min}"); // -30
            #endregion
            #region 13. Write a program in C# Sharp to find the second largest element in an array:
            //int[] arr = { 3, 1, 2, 40, 100, 60 };
            //int firstMax = int.MinValue, secondMax = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > firstMax)
            //    {
            //        secondMax = firstMax; // Update secondMax to the previous firstMax
            //        firstMax = arr[i];                    
            //    }
            //    else // Check if the current element is less than firstMax but greater than secondMax
            //    {
            //        secondMax = arr[i]; // Update secondMax to the current element
            //    }
            //}
            //Console.WriteLine($"The Second Largest Element is: {secondMax}");
            #endregion
            #region 14. Consider an Array of Integer values with size N, having values as in this Example,write a program to find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3):
            //  Nested loop to find the longest distance between two equal cells
            // 0  1  2  3  4  5  6  7  8  9  10 11
            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int max=int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int x = j - i;
            //            if (x > max)
            //            {
            //                max = x; // Update max if the current distance is greater
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"The Max Distance is: {max-1}");
            #endregion
            #region 15. Given a list of space separated words, reverse the order of the words:
            //Console.Write("Please Enter A String: ");
            //string input = Console.ReadLine();
            //string[] Words = input.Split(' '); // Split the input string into words using space as a delimiter
            //for (int i = Words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Words[i] + " "); // Print the words in reverse order
            //}
            #endregion
            #region 16. Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array:
            //int [,] Matrix01 = new int[3, 3];
            //int [,] Matrix02 = new int[3, 3];
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.Write($"Please Enetr Element {rows},{col}: ");
            //        Matrix01[rows, col] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Matrix02[rows, col] = Matrix01[rows, col]; // Copy elements from Matrix01 to Matrix02
            //    }
            //}
            //Console.WriteLine("The Matrix02: ");
            //for (int rows = 0; rows < 3; rows++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.Write(Matrix02[rows,col]+" ");
            //    }
            //}
            #endregion
            #region 17. Write a Program to Print One Dimensional Array in Reverse Order:
            //int[] arr = { 10, 20, 30, 40, 50 };
            // First Solution:
            //Console.WriteLine("The Reverse Order: ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
                //Console.Write(arr[i] + " ");
            //}

            // Second Solution:
            //for (int i = 0; i < arr.Length / 2; i++)  //   i need to loop only half the array length
            //{
                //int temp = arr[i];
                //arr[i] = arr[arr.Length - 1 - i]; // Swap elements 
                //arr[arr.Length - 1 - i] = temp; // Swap elements
            //}
            //Console.WriteLine();
            //Console.WriteLine("The Reverse Order: ");
            // Print the reversed array Phisically 
            //for (int i = 0; i < arr.Length; i++)
            //{
                //Console.Write(arr[i] + " ");
            //}
            #endregion
        }
    }
}
