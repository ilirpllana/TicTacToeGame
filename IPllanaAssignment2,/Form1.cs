// ILIR PLLANA
// ASSIGNMENT 2 - TIC TAC TOE GAME
// STEVE HENDRIKSE - GAME OBJECT ORIENTED

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IPllanaAssignment2_
{
    public partial class Form1 : Form
    {
        bool playerturn = true;
        bool[,] xindex ={ { true, true, true }, { true, true, true }, { true, true, true} };
        bool[,] oindex = { { false, false, false }, { false, false, false }, { false, false, false} };
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
      
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Check if O or X wins: diagonal, vertical, horizontal ./
        public void checkWinner()
        {
            
            string calculation1 = xindex[0, 0].ToString() + xindex[0, 1].ToString() + xindex[0, 2].ToString();
            string calculation2 = oindex[0, 0].ToString() + oindex[0, 1].ToString() + oindex[0, 2].ToString();

            string calculation3 = xindex[1, 0].ToString() + xindex[1, 1].ToString() + xindex[1, 2].ToString();
            string calculation4 = oindex[1, 0].ToString() + oindex[1, 1].ToString() + oindex[1, 2].ToString();

            string calculation5 = xindex[2, 0].ToString() + xindex[2, 1].ToString() + xindex[2, 2].ToString();
            string calculation6 = oindex[2, 0].ToString() + oindex[2, 1].ToString() + oindex[2, 2].ToString();

            string calculation7 = xindex[0, 0].ToString() + xindex[1, 0].ToString() + xindex[2, 0].ToString();
            string calculation8 = oindex[0, 0].ToString() + oindex[1, 0].ToString() + oindex[2, 0].ToString();

            string calculation9 = xindex[0, 1].ToString() + xindex[1, 1].ToString() + xindex[2, 1].ToString();
            string calculation10 = oindex[0, 1].ToString() + oindex[1, 1].ToString() + oindex[2, 1].ToString();

            string calculation11 = xindex[0, 2].ToString() + xindex[1, 2].ToString() + xindex[2, 2].ToString();
            string calculation12 = oindex[0, 2].ToString() + oindex[1, 2].ToString() + oindex[2, 2].ToString();

            string calculation13 = xindex[0, 0].ToString() + xindex[1, 1].ToString() + xindex[2, 2].ToString();
            string calculation14 = oindex[0, 0].ToString() + oindex[1, 1].ToString() + oindex[2, 2].ToString();

            string calculation15 = xindex[2, 0].ToString() + xindex[1, 1].ToString() + xindex[0, 2].ToString();
            string calculation16 = oindex[2, 0].ToString() + oindex[1, 1].ToString() + oindex[0, 2].ToString();
            counter++;
            
            // calculation array

            string[] cal = {calculation1, calculation2, calculation3,
                            calculation4, calculation5, calculation6,
                            calculation7, calculation8, calculation9,
                            calculation10, calculation11, calculation12,
                            calculation13, calculation14, calculation15,calculation16};


            if (cal[0].Length == 15 || cal[2].Length == 15 || cal[4].Length == 15 || cal[6].Length == 15 || cal[8].Length == 15 || cal[10].Length == 15 || cal[12].Length == 15 || cal[14].Length == 15)
            {

                MessageBox.Show("X Wins");
                reset();
                
            }

            else if (cal[1].Length == 12 || cal[3].Length == 12 || cal[5].Length == 12 || cal[7].Length == 12 || cal[9].Length == 12 || cal[11].Length == 12 || cal[13].Length == 12 || cal[15].Length == 12)
            {

                MessageBox.Show("O Wins");
                reset();
            }

            else if (counter == 9)
            {
                MessageBox.Show("It's a Draw");
                reset();
            }
        }


        // X and O Images that are shown on buttons
       
        private void btn1_Click(object sender, EventArgs e)
        {
            if (playerturn == true) {

                btn1.BackgroundImage = Properties.Resources.X;
                btn1.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn1.Enabled = false;
                xindex[0, 0] = false;
                checkWinner();

            }
            else
            {

                btn1.BackgroundImage = Properties.Resources.O;
                btn1.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn1.Enabled = false;
                oindex[0, 0] = true;
                checkWinner();
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn2.BackgroundImage = Properties.Resources.X;
                btn2.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn2.Enabled = false;
                xindex[0, 1] = false;
                checkWinner();
            }
            else
            {

                btn2.BackgroundImage = Properties.Resources.O;
                btn2.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn2.Enabled = false;
                oindex[0, 1] = true;
                checkWinner();
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn3.BackgroundImage = Properties.Resources.X;
                btn3.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn3.Enabled = false;
                xindex[0, 2] = false;
                checkWinner();
            }
            else
            {

                btn3.BackgroundImage = Properties.Resources.O;
                btn3.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn3.Enabled = false;
                oindex[0, 2] = true;
                checkWinner();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn4.BackgroundImage = Properties.Resources.X;
                btn4.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn4.Enabled = false;
                xindex[1, 0] = false;
                checkWinner();

            }
            else
            {

                btn4.BackgroundImage = Properties.Resources.O;
                btn4.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn4.Enabled = false;
                oindex[1, 0] = true;
                checkWinner();
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {


            if (playerturn == true)
            {

                btn5.BackgroundImage = Properties.Resources.X;
                btn5.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn5.Enabled = false;
                xindex[1, 1] = false;
                checkWinner();
            }
            else
            {

                btn5.BackgroundImage = Properties.Resources.O;
                btn5.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn5.Enabled = false;
                oindex[1, 1] = true;
                checkWinner();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn6.BackgroundImage = Properties.Resources.X;
                btn6.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn6.Enabled = false;
                xindex[1, 2] = false;
                checkWinner();
            }
            else
            {

                btn6.BackgroundImage = Properties.Resources.O;
                btn6.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn6.Enabled = false;
                oindex[1, 2] = true;
                checkWinner();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn7.BackgroundImage = Properties.Resources.X;
                btn7.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn7.Enabled = false;
                xindex[2, 0] = false;
                checkWinner();
            }
            else
            {

                btn7.BackgroundImage = Properties.Resources.O;
                btn7.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn7.Enabled = false;
                oindex[2, 0] = true;
                checkWinner();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn8.BackgroundImage = Properties.Resources.X;
                btn8.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn8.Enabled = false;
                xindex[2, 1] = false;
                checkWinner();
            }
            else
            {

                btn8.BackgroundImage = Properties.Resources.O;
                btn8.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn8.Enabled = false;
                oindex[2, 1] = false;
                checkWinner();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (playerturn == true)
            {

                btn9.BackgroundImage = Properties.Resources.X;
                btn9.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = false;
                btn9.Enabled = false;
                xindex[2, 2] = false;
                checkWinner();
            }
            else
            {

                btn9.BackgroundImage = Properties.Resources.O;
                btn9.BackgroundImageLayout = ImageLayout.Stretch;
                playerturn = true;
                btn9.Enabled = false;
                oindex[2, 2] = true;
                checkWinner();
            }
        }
        // Exit the game on stripMenu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        // About - on the StripMenu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ilir Pllana", "Tic Tac Toe", MessageBoxButtons.OK);
           
        }

        // Restart the Game on the StripMenu
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        // when game completes, it starts automatically again to play
        public void reset()
        {

            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;

            counter = 0;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            playerturn = true;

            for(int a = 0; a<=2; a++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    xindex[a, i] = true;
                    oindex[a, i] = false;


                }
            }
        }

    }
}
