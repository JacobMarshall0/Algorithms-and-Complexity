using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAssessment1
{
    class SearchingAlgorithms
    {   
        // creates sorting instance as binary search requires sorted array
        SortingAlgorithms Sort = new SortingAlgorithms();
        public int steps = 0;

        public string BinarySearch(string[] array, int value)
        {
            array = Sort.BubbleSortForSearch(array); // sorts array
            int min = 0; 
            int max = array.Count() - 1; // gets last index
            
            var positions = new List<int>();      

            while (min <= max) //until array is exhausted
            {
                int mid = (min + max) / 2; // gets midpoint between indexes
                if (value == Convert.ToInt32(array[mid])) // if the value is at the midpoint
                {
                    return $"Value found at position {mid} after {steps} steps"; // returns info
                    
                } else if (value < Convert.ToInt32(array[mid])) // if the value is less than the midpoint
                {
                    max = mid - 1; // set 1 below midpoint as new upper bound for index
                } else
                {
                    min = mid + 1; // set 1 above midpoint as new lower bound
                }
                steps++; // increment steps to keep track of iterations
            }
            /* --------------- Terrible code that failed to find other positions, - ran out of memory
            int indexDown = positions[0] - 1;
            while (Convert.ToInt32(array[indexDown]) == value)
            {
                indexDown--;
                if (Convert.ToInt32(array[indexDown]) == value)
                {
                    positions.Add(indexDown);
                }
            }
            int indexUp = positions[0] + 1;
            while (Convert.ToInt32(array[indexUp]) == value)
            {
                indexUp++;
                if (Convert.ToInt32(array[indexUp]) == value)
                {
                    positions.Add(indexUp);
                }
            }
            */
            return $"Not found, it took {steps} steps to determine this"; // return error message indicating the value could not be found  
        }
        
        public void LinearSearch(string[] array, int value) 
        {
            var positions = new List<int>(); // create list for indexes of value positions
            for (int i = 0; i < array.Count(); i++)  // cycle through the array
            {
                steps++; // increment steps taken
                if (Convert.ToInt32(array[i]) == value) // if the current item is the same as the value
                {
                    positions.Add(i); // add to positions array
                }
            }
            if (positions.Count() == 0) // if the positions list is empty
            {
                Console.WriteLine($"Not found after {steps} steps"); // there are no instances of the value in the array
            }
            else // if there are instances of the value
            {
                foreach (int item in positions) // iterates through positions list
                {
                    Console.WriteLine($"Found at position {item} after {steps} steps"); // Writes message indicating index
                }
            }
            
        }
    }
}