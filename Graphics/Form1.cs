using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Graphics Examples";

            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            
            g.Clear(Color.White);

            //g.DrawLine(redPen, 50, 10, 100, 200);

            //g.DrawRectangle(redPen, 30, 30, 100, 200);
            //g.FillRectangle(blueBrush, 30, 30, 100, 200);

            g.DrawEllipse(blackPen, 20, 20, 210, 210);
            g.FillEllipse(blackBrush, 25, 25, 200, 200);
            g.FillEllipse(whiteBrush, 50, 50, 150, 150);
            g.FillPie(blueBrush, 53, 53, 145, 145, 180, 90);
            g.FillPie(blueBrush, 52, 52, 145, 145, 0, 90);
            g.DrawString("M", drawFont, whiteBrush, 112, 26);
           
            g.TranslateTransform(180, 42);
            g.RotateTransform(45);
            g.DrawString("W", drawFont, whiteBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(50, 60);
            g.RotateTransform(-45);
            g.DrawString("B", drawFont, whiteBrush, 0, 0);
            g.ResetTransform();


            //g.DrawArc(redPen, 250, 20, 50, 50, 30, 300);
            //g.DrawPie(redPen, 250, 20, 50, 50, 140, 60);
            //g.FillPie(blueBrush, 250, 20, 50, 50, 120, 300);

            //g.DrawString("Begin", drawFont, blueBrush, 50, 300);
        }
    }
}
