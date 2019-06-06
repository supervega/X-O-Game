namespace _X_O_Game
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.RBComputerFirst = new System.Windows.Forms.RadioButton();
            this.RBHumanFirst = new System.Windows.Forms.RadioButton();
            this.RBXHuman = new System.Windows.Forms.RadioButton();
            this.RBXComputer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.Color.Black;
            this.PanelGame.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.PanelGame.Location = new System.Drawing.Point(12, 12);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(397, 397);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGame_Paint);
            this.PanelGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelGame_MouseClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(496, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.Location = new System.Drawing.Point(415, 84);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(99, 54);
            this.BtnNewGame.TabIndex = 2;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // RBComputerFirst
            // 
            this.RBComputerFirst.AutoSize = true;
            this.RBComputerFirst.Checked = true;
            this.RBComputerFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBComputerFirst.ForeColor = System.Drawing.Color.White;
            this.RBComputerFirst.Location = new System.Drawing.Point(415, 195);
            this.RBComputerFirst.Name = "RBComputerFirst";
            this.RBComputerFirst.Size = new System.Drawing.Size(92, 36);
            this.RBComputerFirst.TabIndex = 3;
            this.RBComputerFirst.TabStop = true;
            this.RBComputerFirst.Text = "Computer\r\nFirst";
            this.RBComputerFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBComputerFirst.UseVisualStyleBackColor = true;
            // 
            // RBHumanFirst
            // 
            this.RBHumanFirst.AutoSize = true;
            this.RBHumanFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHumanFirst.ForeColor = System.Drawing.Color.White;
            this.RBHumanFirst.Location = new System.Drawing.Point(415, 247);
            this.RBHumanFirst.Name = "RBHumanFirst";
            this.RBHumanFirst.Size = new System.Drawing.Size(74, 36);
            this.RBHumanFirst.TabIndex = 4;
            this.RBHumanFirst.Text = "Human\r\nFirst";
            this.RBHumanFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBHumanFirst.UseVisualStyleBackColor = true;
            // 
            // RBXHuman
            // 
            this.RBXHuman.AutoSize = true;
            this.RBXHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBXHuman.ForeColor = System.Drawing.Color.White;
            this.RBXHuman.Location = new System.Drawing.Point(415, 351);
            this.RBXHuman.Name = "RBXHuman";
            this.RBXHuman.Size = new System.Drawing.Size(74, 36);
            this.RBXHuman.TabIndex = 6;
            this.RBXHuman.Text = "X for\r\nHuman";
            this.RBXHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBXHuman.UseVisualStyleBackColor = true;
            this.RBXHuman.CheckedChanged += new System.EventHandler(this.RBXHuman_CheckedChanged);
            // 
            // RBXComputer
            // 
            this.RBXComputer.AutoSize = true;
            this.RBXComputer.Checked = true;
            this.RBXComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBXComputer.ForeColor = System.Drawing.Color.White;
            this.RBXComputer.Location = new System.Drawing.Point(415, 299);
            this.RBXComputer.Name = "RBXComputer";
            this.RBXComputer.Size = new System.Drawing.Size(92, 36);
            this.RBXComputer.TabIndex = 5;
            this.RBXComputer.TabStop = true;
            this.RBXComputer.Text = "X for\r\nComputer";
            this.RBXComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBXComputer.UseVisualStyleBackColor = true;
            this.RBXComputer.CheckedChanged += new System.EventHandler(this.RBXComputer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(526, 420);
            this.Controls.Add(this.RBXHuman);
            this.Controls.Add(this.RBXComputer);
            this.Controls.Add(this.RBHumanFirst);
            this.Controls.Add(this.RBComputerFirst);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PanelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.RadioButton RBComputerFirst;
        private System.Windows.Forms.RadioButton RBHumanFirst;
        private System.Windows.Forms.RadioButton RBXHuman;
        private System.Windows.Forms.RadioButton RBXComputer;
    }
}

