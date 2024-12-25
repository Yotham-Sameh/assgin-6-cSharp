namespace Assignment_6_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Difference Between Passing by Value and by Reference
            Console.WriteLine("Question 1: Comparing Passing by Value and Passing by Reference");

            string str = "Initial Value";

            // Pass by Value
            ModifyByValue(str);
            Console.WriteLine("After ModifyByValue: " + str);

            // Pass by Reference
            ModifyByReference(ref str);
            Console.WriteLine("After ModifyByReference: " + str);

            Console.WriteLine();

            static void ModifyByValue(string str)
            {
                str = "Value Changed in ModifyByValue";
            }

            static void ModifyByReference(ref string str)
            {
                str = "Value Changed in ModifyByReference";
            }
            #endregion

            //---------------------------------------------

            #region Question 2: Summation and Subtraction
            Console.WriteLine("Question 2: Performing Basic Arithmetic Operations");

            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth integer: ");
            int num4 = int.Parse(Console.ReadLine());

            var result = Calculate(num1, num2, num3, num4);
            Console.WriteLine($"Total Sum: {result.sum}");
            Console.WriteLine($"Total Difference: {result.difference}");

            Console.WriteLine();

            static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
            {
                int sum = num1 + num2 + num3 + num4;
                int difference = num1 - num2 - num3 - num4;
                return (sum, difference);
            }
            #endregion

            //-------------------------------------------------------------------------------------------------------------------------------------------------

            #region Question 3: Finding Min and Max Values in an Array
            Console.WriteLine("Question 3: Identifying Minimum and Maximum Values in an Array");

            int[] array = { 1, 5, 8, 9, 3, 7 };
            int min = 0, max = 0;

            MinMaxArray(array, ref min, ref max);

            Console.WriteLine($"Smallest Value: {min}");
            Console.WriteLine($"Largest Value: {max}");

            Console.WriteLine();

            static void MinMaxArray(int[] arr, ref int min, ref int max)
            {
                min = arr[0];
                max = arr[0];

                foreach (int num in arr)
                {
                    if (num < min)
                        min = num;

                    if (num > max)
                        max = num;
                }
            }
            #endregion

        }
    }
}
