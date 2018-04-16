using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // streamreader
            StreamReader inputFile = new StreamReader("Excercise_File.text");

            // list to store strings
            List<string> individualWords = new List<string>();
            List<string> exerciseText = new List<string>();

            string[] singles;

            // counter for words that end with t or e
            int counter = 0;

            // Read file
            while (!inputFile.EndOfStream)
            {
                exerciseText.Add(inputFile.ReadLine());
            }

            // loop to separate words
            foreach (string str in exerciseText)
            {
                // adding and removing 
                singles = str.Split(null);

                individualWords.AddRange(singles);
            }

            //Test each word that ends with t or e
            foreach (string str in individualWords)
            {
                // test for lowercase and uppercase and add to the counter
                if (str.ToLower().EndsWith("t") || str.ToLower().EndsWith("e") ||
                    str.ToLower().EndsWith("T") || str.ToLower().EndsWith("E"))
                    counter++;
            }

            // print to the console
            Console.WriteLine(String.Format("There are {0} words that end in 't' or 'e' ", counter));


            // close Console
            Console.ReadLine();

        }
    }
}
