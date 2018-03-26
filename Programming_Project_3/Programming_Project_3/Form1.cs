using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_OpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Declare variables
                String readText;
                String[] currentWord;
                String firstWordAlphabetically = "";
                String lastWordAlphabetically = "";
                String longestWord = "";
                String mostVowels = "";
                char[] wordCharArray;
                int currentVowelCount;
                int mostVowelCount = 0;

                //Clear the list box
                listBox1_Results.Items.Clear();

                try
                {
                    //Setup for file system.
                    StreamReader textFile = new StreamReader(openFileDialog1.FileName);
                    SaveFileDialog savefile = new SaveFileDialog();
                    StreamWriter saveFile = File.CreateText("Results_Programming_Project_3.txt");

                    while (!textFile.EndOfStream)
                    {
                        //load file
                        readText = textFile.ReadLine();
                        // lowe case text
                        readText = readText.ToLower();
                        //Split the line if more than one word
                        currentWord = readText.Split(' ');

                        //loop current word within the array
                        for (int i = 0; i < currentWord.Length; i++)
                        {

                            currentVowelCount = 0;
                            //Character array for searching for vowels.
                            wordCharArray = currentWord[i].ToCharArray();

                            //first word
                            if (firstWordAlphabetically == "")
                            {
                               
                                firstWordAlphabetically = currentWord[i];
                            }
                            else if (currentWord[i].CompareTo(firstWordAlphabetically) < 0)
                            {
                              
                                firstWordAlphabetically = currentWord[i];
                            }
                            //last word
                            if (lastWordAlphabetically == "")
                            {
                                lastWordAlphabetically = currentWord[i];
                            }
                            else if (currentWord[i].CompareTo(lastWordAlphabetically) > 0)
                            {
                                lastWordAlphabetically = currentWord[i];
                            }

                            //longest word
                            if (longestWord == "")
                            {
                                longestWord = currentWord[i];
                            }
                            else if (longestWord.Length < currentWord[i].Length)
                            {
                                longestWord = currentWord[i];
                            }

                            //find vowels
                            for (int j = 0; j < wordCharArray.Length; j++)
                            {
                                if (wordCharArray[j] == 'a' ||
                                wordCharArray[j] == 'e' ||
                                wordCharArray[j] == 'i' ||
                                wordCharArray[j] == 'o' ||
                                wordCharArray[j] == 'u')
                                {
                                    currentVowelCount++;
                                }
                            }

                            //Compare vowels.
                            if (currentVowelCount > mostVowelCount)
                            {
                                mostVowelCount = currentVowelCount;
                                mostVowels = currentWord[i];
                            }
                        }
                    }

                    //Write list box.
                    listBox1_Results.Items.Add("First word alphabetically: " + firstWordAlphabetically);
                    listBox1_Results.Items.Add("Last word alphabetically: " + lastWordAlphabetically);
                    listBox1_Results.Items.Add("Longest word: " + longestWord + " at " + longestWord.Length + " characters.");
                    listBox1_Results.Items.Add("Word with the most vowels: " + mostVowels + " with " + mostVowelCount + " vowels");

                    //save the file
                    saveFile.WriteLine("First word alphabetically: " + firstWordAlphabetically);
                    saveFile.WriteLine("Last word alphabetically: " + lastWordAlphabetically);
                    saveFile.WriteLine("Longest word: " + longestWord + " at " + longestWord.Length + " characters.");
                    saveFile.WriteLine("Word with the most vowels: " + mostVowels + " with " + mostVowelCount + " vowels");

                    saveFile.Close();
                    textFile.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
