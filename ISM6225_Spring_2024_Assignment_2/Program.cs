﻿using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // ChatGPT helped me with the logic for this code. Copilot helped me with the syntax. -JNegron
                HashSet<int> numSet = new HashSet<int>(nums);
                List<int> missingNumbers = new List<int>();

                int n = nums.Length;
                for (int i = 1; i <= n; i++)
                {
                    if (!numSet.Contains(i))
                    {
                        // Copilot suggested the code below, I only updated the return statement. -JNegron
                        // Add missing number to the list
                        missingNumbers.Add(i);
                    }
                }
                
                return missingNumbers; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {   
                // Copilot suggested the code below, I only updated the return statement. -JNegron
                // Create a new array to hold the sorted values
                int[] sortedArray = new int[nums.Length];
                int evenIndex = 0;
                int oddIndex = nums.Length - 1;
                foreach (int num in nums)
                {
                    if (num % 2 == 0) // Even number
                    {
                        sortedArray[evenIndex] = num;
                        evenIndex++;
                    }
                    else // Odd number
                    {
                        sortedArray[oddIndex] = num;
                        oddIndex--;
                    }
                }
                // Write your code here
                return sortedArray; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Copilot suggested the code below. -JNegron
                HashSet<int> numSet = new HashSet<int>();
                foreach (int num in nums)
                {
                    int complement = target - num;
                    if (numSet.Contains(complement))
                    {
                        return new int[] { Array.IndexOf(nums, complement), Array.IndexOf(nums, num) };
                    }
                    numSet.Add(num);
                }
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                return nums[nums.Length-3]* nums[nums.Length-2]* nums[nums.Length-1]; 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Copilot suggested the code below. I figured out the logic to confirm -JNegron 
                List<int> binaryDigits = new List<int>();
                while (decimalNumber > 0)
                {
                    binaryDigits.Add(decimalNumber % 2);
                    decimalNumber /= 2;
                }
                // Write your code here
                binaryDigits.Reverse(); // Reverse the list to get the correct binary representation
                return string.Join("",binaryDigits); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int min = nums[0];
                foreach (int num in nums)
                {
                    if (num < min) // Check for negative numbers
                    {
                        return num; // Placeholder
                    }

                }
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                //string constains a reverse function, so this is a simple way to check if a number is a palindrome. -JNegron
                //logic was helped by ChatGPT -JNegron
                string str = x.ToString();
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                string reversed = new string(chars);
                return str == reversed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
               //wrote this with logic helped by ChatGPT -JNegron
                if (n == 0) return 0;
                if (n == 1) return 1;

                int a = 0, b = 1, result = 0;
                for (int i = 2; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
