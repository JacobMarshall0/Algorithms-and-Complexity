using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AlgorithmsAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //creates list for datasets
                var dataSets = new List<string>();
                dataSets.Add("Net_1_256.txt");
                dataSets.Add("Net_2_256.txt");
                dataSets.Add("Net_3_256.txt");
                dataSets.Add("Net_4_512.txt"); // Merged 1 and 3 dataset
                dataSets.Add("Net_1_2048.txt");
                dataSets.Add("Net_2_2048.txt");
                dataSets.Add("Net_3_2048.txt");



                //List contains all the sorting and searching algorithms I intend to use
                List<string> algorithms = new List<string> { "Insertion Sort (Ascending)", "Insertion Sort (Descending)", "Bubble Sort (Ascending)", "Bubble Sort (Descending)", "Quick Sort (Ascending)", "Quick Sort (Descending)", "Binary Search", "Linear Search" };
                SortingAlgorithms Sort = new SortingAlgorithms();
                SearchingAlgorithms Search = new SearchingAlgorithms();

                //Introduction for user
                Console.WriteLine("Welcome to the program");
                Console.WriteLine("Please select which file you would like to load:");

                //prints the datasets to the user with an index before the filename
                for (int count = 0; count < dataSets.Count(); count++)
                {
                    Console.WriteLine((count + 1) + "." + dataSets[count]);
                }

                // while loop validates user input
                string[] data = { }; // reads file into string array

                var choice = Convert.ToInt32(Console.ReadLine());
                // Check if user selected a  file
                data = File.ReadAllLines(dataSets[Convert.ToInt32(choice) - 1]);

                // Prints all the algorithms to console
                for (int i = 0; i < algorithms.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {algorithms[i]}");
                }

                // Asks user for algorithm choice input
                Console.WriteLine("Select which algorithm you would like to use: ");
                // takes user input and converts to string
                var algorithmChoice = Convert.ToInt32(Console.ReadLine());

                //if statements to control which algorithm is run 
                if (Convert.ToInt32(algorithmChoice) == 1) { Sort.InsertionSortAsc(data); }
                else if (Convert.ToInt32(algorithmChoice) == 2) { Sort.InsertionSortDesc(data); }
                else if (Convert.ToInt32(algorithmChoice) == 3) { Sort.BubbleSortAsc(data); }
                else if (Convert.ToInt32(algorithmChoice) == 4) { Sort.BubbleSortDesc(data); }
                else if (Convert.ToInt32(algorithmChoice) == 5)
                {
                    Sort.QuickSortAsc(data, 0, (data.Count() - 1));
                    Console.WriteLine($"Steps taken: {SortingAlgorithms.steps}");
                }
                else if (Convert.ToInt32(algorithmChoice) == 6)
                {
                    Sort.QuickSortDesc(data, 0, (data.Count() - 1));
                    Console.WriteLine($"Steps taken: {SortingAlgorithms.steps}");
                }
                else if (Convert.ToInt32(algorithmChoice) == 7)
                {
                    Console.WriteLine("Please enter a value to search for:");
                    int searchValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Search.BinarySearch(data, searchValue));
                }
                else if (Convert.ToInt32(algorithmChoice) == 8)
                {
                    Console.WriteLine("Please enter a value to search for:");
                    int searchValue = Convert.ToInt32(Console.ReadLine());
                    Search.LinearSearch(data, searchValue);
                }

                else { Console.WriteLine("Invalid Choice."); }
            }
            

         
        }
    }
}
