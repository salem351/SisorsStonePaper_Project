using SisorsStonePaper_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScissorsStonePaper_Project
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public decimal totalRounds;
        public decimal currentRound ;
        public Form2(decimal totalRounds, decimal currentRound)
        {
            InitializeComponent();

            // Set the form size
            this.Size = new Size(1100, 700); // Adjust size as needed
            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            instance = this;
            this.totalRounds = totalRounds;
            this.currentRound = currentRound;

            lb_Round.Text = currentRound.ToString();
            lb_Draw.Text = GameResults.DrawTime.ToString();
            lb_Won.Text = GameResults.Player1WinTimes.ToString();
            lb_Lost.Text = GameResults.Computer2WinTimes.ToString();
        }

        public static stRoundInfo RoundInfo;
        public static stGameResults GameResults;

        public enum enWinner { Player1, Computer, Draw }
        public enum enGameChoice { Rock = 1, Paper = 2, Scissors = 3 }
        public struct stRoundInfo
        {
            public short RoundNumber;
            public enGameChoice Player1Choice;
            public enGameChoice ComputerChoice;
            public enWinner Winner;
            public string WinnerName;
        }
        public struct stGameResults
        {
            public short GameRounds;
            public short Player1WinTimes;
            public short Computer2WinTimes;
            public short DrawTime;
            public enWinner GameWinner;
            public string WinnerName;
        }

        //void changeTheRoundNumber()
        //{

        //    if (Counter < Rounds)
        //    {
        //        Counter++;
        //        lb_Round.Text = Counter.ToString();


        //    }
        //    else
        //        this.Close();
        //}

        void TransferToResultForm()
        {
            if (currentRound <= totalRounds)
            {
                this.Hide();
                Form3 form3 = new Form3(totalRounds, currentRound, this);
                form3.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("No more rounds left!");
                this.Close();
            }

        }

        void GetWinner()
        {
            if (RoundInfo.ComputerChoice == RoundInfo.Player1Choice)
            {
                RoundInfo.Winner = enWinner.Draw;
                RoundInfo.WinnerName = "Draw";
                GameResults.DrawTime++;
                //lb_Draw.Text = GameResults.DrawTime.ToString();
                TransferToResultForm();
                return;
            }
            switch (RoundInfo.Player1Choice)
            {
                case enGameChoice.Rock:
                    if (RoundInfo.ComputerChoice == enGameChoice.Paper)
                    {
                        RoundInfo.Winner = enWinner.Computer;
                        RoundInfo.WinnerName = "Computer";
                        GameResults.Computer2WinTimes++;
                       // lb_Lost.Text = GameResults.Computer2WinTimes.ToString();
                        TransferToResultForm();
                        return;
                    }
                    break;
                case enGameChoice.Paper:
                    if (RoundInfo.ComputerChoice == enGameChoice.Scissors)
                    {
                        RoundInfo.Winner = enWinner.Computer;
                        RoundInfo.WinnerName = "Computer";
                        GameResults.Computer2WinTimes++;
                        //lb_Lost.Text = GameResults.Computer2WinTimes.ToString();
                        TransferToResultForm();
                        return;
                    }
                    break;
                case enGameChoice.Scissors:
                    if (RoundInfo.ComputerChoice == enGameChoice.Rock)
                    {
                        RoundInfo.Winner = enWinner.Computer;
                        RoundInfo.WinnerName = "Computer";
                        GameResults.Computer2WinTimes++;
                        //lb_Lost.Text = GameResults.Computer2WinTimes.ToString();
                        TransferToResultForm();
                        return;
                    }
                    break;
            }
            RoundInfo.Winner = enWinner.Player1;
            RoundInfo.WinnerName = "Player1";
            GameResults.Player1WinTimes++;
           // lb_Won.Text = GameResults.Player1WinTimes.ToString();
            TransferToResultForm();
        }

        void PlayGame(Button btn)
        {
            Random random = new Random();

            if (btn.Tag.ToString() == "Scissors")
            {
                RoundInfo.Player1Choice = enGameChoice.Scissors;     
            }
            else if (btn.Tag.ToString() == "Rock")
            {
                RoundInfo.Player1Choice = enGameChoice.Rock;              
            }
            else
            {
                RoundInfo.Player1Choice = enGameChoice.Paper;            
            }

            RoundInfo.ComputerChoice = (enGameChoice)random.Next(1, 3);
            GameResults.GameRounds++;
            GetWinner();

        }

        private void button_Click(object sender, EventArgs e)
        {
            PlayGame((Button)sender);

        }

    }
}
