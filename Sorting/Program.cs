using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option: \n1.BubbleSort \n2.InsertionSort \n3.SelectionSort");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    #region BubbleSort
                    // declare an array of integers that are not sorted
                    int[] nums = { 5, 10, 3, 2, 4 };
                    // Use this to know when to stop the sorting routine
                    bool swapped;
                    Console.WriteLine("Bubble Sorting Algorithm!");
                    // Output the unsorted array to the console
                    Console.WriteLine("Before: 5, 10, 3, 2, 4");

                    // Here we use a do loop but could have used for or while loops as well.
                    do
                    {
                        // set swapped to false so that we can ensure at least one pass on the array
                        swapped = false;

                        for (int i = 0; i < nums.Length - 1; i++)
                        {
                            // here we use the i for the position in the array
                            // So i is the first value to compare and i + 1 compares the adjacent value
                            // Once i is incremented at the end of this loop, we compare the next two sets of values, etc.
                            if (nums[i] > nums[i + 1])
                            {
                                // swap routine.  Could be a separate method as well but is used inline for simplicity here
                                // temp is used to hold the right value in the comparison so we don't lose it.  That value will be replaced in the next step
                                int temp = nums[i + 1];

                                // Here we replace the right value with the larger value that was on the left.   See why we needed the temp variable above?
                                nums[i + 1] = nums[i];

                                // Now we assign the value that is in temp, the smaller value, to the location that was just vacated by the larger number
                                nums[i] = temp;

                                // Indicate that we did a swap, which means we need to continue to check the remaining values.
                                swapped = true;
                            }
                        }

                    } while (swapped == true);
                    // output the sorted array to the console

                    Console.Write("After: ");
                    for (int i = 0; i < nums.Length; i++)
                    {
                        Console.Write("{0}, ", nums[i]);
                    }

                    // Use Console.ReadLine() in the event application was started with debugging.
                    Console.ReadLine();
                    #endregion
                    break;
                case 2:
                    #region InsertionSort
                    Console.WriteLine("Insertion Sorting:");
                    // Declare an integer array that is not sorted
                    int[] arr = { 7, 8, 4, 6, 2, 1 };
                    // Output the values of the array to the console
                    Console.WriteLine("Array before sort: 7,8,4,6,2,1");

                    // Declare variable for the insertion value
                    int newValue;
                    // The outer loop allows us to iterate over the complete array that we will use for sorting
                    for (int i = 1; i < arr.Length; i++)
                    {
                        // set newValue equal to the second element in the array
                        // we don't start at the first element because it has no preceding value
                        // which means we can't move it any further forward in the array
                        newValue = arr[i];

                        // Also set the start of our inner loop to the same value as i
                        int j = i;

                        // This loop will check the value of j to ensure we have not reached the end of the iteration (j = 0)
                        // but also checks to see if the value preceding the current value is larger.
                        // If it is, we "swap" the value before this one, decrement j, and then test against the next value
                        // This continues until we run out of numbers in the array (j = 0) or there are no more values larger than
                        // the current number (newValue) to it's left (preceding it).
                        while (j > 0 && arr[j - 1] > newValue)
                        {

                            arr[j] = arr[j - 1];

                            j--;

                        }

                        arr[j] = newValue;

                    }

                    Console.Write("Array after sort: ");
                    foreach (int val in arr)
                    {
                        Console.Write(val + ",");
                    }
                    Console.WriteLine();
                    #endregion
                    break;
                case 3:
                    Console.WriteLine("Selection Sorting:");
                    break;
                default:
                    Console.WriteLine("Please selection an option!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
