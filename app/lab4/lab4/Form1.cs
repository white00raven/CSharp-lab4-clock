using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            DateTime dt = DateTime.Now;
            Pen cir_Pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Indigo);
            Graphics g = e.Graphics;
            GraphicsState gs, gs1, gs2, gs3, gs4;
            g.TranslateTransform(800 / 2, 800 / 2);
            g.ScaleTransform(600 / 200, 600 / 200);
            g.DrawEllipse(cir_Pen, -100, -100, 200, 200);
            for (int i = 0; i < 12; i++)
            {
                gs3 = g.Save();
                g.RotateTransform(30 * i);
                g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), 0, -90, 0, -100);
                g.Restore(gs3);
            }
            for (int i = 0; i < 60; i++)
            {
                gs3 = g.Save();
                g.RotateTransform(6 * i);
                g.DrawLine(new Pen(new SolidBrush(Color.Black), 1), 0, -95, 0, -100);
                g.Restore(gs3);
            }
            gs = g.Save();
            g.RotateTransform(6 * (dt.Minute + (float)dt.Second / 60));
            g.DrawLine(new Pen(new SolidBrush(Color.Green), 2), 0, -5, 0, -70);
            g.Restore(gs);
            gs1 = g.Save();
            g.RotateTransform(9 * dt.Second);
            g.DrawLine(new Pen(new SolidBrush(Color.Red), 2), 0, -5, 0, -95);
            g.Restore(gs1);
            gs2 = g.Save();
            g.RotateTransform(30 * (dt.Hour + (float)dt.Minute / 60 + (float)dt.Second / 3600));
            g.DrawLine(new Pen(new SolidBrush(Color.Gold), 2), 0, -5, 0, -50);
            g.Restore(gs2);
            g.DrawEllipse(cir_Pen, -3,-3, 6, 6);
            g.DrawEllipse(cir_Pen, -120, -120, 240, 240);
            for (int i = 0; i < 12; i++)
            {
                gs3 = g.Save();
                g.RotateTransform(30 * i);
                g.DrawLine(new Pen(new SolidBrush(Color.Black), 2), 0, -100, 0, -120);
                g.Restore(gs3);
            }
            g.DrawString(Convert.ToString(dt.Day),new Font("Arial",8F),(new SolidBrush(Color.Black)), -80,-5); g.DrawString(".", new Font("Arial", 8F), (new SolidBrush(Color.Black)), -65, -5);
            g.DrawString(Convert.ToString(dt.Month), new Font("Arial", 8F), (new SolidBrush(Color.Black)), -60, -5); g.DrawString(".", new Font("Arial", 8F), (new SolidBrush(Color.Black)), -45, -5);
            g.DrawString(Convert.ToString(dt.Year), new Font("Arial", 8F), (new SolidBrush(Color.Black)), -40, -5);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered=true;
            Height = 900;
            Width = 900;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
this.Invalidate();
        }
    }
}
