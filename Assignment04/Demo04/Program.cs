namespace Demo04
{
    // In Namespace: I Can Create Multiple Types Of Members.
    // 1. Class -> Function
    // 2. Struct -> Function
    // 3. Interface -> Function
    // 4. Enum
    internal class Program
    {
        static int Summtion(int a, int b)
        {
            // Must Return Value With Same Type As Function Signature + Keyword Return
            return a + b;
        }
        static void PrintMessage()
        {
               Console.WriteLine("Hello World");
        }
        static void PrintMessage(int Number)
        {
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
        static void PrintMessage(int Number, string Pattern)
        {
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        static void Print(int Number = 2, string Pattern = "X_J")
        {
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        static void Swap_Value(int x, int y)
        {
            int z = x;
            x = y;
            y = z;
        }
        static void Swap_Ref(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
        static int SumArray(int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumArray02(int[] arr)
        {
            int sum = 0;
            arr = new int[3] { 10, 20, 30 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumArray03(ref int[] arr)
        {
            int sum = 0;
            arr = new int[3] { 10, 20, 30 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumArray04(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void SumMul(int x, int b,out int Sum,out int Mul)
        {
            Sum = x + b;
            Mul = x * b;
        }
        static void Main(string[] args)
        {
            #region 1-D Array
            // Array(Reference): A collection of items of the same type, stored in a contiguous block of memory.
            // Arrays are fixed in size and can be accessed using an index.
            // Indexing starts at 0, so the first element is at index 0, the second at index 1, and so on.
            // index of last element is length - 1.
            // Equation to reach any element: Address of first element + (index * size of element type)
            // 0x00 + (0*4) -< 0x00;
            // Array immutable: The size of an array cannot be changed after it is created.
            // To declare an array, use the following syntax:
            // 1.
            int[] Numbers = { 1, 2, 3, 4, 5 };
            // 2.
            int[] Numbers01;
            Numbers01 = new int[5] { 1, 2, 3, 4, 5 };
            // Enter From User An array of 5 elements:
            int[] Numbers03 = new int[5];
            ;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Please Enter Numbers03[{i}]: ");
                Numbers03[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"{Numbers03[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(Numbers03.Length); // Length: The number of elements in the array= 5;
            Console.WriteLine(Numbers03.Rank);   // Rank: The number of dimensions in the array= 1; 
            #endregion
            #region 2-D Array
            // 2-D Array: Matrix
            // A 2-D array is an array of arrays, where each element is itself an array.
            // size of 2-D array is defined by the number of rows * columns it contains.
            // arr[row][coloumn]
            // It can be thought of as a table with rows and columns.
            // Rectangular arrays: All rows have the same number of columns.
            // Jagged arrays: Each row can have a different number of columns.
            // To declare a 2-D array, use the following syntax:
            // 1- Rectangular arrays:
            int[,] arr = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"Please Enter arr[{row},{col}]: ");
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{arr[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr.Length); // Length: The number of elements in the array= 9;
            Console.WriteLine(arr.Rank);  // Rank: The number of dimensions in the array= 2;

            // 2- Jagged arrays:
            // Know rows but not columns.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2]; // First row has 2 columns  
            jaggedArray[1] = new int[3]; // Second row has 3 columns
            jaggedArray[2] = new int[4]; // Third row has 4 columns
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"Please Enter jaggedArray[{row},{col}]: ");
                    jaggedArray[row][col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
            #endregion
            #region Function Prototype
            // Function Prototype: 
            // A function is a block of code that performs a specific task and can be reused.
            // Avoid Dry Code: Don't repeat yourself. Use functions to encapsulate reusable code.
            // Functions help to organize code, make it more readable, and reduce redundancy. 
            // Function Prototype:
            // 1. Signature: Name of the function, return type, and parameters(Inputs)
            // 2. Body: The code that is executed when the function is called.
            PrintMessage();  // Static Member Method
            PrintMessage(5); // Static Member Method with parameter
            PrintMessage(5, "X_X");
            PrintMessage(Number: 5, Pattern: "O_P"); //  Passing By Name
            Print(); //  Passing By Defult Value
            Print(5); // Passing By Defult Value with one parameter 
            Console.WriteLine(Summtion(4, 4));  // Calling Function
            int result = Summtion(5, 5); // Calling Function and storing the result in a variable
            Console.WriteLine(result);
            // Note:
            // Any Function Create Stack Frame In Memory.
            // Stack Frame: A block of memory that is used to store the function's local variables and parameters.
            // When Function is Called,Then the stack frame of this function is removed.
            #endregion
            #region Passing By Value vs Passing By Reference
            // Passing By Value vs Passing By Reference:
            // Passing By Value: A copy of the value is passed to the function.
            // Changes made to the parameter inside the function do not affect the original value.
            // Passing By Reference: A reference to the original value is passed to the function.
            // Changes made to the parameter inside the function affect the original value.

            // Value Type:
            // Example of Passing By Value:
            int x = 10, y = 5;
            Console.WriteLine("---------Before Swap-Value-----");
            Console.WriteLine($"X: {x},Y: {y}");
            Swap_Value(x, y);
            Console.WriteLine("---------After Swap-Value-----");
            Console.WriteLine($"X: {x},Y: {y}");

            // Example of Passing By Reference:
            Console.WriteLine("---------Before Swap-Reference-----");
            Console.WriteLine($"X: {x},Y: {y}");
            Swap_Ref(ref x, ref y);
            Console.WriteLine("---------After Swap-Reference-----");
            Console.WriteLine($"X: {x},Y: {y}");

            // Reference Type:
            // Ex01 of Passing By Value && Passing By Reference[The Same in this Example]:
            int[] arr01 = { 1, 2, 3 };
            int Sum = SumArray(arr01);
            Console.WriteLine(Sum);
            Console.WriteLine(arr01[0]);

            // Ex02 of Passing By Value:
            int[] arr02 = { 1, 2, 3 };
            int Sum01 = SumArray02(arr02);
            Console.WriteLine(Sum01); // 60
            Console.WriteLine(arr02[0]); // 1

            // Ex02 of Passing By Reference:
            int[] arr04 = { 1, 2, 3 };
            int Sum02 = SumArray03(ref arr04);
            Console.WriteLine(Sum02); // 60
            Console.WriteLine(arr04[0]); // 10  
            #endregion
            #region Passing By Out
            // Passing By Out:
            // To return multiple values from a function, you can use the `out` keyword.
            int X = 4, Y = 4, S, M;
            SumMul(X, Y, out S, out M);
            Console.WriteLine(S);
            Console.WriteLine(M);
            #endregion
            #region Params KeyWord
            // Params:
            // use when i don't know how many elements of array i will pass to the function.
            Console.WriteLine(SumArray04(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); // 55 
            #endregion
        }
    }
}
