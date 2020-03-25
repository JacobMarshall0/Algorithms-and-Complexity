using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace AlgorithmsAssessment1
{
    class SortingAlgorithms
    {
        //creates public int to track steps taken to sort an array
        public static int steps = 0;


        // insertion sort in ascending order code
        public string[] InsertionSortAsc(string[] array)
        {
            int steps = 0;
            int length = array.Count();
            // cycle through items in array
            for (int i = 1; i < length; i++)
            {
                string pivot = array[i];
                int j = i - 1;
                // shift item from right of the pivot to the left if they are larger than the pivot
                while (j >= 0 && Convert.ToInt32(pivot) < Convert.ToInt32(array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                    steps++;
                }
                array[j + 1] = pivot;
                steps++;
            }
            //code to print data
            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            Console.WriteLine($"Steps taken: {steps}");
            return array;
        }
        // insertion sort in descending order
        public string[] InsertionSortDesc(string[] array)
        {
            int steps = 0;
            int length = array.Count();
            // cycles array items
            for (int i = 1; i < length; i++)
            {
                string pivot = array[i];
                int j = i - 1;
                // shift item from left of the pivot to the right if they are smaller than the pivot
                while (j >= 0 && Convert.ToInt32(pivot) > Convert.ToInt32(array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                    steps++;
                }
                array[j + 1] = pivot;
                steps++;
            }
            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            Console.WriteLine($"Steps taken: {steps}");
            return array;
        }

        public string[] BubbleSortAsc(string[] array)
        {
            int steps = 0;
            int length = array.Count();
            // cylces array items
            for (int i = 0; i < length; i++)
            {
                // cycles array and swaps items if if statement is true
                for (int j = 0; j < (length - i - 1); j++)
                {
                    if (Convert.ToInt32(array[j]) > Convert.ToInt32(array[j + 1]))
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        steps++;
                    }
                }
            }
            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            Console.WriteLine($"Steps taken: {steps}");
            return array;
        }

        //separate function to avoid printing steps and data for use in search
        public string[] BubbleSortForSearch(string[] array)
        {
            int length = array.Count();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < (length - i - 1); j++)
                {
                    if (Convert.ToInt32(array[j]) > Convert.ToInt32(array[j + 1]))
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public string[] BubbleSortDesc(string[] array)
        {
            int steps = 0;
            int length = array.Count();
            // cylces throuh array items
            for (int i = 0; i < length; i++)
            {
                // Swaps items if if statement is true
                for (int j = 0; j < (length - i - 1); j++)
                {
                    if (Convert.ToInt32(array[j]) < Convert.ToInt32(array[j + 1]))
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        steps++;
                    }
                }
            }

            //code to print 10th line for 256 item datasets and 50th line for 2048 item datasets
            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else 
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            //prints steps taken
            Console.WriteLine($"Steps taken: {steps}");
            return array;
        }
        
        public string[] QuickSortAsc(string[] array, int left, int right)
        {
            int i = left; // smallest index
            int j = right; // largest index
            int pivot = Convert.ToInt32(array[(left+right)/2]);
            do
            {
                // works towards pivot upwards
                while ((Convert.ToInt32(array[i]) < pivot) && (i < right)) { i++; }
                // works towards pivot downwards 
                while ((pivot < Convert.ToInt32(array[j])) && (j > left)) { j--; }
                // if i <= j, swap items
                if ( i <= j)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                steps++;

            } while (i <= j);
            
            if (left < j) { QuickSortAsc(array, left, j); }
            if (i < right) { QuickSortAsc(array, i, right); }

            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            return array;
        }

        public string[] QuickSortDesc(string[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = Convert.ToInt32(array[(left + right) / 2]);
            do
            {
                while ((Convert.ToInt32(array[i]) > pivot) && (i < right)) { i++; }
                while ((pivot > Convert.ToInt32(array[j])) && (j > left)) { j--; }
                if (i <= j)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                steps++;
                
            } while (i <= j);

            if (left < j) { QuickSortDesc(array, left, j); }
            if (i < right) { QuickSortDesc(array, i, right); }

            int count = 0;
            foreach (string line in array)
            {

                if (array.Count() == 2048)
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                else
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine($"{line} ---- at index {count}");
                    }
                }
                count++;

            }
            return array;     
        
        }        
    }
}
