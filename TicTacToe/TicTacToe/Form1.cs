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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
