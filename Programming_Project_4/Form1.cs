using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_NEWGAME_Click(object sender, EventArgs e)
        {
            // Initilize random number object
            Random rand = new Random();

            // size of board
            const int rows = 3;
            const int columns = 3;

            // two-dimensional int array.
            int[,] playingBoard = new int[rows, columns];

            // Fill array with random integers between 0 and 1
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    playingBoard[row, col] = rand.Next(2);
                }
            }

            // values from array
            label1.Text = changeValue(playingBoard[0, 0]);
            label2.Text = changeValue(playingBoard[0, 1]);
            label3.Text = changeValue(playingBoard[0, 2]);

            label4.Text = changeValue(playingBoard[1, 0]);
            label5.Text = changeValue(playingBoard[1, 1]);
            label6.Text = changeValue(playingBoard[1, 2]);

            label7.Text = changeValue(playingBoard[2, 0]);
            label8.Text = changeValue(playingBoard[2, 1]);
            label9.Text = changeValue(playingBoard[2, 2]);

            //O win check
            if (playingBoard[0, 0] == 0 && (playingBoard[0, 0] == playingBoard[0, 1]) && (playingBoard[0, 1] == playingBoard[0, 2]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[1, 0] == 0 && (playingBoard[1, 0] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[1, 2]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[2, 0] == 0 && (playingBoard[2, 0] == playingBoard[2, 1]) && (playingBoard[2, 1] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[0, 0] == 0 && (playingBoard[0, 0] == playingBoard[1, 0]) && (playingBoard[1, 0] == playingBoard[2, 0]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[0, 1] == 0 && (playingBoard[0, 1] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[2, 1]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[0, 2] == 0 && (playingBoard[0, 2] == playingBoard[1, 2]) && (playingBoard[1, 2] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[0, 0] == 0 && (playingBoard[0, 0] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is O!";
            }
            else if (playingBoard[0, 2] == 0 && (playingBoard[0, 2] == playingBoard[1, 1]) && (playingBoard[0, 1] == playingBoard[2, 0]))
            {
                text_Winner.Text = "Winner is O!";
            }


            //X win check
            if (playingBoard[0, 0] == 1 && (playingBoard[0, 0] == playingBoard[0, 1]) && (playingBoard[0, 1] == playingBoard[0, 2]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[1, 0] == 1 && (playingBoard[1, 0] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[1, 2]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[2, 0] == 1 && (playingBoard[2, 0] == playingBoard[2, 1]) && (playingBoard[2, 1] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[0, 0] == 1 && (playingBoard[0, 0] == playingBoard[1, 0]) && (playingBoard[1, 0] == playingBoard[2, 0]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[0, 1] == 1 && (playingBoard[0, 1] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[2, 1]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[0, 2] == 1 && (playingBoard[0, 2] == playingBoard[1, 2]) && (playingBoard[1, 2] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[0, 0] == 1 && (playingBoard[0, 0] == playingBoard[1, 1]) && (playingBoard[1, 1] == playingBoard[2, 2]))
            {
                text_Winner.Text = "Winner is X!";
            }
            else if (playingBoard[0, 2] == 1 && (playingBoard[0, 2] == playingBoard[1, 1]) && (playingBoard[0, 1] == playingBoard[2, 0]))
            {
                text_Winner.Text = "Winner is X!";
            }  
        }

        // change integers to string value
        public string changeValue(int integerValue)
        {
            if (integerValue == 0)
            {
                return "0";
            }
            else
            {
                return "X";
            }
        }
    }
}
 
