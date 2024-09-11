using SisorsStonePaper_Project;
using SisorsStonePaper_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScissorsStonePaper_Project.Form2;

namespace ScissorsStonePaper_Project
{
    public partial class Form3 : Form
    {
        public Form2 _parentForm;
        public decimal totalRounds;
        public decimal currentRound;

        public Form3(decimal totalRounds, decimal currentRound, Form2 parentForm)
        {

            InitializeComponent();

            // Set the form size
            this.Size = new Size(1100, 700); // Adjust size as needed
            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Shown += new EventHandler(Form3_Shown);
            
            this._parentForm = parentForm;
            this.totalRounds = totalRounds;
            this.currentRound = currentRound;
            label3.Text = currentRound.ToString();
        }

        private void PreviousForm2()
        {
            if (currentRound < totalRounds)
            {
                this.Hide();
                Form2 form2 = new Form2(totalRounds, currentRound + 1);                
                form2.ShowDialog();
                
            }
            else
            {
                if(MessageBox.Show("No more rounds left!") == DialogResult.OK)
                {
                    this.Hide();                    
                    Form4 frm4 = new Form4();
                    frm4.ShowDialog();
                    
                }
             
            }
        }

        void MakeBackColorToWon()
        {
            if(Form2.RoundInfo.Winner == Form2.enWinner.Player1)
            {
                btn_Player1.BackColor = Color.YellowGreen;               
            }
            else if (Form2.RoundInfo.Winner == Form2.enWinner.Computer)
            {
                btn_Computer.BackColor = Color.YellowGreen;
            }
            else
            {
                btn_Player1.BackColor = Color.YellowGreen;
                btn_Computer.BackColor = Color.YellowGreen;
            }
        }

        void showTheMessage(Form2.enGameChoice Player1, Form2.enGameChoice Computer)
        {

            string message;
            string title;

            if (Form2.RoundInfo.Winner == Form2.enWinner.Draw)
            {
                message = $"Draw: {Player1} = {Computer}";
                title = "Winner: Draw No Winner";
            }
            else if (Form2.RoundInfo.Winner == Form2.enWinner.Computer)
            {
                message = $"You Lost: {Computer} Got Beaten by {Player1}";
                title = "Winner: Computer Won";
            }
            else
            {
                message = $"You Won: {Player1} Beats {Computer}";
                title = "Winner: Player1 Won";
            }

            if (MessageBox.Show(message, title, MessageBoxButtons.OK) == DialogResult.OK)
            {
                PreviousForm2();
            }

        }
        void ChangeImages()
        {
            btn_Player1.BackgroundImage  = Resources.ResourceManager.GetObject(Form2.RoundInfo.Player1Choice.ToString()) as Image;
            btn_Computer.BackgroundImage = Resources.ResourceManager.GetObject(Form2.RoundInfo.ComputerChoice.ToString()) as Image;


            MakeBackColorToWon();
            showTheMessage(Form2.RoundInfo.Player1Choice, Form2.RoundInfo.ComputerChoice);

        }


        private void Form3_Shown(object sender, EventArgs e)
        {
           
            lb_Won.Text = Form2.RoundInfo.WinnerName;

            ChangeImages();
          
        }

    }
}
