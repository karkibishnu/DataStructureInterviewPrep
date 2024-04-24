using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInterviewPrep.DataStructureTypes
{
    public static class TwoPointer
    {
        //method to print pairs with both positive and negative values
        public static void PrintPairsWithPositiveAndNegative(int[] arr)
        {
            //sort array to use two pointer
            Array.Sort(arr);

            //initialize two pointers, left starting from index 0
            //right starting from the last index
            int left = 0;
            int right = arr.Length - 1;

            //traverse array using two pointers
            while(left < right)
            {
                //check if left element is negative and right element is positive
                if(arr[left] < 0 && arr[right] > 0)
                {
                    //print pair and move the pointers
                    Console.WriteLine($"({arr[left]}, {arr[right]}");
                    left++;
                    right--;
                }                
                //if left element is positive, move right pointer to left
                else if(arr[left] > 0)
                {
                    right--;
                }
                //if left element is negative, move left pointer to right
                else
                {
                    left++;
                }
            }

        }
    }
}
