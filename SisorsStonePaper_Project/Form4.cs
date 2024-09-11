using ScissorsStonePaper_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisorsStonePaper_Project
{
    public partial class Form4 : Form
    {
       // private Form3 _parentForm;
        public Form4()
        {
            InitializeComponent();

            // Set the form size
            this.Size = new Size(1100, 700); // Adjust size as needed
            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            //   _parentForm = parentForm;

            label_ComputerWon.Text = Form2.GameResults.Computer2WinTimes.ToString();
            label_DrawWon.Text     = Form2.GameResults.DrawTime.ToString();
            label_PlayerWon.Text   = Form2.GameResults.Player1WinTimes.ToString();


            if (Form2.GameResults.Player1WinTimes > Form2.GameResults.Computer2WinTimes)
            {
                label8.Text = "Winner: Player1 Won the Game With final Result = " + Form2.GameResults.Player1WinTimes;
                label1.BackColor = Color.GreenYellow;
                label_PlayerWon.BackColor = Color.GreenYellow;
            }
            else if (Form2.GameResults.Player1WinTimes < Form2.GameResults.Computer2WinTimes)
            {
                label8.Text = "Winner: Computer Won the Game With final Result = " + Form2.GameResults.Computer2WinTimes;
                label4.BackColor = Color.GreenYellow;
                label_ComputerWon.BackColor = Color.GreenYellow;
            }                
            else
            {
                label8.Text = "No Winner";
                label3.BackColor = Color.GreenYellow;
                label_DrawWon.BackColor = Color.GreenYellow;             
            }

        }


    }
}
