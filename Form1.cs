﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        // Starting the game with X 
        bool isOTurn = true;
        String winner = "";
        int turn_tracker = 0;
       

        // Creating 2D array to keep track of Tic-Tac-Toe Board 
        const int ROWS = 3;
        const int COLS = 3;
        string[,] tttBoard = new string[ROWS, COLS];
        

        private void newGameButton_Click(object sender, EventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";

            Array.Clear(tttBoard, 0, tttBoard.Length);
        }

    private  void button_click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (isOTurn)
                s.Text = "X";
            else
                s.Text ="Y";

            isOTurn = !isOTurn;
            s.Enabled = false;

            gameWinner();

        }

        bool gameWinner()
        {




            // if top row is the same
            if (tttBoard[0, 0] == "X" && tttBoard[0, 1] == "X" && tttBoard[0, 2] == "X")
            {
                winner = "X";
                return true;

            }

            if (tttBoard[0, 0] == "O" && tttBoard[0, 1] == "O" && tttBoard[0, 2] == "O")
            {
                winner = "O";
                return true;
            }
            // if middle row is the same
            if (tttBoard[1, 0] == "X" && tttBoard[1, 1] == "X" && tttBoard[1, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (tttBoard[1, 0] == "O" && tttBoard[1, 1] == "O" && tttBoard[1, 2] == "O")
            {
                winner = "O";
                return true;
            }
            // if bottom row is the same
            if (tttBoard[2, 0] == "X" && tttBoard[2, 1] == "X" && tttBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (tttBoard[2, 0] == "O" && tttBoard[2, 1] == "O" && tttBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }
            // if left coloumn is the same 
            if (tttBoard[0, 0] == "X" && tttBoard[1, 0] == "X" && tttBoard[2, 0] == "X")
            {
                winner = "X";
                return true;
            }

            if (tttBoard[0, 0] == "O" && tttBoard[1, 0] == "O" && tttBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }

            // if middle coloumn is the same 
            if (tttBoard[0, 1] == "X" && tttBoard[1, 1] == "X" && tttBoard[2, 1] == "X")
            {
                winner = "X";
                return true;
            }

            if (tttBoard[0, 1] == "O" && tttBoard[1, 1] == "O" && tttBoard[2, 1] == "O")
            {
                winner = "O";
                return true;
            }

            // if right column is the same 
            if (tttBoard[0, 2] == "X" && tttBoard[1, 2] == "X" && tttBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }
            if (tttBoard[0, 2] == "O" && tttBoard[1, 2] == "O" && tttBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            // if diagonally the same 

            if (tttBoard[0, 0] == "X" && tttBoard[1, 1] == "X" && tttBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (tttBoard[0, 0] == "O" && tttBoard[1, 1] == "O" && tttBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            if (tttBoard[0,2] == "X" && tttBoard[1,1] == "X" && tttBoard[2,0] == "X")
            {
                winner = "X";
                return true;
            }
            if (tttBoard[0, 2] == "O" && tttBoard[1, 1] == "O" && tttBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }



            return false;

            

        }

        


        private void a1_Click(object sender, EventArgs e)
        {
            if (isOTurn)
            {
                a1.Text = "X";
                tttBoard[0, 0] = "X";
                isOTurn = false;


            }
            else
            {
                a1.Text = "O";
                tttBoard[0, 0] = "O";
                isOTurn = true;

            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
            
            
        }
        

        private void a2_Click(object sender, EventArgs e)
        {
            if (isOTurn)
            {
                a2.Text = "X";
                tttBoard[0, 1] = "X";
                isOTurn = false;
            }
            else
            {
                a2.Text = "O";
                tttBoard[0, 1] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
          

        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (isOTurn)
            {
                a3.Text = "X";
                tttBoard[0, 2] = "X";
                isOTurn = false;
            }
            else
            {
                a3.Text = "O";
                tttBoard[0, 2] = "O";
                isOTurn = true;
            }
            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
           

        }

        private void b1_Click(object sender, EventArgs e)
        {
           if(isOTurn)
            {
                b1.Text = "X";
                tttBoard[1, 0] = "X";
                isOTurn = false;
            }
            else
            {
                b1.Text = "O";
                tttBoard[1, 0] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
         

        }

        private void b2_Click(object sender, EventArgs e)
        {
           if(isOTurn)
            {
                b2.Text = "X";
                tttBoard[1, 1] = "X";
                isOTurn = false;
            }
            else
            {
                b2.Text = "O";
                tttBoard[1, 1] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
           

        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (isOTurn)
            {
                b3.Text = "X";
                tttBoard[0, 2] = "X";
                isOTurn = false;

            }
            else
            {
                b3.Text = "O";
                tttBoard[0, 2] = "O";
                isOTurn = true;
            }
            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
            

        }

        private void c1_Click(object sender, EventArgs e)
        {
           if(isOTurn)
            {
                c1.Text = "X";
                tttBoard[2, 0] = "X";
                isOTurn = false;
            }
            else
            {
                c1.Text = "O";
                tttBoard[2, 0] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
            

        }

        private void c2_Click(object sender, EventArgs e)
        {
           if(isOTurn)
            {
                c2.Text = "X";
                tttBoard[2, 1] = "X";
                isOTurn = false;
            }
            else
            {
                c2.Text = "O";
                tttBoard[2, 1] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
           

        }

        private void c3_Click(object sender, EventArgs e)
        {
           if(isOTurn)
            {
                c3.Text = "X";
                tttBoard[2, 2] = "X";
                isOTurn = false;
            }
            else
            {
                c3.Text = "O";
                tttBoard[2, 2] = "O";
                isOTurn = true;
            }

            bool winner_winner = gameWinner();
            if (winner_winner)
            {
                MessageBox.Show(winner + " WON!!");
            }
            
        }

       

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form 
            this.Close();
        }
    }
}
