using System;
using System.Collections.Generic;

namespace CollectionTime_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[50];
            List<int> intList = new List<int>();

            intList.Add(24);
            intList.Add(18);
            intList.Add(11);

            foreach(int number in intList)
            {
                Console.WriteLine($"The number is {number}");
            }

            // count - get all elements of the list
            Console.WriteLine("Does list have a length?: " + intList.Count);

            var studentFavNumDictionary = new Dictionary<string, int>();
            studentFavNumDictionary.Add("C++ Boy", 19);
            studentFavNumDictionary.Add("Ho Li Sheet", 100);
            studentFavNumDictionary.Add("PickleRick", 16);
            studentFavNumDictionary.Add("PickleJeff", 31);
            studentFavNumDictionary.Add("Double Sandwich", 12);
            studentFavNumDictionary.Add("Rae", 26);
            studentFavNumDictionary.Add("Shah", 24);

            studentFavNumDictionary["PickleJeff"] = 44; // replace the value to picklejeff
            Console.WriteLine($"Picking PickleJeff's fav number: {studentFavNumDictionary["PickleJeff"]}");

            studentFavNumDictionary["Turner"] = 11; // add to the dictionary
            if (studentFavNumDictionary.TryGetValue("Turner", out int faveNumber))
                Console.WriteLine($"Picking Prof. Turner's fav number: {faveNumber}");
            else
                Console.WriteLine("Turner does not exist in the dictionary");
        }
    }
}
