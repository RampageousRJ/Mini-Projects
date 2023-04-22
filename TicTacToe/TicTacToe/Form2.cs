using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void message_win(char winner) {
            if (winner == '=')
            {
                DialogResult dr1 = MessageBox.Show("The game has drawn!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (dr1 == DialogResult.OK)
                {
                    Landing frm = new Landing();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                display.Text = winner+" Wins";
                DialogResult dr2 = MessageBox.Show("Player " + winner + " Wins", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (dr2 == DialogResult.OK)
                {
                    Landing frm = new Landing();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        public void hideAllButtons() {
            box1.Hide(); box2.Hide(); box3.Hide(); box4.Hide(); box5.Hide(); box6.Hide(); box7.Hide();                    box8.Hide(); box9.Hide();
        }

        public void win() {
            bool x1 = X1.Visible, x2 = X2.Visible, x3 = X3.Visible, x4 = X4.Visible, x5 = X5.Visible, x6 =                X6.Visible, x7 = X7.Visible, x8 = X8.Visible, x9 = X9.Visible;

            bool o1 = O1.Visible, o2 = O2.Visible, o3 = O3.Visible, o4 = O4.Visible, o5 = O5.Visible, o6 =                O6.Visible, o7 = O7.Visible, o8 = O8.Visible, o9 = O9.Visible;
            
            if(x1 && x2 && x3){
                topline.Visible = true;
                message_win('X');
            }
            if (x4 && x5 && x6)
            {
                hcenter.Visible = true;
                message_win('X');
            }
            if (x7 && x8 && x9)
            {
                bottomline.Visible = true;
                message_win('X');
            }
            if (x1 && x4 && x7)
            {
                leftline.Visible = true;
                message_win('X');
            }
            if (x2 && x5 && x8)
            {
                centerline.Visible = true;
                message_win('X');
            }
            if (x3 && x6 && x9)
            {
                rightline.Visible = true;
                message_win('X');
            }
            if (x1 && x5 && x9) {
                hideAllButtons();
                nonprimediag.Visible = true;
                message_win('X');
            }
            if (x3 && x5 && x7)
            {
                hideAllButtons();
                primediag.Visible = true;
                message_win('X');
            }
            if (o1 && o5 && o9)
            {
                hideAllButtons();
                nonprimediag.Visible = true;
                message_win('O');
            }
            if (o3 && o5 && o7)
            {
                hideAllButtons();
                primediag.Visible = true;
                message_win('O');
            }
            if (o1 && o2 && o3)
            {
                topline.Visible = true;
                message_win('O');
            }
            if (o4 && o5 && o6)
            {
                hcenter.Visible = true;
                message_win('O');
            }
            if (o7 && o8 && o9)
            {
                bottomline.Visible = true;
                message_win('O');
            }
            if (o1 && o4 && o7)
            {
                leftline.Visible = true;
                message_win('O');
            }
            if (o2 && o5 && o8)
            {
                centerline.Visible = true;
                message_win('O');
            }
            if (o3 && o6 && o9)
            {
                message_win('O');
                rightline.Visible = true;
            }
            if ((o1 || x1) && (o2 || x2) && (o3 || x3) && (o4 || x4) && (o5 || x5) && (o6 || x6) && (o7 || x7) && (o8 || x8) && (o9 || x9)) {
                display.Text = " Draw";
                message_win('=');
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            System.Environment.Exit(0);
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X1.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O1.Visible = true;
                display.Text = "X Turn";
            }
            box1.Hide();
            win();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X2.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O2.Visible = true;
                display.Text = "X Turn";
            }
            box2.Hide();
            win();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X3.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O3.Visible = true;
                display.Text = "X Turn";
            }
            box3.Hide();
            win();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X4.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O4.Visible = true;
                display.Text = "X Turn";
            }
            box4.Hide();
            win();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X5.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O5.Visible = true;
                display.Text = "X Turn";
            }
            box5.Hide();
            win();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X6.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O6.Visible = true;
                display.Text = "X Turn";
            }
            box6.Hide();
            win();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X7.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O7.Visible = true;
                display.Text = "X Turn";
            }
            box7.Hide();
            win();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X8.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O8.Visible = true;
                display.Text = "X Turn";
            }
            box8.Hide();
            win();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == 'X')
            {
                X9.Visible = true;
                display.Text = "O Turn";
            }
            else
            {
                O9.Visible = true;
                display.Text = "X Turn";
            }
            box9.Hide();
            win();
        }
    }
}
