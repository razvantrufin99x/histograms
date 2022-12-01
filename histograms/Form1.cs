using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace histograms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Font font0;
        public Pen pen0 = new Pen(Color.Black);
        public Pen pen1 = new Pen(Color.Black, 7);
        public Pen pen2 = new Pen(Color.Red, 10);
        public Brush brush0 = new SolidBrush(Color.Black);
        public float cx, cy, px, py;
        public float step = 5.0f;
        public const double g2r = 180 / Math.PI;
        public int ismd = 0;
        public int su = 0;
        public int eu = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            font0 = this.Font;
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }
        public void drawBar(int x, int bx,int by)
        {
            for(int i = 1; i<x ; i+=5)
            {
                g.DrawLine(pen2, bx, by, bx, by - i);
                Thread.Sleep(50);
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            


        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            g.Clear(BackColor);
            drawBar(75, 10, 100);
            drawBar(60, 30, 100);
            drawBar(15, 50, 100);
            drawBar(100, 70, 100);
            
        }
    }
}
