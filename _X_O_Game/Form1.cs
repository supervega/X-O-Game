using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _X_O_Game
{
    public partial class Form1 : Form
    {
        Core GameGore;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            GameGore.Initilize();
            GameGore.X_Computer = true;
            if (RBComputerFirst.Checked)
                GameGore.Move(-1,-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGore = new Core();
            GameGore.G = PanelGame.CreateGraphics();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameGore.Distroy();
        }

        private void RBXComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBXComputer.Checked)
                GameGore.X_Computer = true;
        }

        private void RBXHuman_CheckedChanged(object sender, EventArgs e)
        {
            if (RBXHuman.Checked)
                GameGore.X_Computer = false;
        }

        private void PanelGame_MouseClick(object sender, MouseEventArgs e)
        {
            GameGore.Move(e.X, e.Y);
        }

        private void PanelGame_Paint(object sender, PaintEventArgs e)
        {

        }

     

        
    }
}
