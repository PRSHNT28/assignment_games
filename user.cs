using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_2
{
    public partial class user : UserControl
    {
        bool playerX = true;
        Button[,] b = new Button[3, 3];



        public user()
        {
            InitializeComponent();
            b[0, 0] = b1;
            b[0, 1] = b2;
            b[0, 2] = button3;
            b[1, 0] = b4;
            b[1, 1] = b5;
            b[1, 2] = b6;
            b[2, 0] = b7;
            b[2, 1] = b8;
            b[2, 2] = b9;
        }
        private bool PlayerWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (b[i, 0].Text == b[i, 1].Text && b[i, 1].Text == b[i, 2].Text && b[i, 0].Text != "" && b[i, 0].Enabled == false)
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (b[0, i].Text == b[1, i].Text && b[1, i].Text == b[2, i].Text && b[0, i].Text != "" && b[0, i].Enabled == false)
                {
                    return true;
                }
            }

            if (b[0, 0].Text == b[1, 1].Text &&
        b[1, 1].Text == b[2, 2].Text &&
        b[0, 0].Text != "" && b[0, 0].Enabled == false)
            {
                return true;
            }

            if (b[0, 2].Text == b[1, 1].Text &&
                b[1, 1].Text == b[2, 0].Text &&
                b[0, 2].Text != "" && b[0, 2].Enabled == false)
            {
                return true;
            }
            return false;
        }
        private void resetGame()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    b[i, j].Text = "";
                    b[i, j].Enabled = true;


                }
            playerX = true;
            turn.Text = "Player 1(X)";
        }



        private void b2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (playerX == true)
            {

                playerX = false;
                b.Text = "X";
                turn.Text = "Player 2(O)";
            }
            else
            {

                playerX = true;
                b.Text = "O";
                turn.Text = "Player 1(X)";
            }
            b.Enabled = false;
            if (PlayerWin())
            {
                if (playerX == false)
                {
                    MessageBox.Show("Winner Player X", "Winner");


                }
                else
                {
                    MessageBox.Show("Winner Player O", "Winner");


                }

            }
            else if (b1.Enabled == false && b2.Enabled == false && button3.Enabled == false && b4.Enabled == false && b5.Enabled == false && b6.Enabled == false && b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)
            {

                MessageBox.Show("Match draw!", "No Winner");
                resetGame();

            }
        }

        private void tictac_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
