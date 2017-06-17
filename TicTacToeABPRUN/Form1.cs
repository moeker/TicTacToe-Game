using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeABPRUN
{
    public partial class Form1 : Form
    {
        TheGame game = new TheGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            game.Reset();
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label2.Text = "";
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            game.setPlayer(game.mySelf);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            game.MakeMove(0, game.depth,double.NegativeInfinity,double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button1.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if(label2.Text=="You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if(label2.Text=="PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            game.MakeMove(1, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button2.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            game.MakeMove(2, game.depth,double.NegativeInfinity,double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button3.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.MakeMove(3, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button4.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            game.MakeMove(4, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button5.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.MakeMove(5, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button6.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.MakeMove(6, game.depth,double.NegativeInfinity,double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button7.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game.MakeMove(7, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button8.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game.MakeMove(8, game.depth, double.NegativeInfinity, double.PositiveInfinity);
            label2.Text = (game.showGameSate(game.Board, game.turn).ToString());
            button9.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Text = game.Board[0].ToString();
            button2.Text = game.Board[1].ToString();
            button3.Text = game.Board[2].ToString();
            button4.Text = game.Board[3].ToString();
            button5.Text = game.Board[4].ToString();
            button6.Text = game.Board[5].ToString();
            button7.Text = game.Board[6].ToString();
            button8.Text = game.Board[7].ToString();
            button9.Text = game.Board[8].ToString();
            if (button1.Text == "E")
            {
                button1.Text = "";
            }
            if (button2.Text == "E")
            {
                button2.Text = "";
            }
            if (button3.Text == "E")
            {
                button3.Text = "";
            }
            if (button4.Text == "E")
            {
                button4.Text = "";
            }
            if (button5.Text == "E")
            {
                button5.Text = "";
            }
            if (button6.Text == "E")
            {
                button6.Text = "";
            }
            if (button7.Text == "E")
            {
                button7.Text = "";
            }
            if (button8.Text == "E")
            {
                button8.Text = "";
            }
            if (button9.Text == "E")
            {
                button9.Text = "";
            }
            if (label2.Text == "You Win")
            {
                label2.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
            }
            else if (label2.Text == "PC Wins")
            {
                label2.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            else if (label2.Text == "Draw")
            {
                label2.ForeColor = Color.Blue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            game.depth = 8;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            game.depth = 3;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            game.depth = 0;
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
