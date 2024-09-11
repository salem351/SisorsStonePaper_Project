namespace ScissorsStonePaper_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Round = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Draw = new System.Windows.Forms.Label();
            this.lb_Lost = new System.Windows.Forms.Label();
            this.lb_Won = new System.Windows.Forms.Label();
            this.button_Paper = new System.Windows.Forms.Button();
            this.button_Rock = new System.Windows.Forms.Button();
            this.button_Sc = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(441, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 72);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chose : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(886, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Round : ";
            // 
            // lb_Round
            // 
            this.lb_Round.AutoSize = true;
            this.lb_Round.BackColor = System.Drawing.Color.Transparent;
            this.lb_Round.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Round.ForeColor = System.Drawing.Color.Black;
            this.lb_Round.Location = new System.Drawing.Point(1047, 97);
            this.lb_Round.Name = "lb_Round";
            this.lb_Round.Size = new System.Drawing.Size(55, 45);
            this.lb_Round.TabIndex = 14;
            this.lb_Round.Text = "0 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(865, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 45);
            this.label5.TabIndex = 16;
            this.label5.Text = "Draw : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(663, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 45);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lost : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(460, 625);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "Won : ";
            // 
            // lb_Draw
            // 
            this.lb_Draw.AutoSize = true;
            this.lb_Draw.BackColor = System.Drawing.Color.Transparent;
            this.lb_Draw.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Draw.ForeColor = System.Drawing.Color.Black;
            this.lb_Draw.Location = new System.Drawing.Point(971, 625);
            this.lb_Draw.Name = "lb_Draw";
            this.lb_Draw.Size = new System.Drawing.Size(52, 45);
            this.lb_Draw.TabIndex = 19;
            this.lb_Draw.Text = "0 ";
            // 
            // lb_Lost
            // 
            this.lb_Lost.AutoSize = true;
            this.lb_Lost.BackColor = System.Drawing.Color.Transparent;
            this.lb_Lost.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lost.ForeColor = System.Drawing.Color.Black;
            this.lb_Lost.Location = new System.Drawing.Point(752, 625);
            this.lb_Lost.Name = "lb_Lost";
            this.lb_Lost.Size = new System.Drawing.Size(52, 45);
            this.lb_Lost.TabIndex = 20;
            this.lb_Lost.Text = "0 ";
            // 
            // lb_Won
            // 
            this.lb_Won.AutoSize = true;
            this.lb_Won.BackColor = System.Drawing.Color.Transparent;
            this.lb_Won.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Won.ForeColor = System.Drawing.Color.Black;
            this.lb_Won.Location = new System.Drawing.Point(560, 625);
            this.lb_Won.Name = "lb_Won";
            this.lb_Won.Size = new System.Drawing.Size(52, 45);
            this.lb_Won.TabIndex = 21;
            this.lb_Won.Text = "0 ";
            // 
            // button_Paper
            // 
            this.button_Paper.BackColor = System.Drawing.Color.Transparent;
            this.button_Paper.BackgroundImage = global::SisorsStonePaper_Project.Properties.Resources.Paper;
            this.button_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Paper.Location = new System.Drawing.Point(796, 226);
            this.button_Paper.Name = "button_Paper";
            this.button_Paper.Size = new System.Drawing.Size(290, 286);
            this.button_Paper.TabIndex = 12;
            this.button_Paper.Tag = "Paper";
            this.button_Paper.UseVisualStyleBackColor = false;
            this.button_Paper.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Rock
            // 
            this.button_Rock.BackColor = System.Drawing.Color.Transparent;
            this.button_Rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Rock.BackgroundImage")));
            this.button_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Rock.Location = new System.Drawing.Point(437, 226);
            this.button_Rock.Name = "button_Rock";
            this.button_Rock.Size = new System.Drawing.Size(290, 286);
            this.button_Rock.TabIndex = 11;
            this.button_Rock.Tag = "Rock";
            this.button_Rock.UseVisualStyleBackColor = false;
            this.button_Rock.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Sc
            // 
            this.button_Sc.BackColor = System.Drawing.Color.Transparent;
            this.button_Sc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Sc.BackgroundImage")));
            this.button_Sc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Sc.Location = new System.Drawing.Point(87, 226);
            this.button_Sc.Name = "button_Sc";
            this.button_Sc.Size = new System.Drawing.Size(290, 286);
            this.button_Sc.TabIndex = 10;
            this.button_Sc.Tag = "Scissors";
            this.button_Sc.UseVisualStyleBackColor = false;
            this.button_Sc.Click += new System.EventHandler(this.button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1165, 761);
            this.Controls.Add(this.lb_Won);
            this.Controls.Add(this.lb_Lost);
            this.Controls.Add(this.lb_Draw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Round);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Paper);
            this.Controls.Add(this.button_Rock);
            this.Controls.Add(this.button_Sc);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Play Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Sc;
        private System.Windows.Forms.Button button_Rock;
        private System.Windows.Forms.Button button_Paper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Round;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Draw;
        private System.Windows.Forms.Label lb_Lost;
        private System.Windows.Forms.Label lb_Won;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}