namespace ScissorsStonePaper_Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lb_Won = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Player1 = new System.Windows.Forms.Button();
            this.btn_Computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Won
            // 
            resources.ApplyResources(this.lb_Won, "lb_Won");
            this.lb_Won.BackColor = System.Drawing.Color.Transparent;
            this.lb_Won.ForeColor = System.Drawing.Color.Black;
            this.lb_Won.Name = "lb_Won";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Name = "label5";
            // 
            // btn_Player1
            // 
            this.btn_Player1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Player1, "btn_Player1");
            this.btn_Player1.Name = "btn_Player1";
            this.btn_Player1.UseVisualStyleBackColor = false;
            // 
            // btn_Computer
            // 
            this.btn_Computer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Computer.BackgroundImage = global::SisorsStonePaper_Project.Properties.Resources.Paper;
            resources.ApplyResources(this.btn_Computer, "btn_Computer");
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Player1);
            this.Controls.Add(this.btn_Computer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Won);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Won;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Computer;
        private System.Windows.Forms.Button btn_Player1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}