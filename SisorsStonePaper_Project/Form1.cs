using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScissorsStonePaper_Project
{
    public partial class Form1 : Form
    {
        public decimal TotalRounds;
        public decimal Rounds = 1;

        public Form1()
        {
            InitializeComponent();
            // Set the form size
            this.Size = new Size(1100, 700); // Adjust size as needed
            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TotalRounds > 0)
            {
                this.Hide();
                Form frm = new Form2(TotalRounds, Rounds);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Round should greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            TotalRounds = numericUpDown1.Value;
        }

    }
}
