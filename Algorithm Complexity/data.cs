using System;
using System.IO;

namespace Algorithm_Complexity
{
    class FileRead
    {
        public int[] Road_1_256 { get; private set; }
        public int[] Road_2_256 { get; private set; }
        public int[] Road_3_256 { get; private set; }
        public int[] Road_1_2048 { get; private set; }
        public int[] Road_2_2048 { get; private set; }
        public int[] Road_3_2048 { get; private set; }
        public FileRead()
        {
            Road_1_256 = StringToInt(File.ReadAllLines("Road_1_256.txt"));
            Road_2_256 = StringToInt(File.ReadAllLines("Road_2_256.txt"));
            Road_3_256 = StringToInt(File.ReadAllLines("Road_3_256.txt"));
            Road_1_2048 = StringToInt(File.ReadAllLines("Road_1_2048.txt"));
            Road_2_2048 = StringToInt(File.ReadAllLines("Road_2_2048.txt"));
            Road_3_2048 = StringToInt(File.ReadAllLines("Road_3_2048.txt"));
        }
        public int[] StringToInt(string[] data)
        {
            return Array.ConvertAll(data, s => int.Parse(s)); //function to convert a string array to an integer array
        }
        public void ArrayOutput(int[] data)
        {
            foreach(int a in data)
            {
                Console.WriteLine(a);
            }
        }

    }
}