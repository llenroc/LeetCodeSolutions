﻿using System;
using LeetCodeSolutionsLib;

namespace LeetCodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Two Sum
            //Problem: Given a array of ints, return indices of 2 numbers when summed together add to the target value
            //       - Using a Hashtable or Dictionary we can get the following complexity
            //Time Complexity:  O(n)
            //Space Complexity: O(n)
            TwoSums twoSums = new TwoSums(new int[] {2, 7, 11, 15}, 18);
            twoSums.PrintExample();

            #endregion

            #region 3. LongestSubstringWithoutRepeatingCharacters
            //Problem: Given 2 non-empty linked lists where the digits are stroed in reverse order (each node can contain a single digit). 
            //         Add the 2 numbers and return it as a linked list
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeating = new LongestSubstringWithoutRepeatingCharacters("abcdecb");
            longestSubstringWithoutRepeating.PrintExample();

            #endregion

            #region 7. Reverse Integer
            ReverseInteger reverseInteger = new ReverseInteger(-54321);
            reverseInteger.PrintExample();

            #endregion

            #region 9. Palindrome Number
            PalindromeNumber palindromeNumber = new PalindromeNumber(121);
            palindromeNumber.PrintExample();

            #endregion

            #region 26. Remove Duplicates from Sorted Array
            int[] nums = {1, 2, 3, 3, 4, 5, 5, 5, 5, 5, 5, 6};
            RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray(nums);
            removeDuplicatesFromSortedArray.PrintExample();

            #endregion
            
            #region 35. Search Insert Position
            int[] arr = {1, 3, 5, 10};
            SearchInsertPosition searchInsertPosition = new SearchInsertPosition(arr,9);
            searchInsertPosition.PrintExample();

            #endregion

            #region 136. Single Number

            SingleNumber singleNumber = new SingleNumber(new []{2,2,3,3,1});
            singleNumber.PrintExample();

            #endregion

            #region 217. Contains Duplicate

            int[] containsDuplicatesArray = new int[]{1,2,3,1};
            ContainsDuplicate containsDuplicate = new ContainsDuplicate(containsDuplicatesArray);
            containsDuplicate.PrintExample();
            #endregion

            #region 344. Reverse String

            string reverseString344 = "A man with a plan";
            ReverseString reverseString = new ReverseString(reverseString344);
            reverseString.PrintExample();

            #endregion

            #region 387. First Unique Character in a String

            string firstUniqueCharacterString = "loveleetcode";
            FirstUniqueCharacterInAString firstUniqueChar= new FirstUniqueCharacterInAString(firstUniqueCharacterString);
            firstUniqueChar.PrintExample();

            #endregion

            #region 412. FizzBuzz
            //Problem: Write a program that outputs the string representation of numbers form 1 to n
            //For multiples of 3 it should output "Fizz"
            //For multiples of 5 it should output "Buzz"
            //For multiples of both it should output "FizzBuzz";
            FizzBuzz fizzBuzz = new FizzBuzz(15);
            fizzBuzz.PrintExample();

            #endregion

            #region 622. MyCircularQueue
            MyCircularQueue myCircularQueue = new MyCircularQueue(1);
            Console.WriteLine("622. Circular Queue");
            Console.WriteLine($"Front(): {myCircularQueue.Front()}");
            Console.WriteLine($"IsEmpty() : {myCircularQueue.IsEmpty()}");
            myCircularQueue.EnQueue(1);
            Console.WriteLine($"IsEmpty() : {myCircularQueue.IsEmpty()}");
            Console.WriteLine($"IsFull() : {myCircularQueue.IsFull()}\n");

            #endregion

            #region 747. Largest Number at Least Twice of Others

            LargestNumberAtLeastTwiceOfOthers largestNumberAtLeastTwiceOfOthers = new LargestNumberAtLeastTwiceOfOthers(new []{3,6,1,0});
            largestNumberAtLeastTwiceOfOthers.PrintExample();
        
            #endregion

            #region 771. Jewels and Stones
            string j = "aA", s = "aAAbbbb";
            JewelsAndStones jewelsAndStones = new JewelsAndStones(j, s);
            jewelsAndStones.PrintExample();

            #endregion

            #region 832. Flipping an Image
            int[][] flippingImageArray = new int[3][];
            flippingImageArray[0] = new int[] { 1, 1, 0 };
            flippingImageArray[1] = new int[] { 1, 0, 1 };
            flippingImageArray[2] = new int[] { 0, 0, 0 };
            FlippingAnImage flippingAnImage = new FlippingAnImage(flippingImageArray);
            flippingAnImage.PrintExample();

            #endregion


            Console.ReadLine();

        }
    }
}
