namespace SisorsStonePaper_Project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_PlayerWon = new System.Windows.Forms.Label();
            this.label_ComputerWon = new System.Windows.Forms.Label();
            this.label_DrawWon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(398, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Board Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player1 Won";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "Draw Won";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Computer Won";
            // 
            // label_PlayerWon
            // 
            this.label_PlayerWon.AutoSize = true;
            this.label_PlayerWon.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayerWon.Location = new System.Drawing.Point(148, 263);
            this.label_PlayerWon.Name = "label_PlayerWon";
            this.label_PlayerWon.Size = new System.Drawing.Size(55, 57);
            this.label_PlayerWon.TabIndex = 5;
            this.label_PlayerWon.Text = "0";
            // 
            // label_ComputerWon
            // 
            this.label_ComputerWon.AutoSize = true;
            this.label_ComputerWon.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ComputerWon.Location = new System.Drawing.Point(546, 263);
            this.label_ComputerWon.Name = "label_ComputerWon";
            this.label_ComputerWon.Size = new System.Drawing.Size(55, 57);
            this.label_ComputerWon.TabIndex = 6;
            this.label_ComputerWon.Text = "0";
            // 
            // label_DrawWon
            // 
            this.label_DrawWon.AutoSize = true;
            this.label_DrawWon.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DrawWon.Location = new System.Drawing.Point(944, 263);
            this.label_DrawWon.Name = "label_DrawWon";
            this.label_DrawWon.Size = new System.Drawing.Size(55, 57);
            this.label_DrawWon.TabIndex = 7;
            this.label_DrawWon.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 53);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1322, 675);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_DrawWon);
            this.Controls.Add(this.label_ComputerWon);
            this.Controls.Add(this.label_PlayerWon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_PlayerWon;
        private System.Windows.Forms.Label label_ComputerWon;
        private System.Windows.Forms.Label label_DrawWon;
        private System.Windows.Forms.Label label8;
    }
}