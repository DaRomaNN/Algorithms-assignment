using System;
using System.IO;

namespace Algorithm_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            FileRead read = new FileRead();
            while(true)
            {
                Console.WriteLine("\n\n ---- ROAD TRAFFIC DATA ----\nSelect one of the numbers below: "
                                + "\n 0. End the program"
                                + "\n 1. Task 2 (Road_1,2,3_256 ascending and descending order)"
                                + "\n 2. Task 3 (Search for value in array & find duplicates (Sequential Search))"
                                + "\n 3. Task 3 (Search for value in array & find duplicated (Binary Search))");
                string UserInput = Console.ReadLine();
                switch (UserInput)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        task2(read);
                        break;
                    case "2":
                        Console.WriteLine("\n Please enter the value you want to search: ");
                        int key;
                        string stringkey = Console.ReadLine();
                        key = Int16.Parse(stringkey);
                        int[] data = read.Road_1_256;
                        int[] dataSorted = InsertionSort(data);
                        Console.WriteLine("\nSearching for a value in Road_1_256");
                        SequentialSearch(dataSorted, key);
                        int[] data2 = read.Road_2_256;
                        int[] dataSorted2 = InsertionSort(data2);
                        Console.WriteLine("\nSearching for a value in Road_2_256");
                        SequentialSearch(dataSorted2, key);
                        int[] data3 = read.Road_3_256;
                        int[] dataSorted3 = InsertionSort(data3);
                        Console.WriteLine("\nSearching for a value in Road_3_256");
                        SequentialSearch(dataSorted3, key);
                        break;
                    case "3":
                        Console.WriteLine("\n Please enter the value you want to search: ");
                        int key2;
                        string stringkey2 = Console.ReadLine();
                        key2 = Int16.Parse(stringkey2);
                        int[] data4 = read.Road_1_256;
                        int[] dataSorted4 = InsertionSort(data4);
                        Console.WriteLine("\nSearching for a value in Road_1_256");
                        BinarySearch(dataSorted4, key2);
                        int[] data5 = read.Road_2_256;
                        int[] dataSorted5 = InsertionSort(data5);
                        Console.WriteLine("\nSearching for a value in Road_2_256");
                        BinarySearch(dataSorted5, key2);
                        int[] data6 = read.Road_3_256;
                        int[] dataSorted6 = InsertionSort(data6);
                        Console.WriteLine("\nSearching for a value in Road_3_256");
                        BinarySearch(dataSorted6, key2);
                        break;
                }
            }
        }
        private static void task2(FileRead read)
        {
            Console.WriteLine("\nRoad_1_256 (Displaying every 10th value)\n(ASCENDING)");
            int[] data = read.Road_1_256;
            int[] dataSorted = InsertionSort(data);
            EveryOutput(dataSorted, 10);
            Console.WriteLine("\n(DESCENDING)");
            int[] dataSortedDescending = InsertionSortDescending(data);
            EveryOutput(dataSortedDescending, 10);
            
            Console.WriteLine("\n\nRoad_2_256 (Displaying every 10th value)\n(ASCENDING)");
            int[] data2 = read.Road_2_256;
            int[] dataSorted2 = InsertionSort(data2);
            EveryOutput(dataSorted2, 10);
            Console.WriteLine("\n(DESCENDING)");
            int[] dataSortedDescending2 = InsertionSortDescending(data2);
            EveryOutput(dataSortedDescending2, 10);
            
            Console.WriteLine("\n\nRoad_3_256 (Displaying every 10th value)\n(ASCENDING)");
            int[] data3 = read.Road_3_256;
            int[] dataSorted3 = InsertionSort(data3);
            EveryOutput(dataSorted3, 10);
            Console.WriteLine("\n(DESCENDING)");
            int[] dataSortedDescending3 = InsertionSortDescending(data3);
            EveryOutput(dataSortedDescending3, 10);
        }
        private static int[] InsertionSort(int[] data)
        {
            int numSorted = 1; // number of values in place
            int index; // general index
            while (numSorted < data.Length)
            {
                // take the first unsorted value
                int temp = data[numSorted];
                // … and insert it among the sorted
                for (index=numSorted; index>0; index--)
                {
                    if (temp < data[index-1])
                    {
                        data[index] = data[index-1];
                    }
                    else 
                    {
                        break;
                    }
               }
            // reinsert value
            data[index] = temp;
            numSorted++;
            }
            return data;
        }
       
        private static int[] InsertionSortDescending(int[] data) //Similar to InsertionSort but the arrays are sorted in descending order
        {
            int numSorted = 1; 
            int index; 
            while (numSorted < data.Length)
            {
                int temp = data[numSorted];

                for (index=numSorted; index>0; index--)
                {
                    if (temp > data[index-1])
                    {
                        data[index] = data[index-1];
                    }
                    else 
                    {
                        break;
                    }
               }

            data[index] = temp;
            numSorted++;
            }
            return data;
        }
        private static void EveryOutput(int[] data, int nth)
        {
            for (int i = nth - 1; i <= data.Length; i += nth)
            {
                Console.Write(data[i] + ",");
            }
        }
        private static void SequentialSearch(int[] data, int key)
        {
            Console.Write("Value is at positions: ");
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == key)
                {
                    Console.Write($"{i + 1}, ");
                }
                counter++;
            }
            Console.WriteLine("\n Amount of steps taken to search: " + counter);
        }
        private static void BinarySearch(int[] data, int key) 
        {
            int left; 
            int midpoint; 
            int right; 
            left = 0; 
            right = data.Length - 1;
            int counter = 0;
            while (left <= right)
            {
                midpoint = (left + right) / 2;
                if (key == data[midpoint])
                {
                    Console.WriteLine("Value is at positions: " + midpoint);
                    break;
                }
                else if (key > data[midpoint])
                {
                    left = midpoint + 1;
                } 
                else 
                {
                    right = midpoint - 1;
                }
                counter++;
            }
            Console.WriteLine("Amount of steps taken to search: " + counter);
        }
    }  
}
