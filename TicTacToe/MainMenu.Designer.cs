namespace TicTacToe
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVsCpu = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            // 
            // btnVsCpu
            // 
            this.btnVsCpu.Location = new System.Drawing.Point(92, 129);
            this.btnVsCpu.Name = "btnVsCpu";
            this.btnVsCpu.Size = new System.Drawing.Size(161, 42);
            this.btnVsCpu.TabIndex = 1;
            this.btnVsCpu.Text = "VS CPU";
            this.btnVsCpu.UseVisualStyleBackColor = true;
            // 
            // btn2Player
            // 
            this.btn2Player.Location = new System.Drawing.Point(92, 177);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(161, 42);
            this.btn2Player.TabIndex = 2;
            this.btn2Player.Text = "2 Player";
            this.btn2Player.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(92, 227);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(161, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(92, 275);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(161, 42);
            this.btnCredits.TabIndex = 4;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(92, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnVsCpu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(352, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btn2Player);
            this.Controls.Add(this.btnVsCpu);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVsCpu;
        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnExit;
    }
}

