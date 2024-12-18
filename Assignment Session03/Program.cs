using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            {
                Console.Write("1-Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    Console.Write(i);
                    if (i < number) Console.Write(", ");
                }
            }

            #endregion

            #region  2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            {
                Console.Write("2-Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(number * i + " ");
                }
            }

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            {
                
                Console.Write("3-Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 2; i <= number; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
            #endregion

            #region  4- Write a program that takes two integers then prints the power.

            {
                Console.Write("4-Enter the base number: ");
                int baseNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter the exponent: ");
                int exponent = int.Parse(Console.ReadLine());

                int result = 1;
                for (int i = 1; i <= exponent; i++)
                {
                    result *= baseNumber;
                }

                Console.WriteLine($"Result: {result}");
            }

            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            {
                
                Console.WriteLine("5-Enter marks of five subjects (separated by spaces): ");
                string[] marksInput = Console.ReadLine().Split(' ');

                
                int[] marks = Array.ConvertAll(marksInput, int.Parse);

                
                int totalMarks = 0;
                foreach (int mark in marks)
                {
                    totalMarks += mark;
                }

                
                double averageMarks = totalMarks / 5.0;

              
                double percentage = (totalMarks / 500.0) * 100;

                
                Console.WriteLine($"Total Marks = {totalMarks}");
                Console.WriteLine($"Average Marks = {averageMarks:F0}");
                Console.WriteLine($"Percentage = {percentage:F0}");
            }

            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            {
            
                Console.Write("6-Enter a string: ");
                string input = Console.ReadLine();

             
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);

                
                Console.WriteLine($"Reversed string: {reversedString}");
            }

            #endregion


            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

            {
              
                Console.Write("7-Enter an integer: ");
                int input = int.Parse(Console.ReadLine());

                
                int reversed = 0;

                while (input != 0)
                {
                    int digit = input % 10;  
                    reversed = reversed * 10 + digit;  
                    input /= 10;  
                }

                
                Console.WriteLine($"Reversed integer: {reversed}");
            }

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.

            {
                Console.Write("8-Input starting number of range: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Input ending number of range: ");
                int end = int.Parse(Console.ReadLine());

                Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

                for (int num = start; num <= end; num++)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }

            static bool IsPrime(int num)
            {
                if (num < 2)
                    return false;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            {
                Console.Write("9-Enter a number to convert: ");
                int number = int.Parse(Console.ReadLine());

                string binary = ConvertToBinary(number);

                Console.WriteLine($"The Binary of {number} is {binary}.");
            }

            static string ConvertToBinary(int number)
            {
                string binary = "";

                if (number == 0)
                    return "0";

                while (number > 0)
                {
                    binary = (number % 2) + binary;
                    number /= 2;
                }

                return binary;
            }
            #endregion


            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            {
                
                Console.Write("10-Enter coordinates of point 1 (x1, y1): ");
                string[] point1 = Console.ReadLine().Split(',');
                int x1 = int.Parse(point1[0]);
                int y1 = int.Parse(point1[1]);

                Console.Write("Enter coordinates of point 2 (x2, y2): ");
                string[] point2 = Console.ReadLine().Split(',');
                int x2 = int.Parse(point2[0]);
                int y2 = int.Parse(point2[1]);

                Console.Write("Enter coordinates of point 3 (x3, y3): ");
                string[] point3 = Console.ReadLine().Split(',');
                int x3 = int.Parse(point3[0]);
                int y3 = int.Parse(point3[1]);

                
                if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
                {
                    Console.WriteLine("The points lie on a single straight line.");
                }
                else
                {
                    Console.WriteLine("The points do not lie on a single straight line.");
                }
            }
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            {
                Console.Write("11-Enter the size of the matrix (n): ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                            Console.Write("1 ");
                        else
                            Console.Write("0 ");
                    }
                    Console.WriteLine(); 
                }
            }
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.


            {
                Console.Write("12-Enter the number of elements in the array: ");
                int n = int.Parse(Console.ReadLine());

                int[] numbers = new int[n];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine($"The sum of all elements in the array is: {sum}");
            }
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            {
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];

                Console.WriteLine("Enter elements of the first sorted array:");
                for (int idx1 = 0; idx1 < size; idx1++)
                {
                    array1[idx1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter elements of the second sorted array:");
                for (int idx2 = 0; idx2 < size; idx2++)
                {
                    array2[idx2] = int.Parse(Console.ReadLine());
                }

                int[] mergedArray = new int[2 * size];
                int i = 0, j = 0, k = 0;

                while (i < size && j < size)
                {
                    if (array1[i] < array2[j])
                        mergedArray[k++] = array1[i++];
                    else
                        mergedArray[k++] = array2[j++];
                }

                while (i < size)
                    mergedArray[k++] = array1[i++];

                while (j < size)
                    mergedArray[k++] = array2[j++];

                Console.WriteLine("Merged array in ascending order:");
                foreach (int num in mergedArray)
                {
                    Console.Write(num + " ");
                }
            }
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.

            {
                Console.Write("14-Enter the number of elements in the array: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < size; i++)
                {
                    if (array[i] != -1)  
                    {
                        int count = 1;
                        for (int j = i + 1; j < size; j++)
                        {
                            if (array[i] == array[j])
                            {
                                count++;
                                array[j] = -1;  
                            }
                        }
                        Console.WriteLine($"Element {array[i]} appears {count} times.");
                    }
                }
            }
            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

            {
                Console.Write("15-Enter the number of elements in the array: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                int max = array[0];
                int min = array[0];

                for (int i = 1; i < size; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                    if (array[i] < min)
                        min = array[i];
                }

                Console.WriteLine($"Maximum element: {max}");
                Console.WriteLine($"Minimum element: {min}");
            }
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.


            {
                Console.Write("16-Enter the number of elements in the array: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                if (size < 2)
                {
                    Console.WriteLine("Array must have at least two elements to find the second largest.");
                    return;
                }

                int largest = int.MinValue;
                int secondLargest = int.MinValue;

                for (int i = 0; i < size; i++)
                {
                    if (array[i] > largest)
                    {
                        secondLargest = largest;
                        largest = array[i];
                    }
                    else if (array[i] > secondLargest && array[i] != largest)
                    {
                        secondLargest = array[i];
                    }
                }

                if (secondLargest == int.MinValue)
                {
                    Console.WriteLine("There is no second largest element.");
                }
                else
                {
                    Console.WriteLine($"The second largest element is: {secondLargest}");
                }
            }
            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as in this Example

            {
                Console.Write("17-Enter the size of the array: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                int maxDistance = 0;

                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (array[i] == array[j])
                        {
                            int distance = j - i - 1;
                            if (distance > maxDistance)
                            {
                                maxDistance = distance;
                            }
                        }
                    }
                }

                Console.WriteLine($"The longest distance between two equal cells is: {maxDistance} cells.");
            }
            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.

            {
                Console.Write("18-Enter a list of space-separated words: ");
                string input = Console.ReadLine();

                string[] words = input.Split(' ');

                Array.Reverse(words);
                string reversedWords = string.Join(" ", words);

                Console.WriteLine(reversedWords);
            }
            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            {
                int rows = 2;
                int columns = 3;

                int[,] firstArray = new int[rows, columns];
                int[,] secondArray = new int[rows, columns];

                Console.WriteLine("19-Enter values for the first array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"Enter element at ({i},{j}): ");
                        firstArray[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Array.Copy(firstArray, secondArray, firstArray.Length);

                Console.WriteLine("Second array elements are:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(secondArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            {
                int[] array = { 1, 2, 3, 4, 5 };

                Console.WriteLine("20-Array in reverse order:");
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write(array[i] + " ");
                }
            }

            #endregion

        }
    }
}

