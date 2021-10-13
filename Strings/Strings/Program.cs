using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "double sandwich told pickle jeff that he is a very mean person!";
            //Console.WriteLine(sentence);

            sentence += "\nProf. Turner agrees with double sandwich. Now, I am hungry.";

            //Console.WriteLine(sentence);


            //char[] letters = sentence.ToCharArray();

            //StringArray(letters);

            //letters = sentence.ToCharArray(2,2);
            //Console.WriteLine("\n");
            //StringArray(letters);
            //Console.WriteLine("\n");
            //string newSubstring = sentence.Substring(16);
            //Console.WriteLine(newSubstring);

            //newSubstring = sentence.Substring(16,4);
            //Console.WriteLine(newSubstring);
            // split
            //char[] delimiters = { ' ', ',','!', '.' };
            //string[] words = sentence.Split(delimiters);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            // index of
            int place = sentence.IndexOf(".");

            while (place != -1)
            {
                Console.WriteLine($". is found at index {place++}");
                sentence = sentence.Substring(place);
                place = sentence.IndexOf(".");
            }

        }// end method Main

        private static void StringArray(char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i]);
            }
        }
    }// end class Program
}// end Namespace 
