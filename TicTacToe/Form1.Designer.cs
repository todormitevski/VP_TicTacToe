namespace TicTacToe
{
    partial class Form1
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
            this.playerWins = new System.Windows.Forms.Label();
            this.cpuWins = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerWins
            // 
            this.playerWins.AutoSize = true;
            this.playerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWins.Location = new System.Drawing.Point(21, 20);
            this.playerWins.Name = "playerWins";
            this.playerWins.Size = new System.Drawing.Size(75, 13);
            this.playerWins.TabIndex = 0;
            this.playerWins.Text = "Player wins:";
            // 
            // cpuWins
            // 
            this.cpuWins.AutoSize = true;
            this.cpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuWins.Location = new System.Drawing.Point(256, 20);
            this.cpuWins.Name = "cpuWins";
            this.cpuWins.Size = new System.Drawing.Size(62, 13);
            this.cpuWins.TabIndex = 0;
            this.cpuWins.Text = "Cpu wins:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 86);
            this.button3.TabIndex = 1;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 86);
            this.button4.TabIndex = 1;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 86);
            this.button5.TabIndex = 1;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(224, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 86);
            this.button6.TabIndex = 1;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 86);
            this.button7.TabIndex = 1;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(124, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 86);
            this.button8.TabIndex = 1;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(224, 245);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 86);
            this.button9.TabIndex = 1;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 387);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpuWins);
            this.Controls.Add(this.playerWins);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerWins;
        private System.Windows.Forms.Label cpuWins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

