using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_To
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private Label label1_1;
        private void Form1_Load(object sender, EventArgs e)
        {
            genlab(50, 50);
            genlab(150, 50);
            genlab(250, 50);
            genlab(50, 150);
            genlab(150, 150);
            genlab(250, 150);
            genlab(50, 250);
            genlab(150, 250);
            genlab(250, 250);
        }
        private void genlab(int x, int y)
        {
            Label label1_1 = new Label();
            label1_1.Text = "";
            label1_1.Font = new Font("Arial", 60, FontStyle.Bold);
            label1_1.TextAlign = ContentAlignment.MiddleCenter;
            label1_1.Width = 100;
            label1_1.Height = 100;
            label1_1.BackColor = Color.Transparent;
            label1_1.Left = x;
            label1_1.Top = y;
            label1_1.Click += new EventHandler(LB_Click);
            this.Controls.Add(label1_1);
        }

        protected void LB_Click(object sender, EventArgs e)
        {
            Label lab = sender as Label;
            lab.Text = "X";  
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            // von oben nach unten
            e.Graphics.DrawLine(pen, 150, 50, 150, 350);
            e.Graphics.DrawLine(pen, 250, 50, 250, 350);
            //von links nach rechts
            e.Graphics.DrawLine(pen, 50, 150, 350, 150);
            e.Graphics.DrawLine(pen, 50, 250, 350, 250);

            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            label1.Text = "x:" + Control.MousePosition.X.ToString() + " y:" + Control.MousePosition.Y.ToString();
        }
    }
}
