using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 
            

            Pen blackPen = new Pen(Color.Black);

            float starRotation = 0;
            try
            {
                if (rotateInput.Text != "")
                {
                    starRotation = Convert.ToSingle(rotateInput.Text);
                }
                DrawStar(blackPen, Convert.ToSingle(xInput.Text), Convert.ToSingle(yInput.Text), Convert.ToSingle(sizeInput.Text), starRotation);
            }
            catch
            {

            }

        }


        private void fillButton_Click(object sender, EventArgs e)
        {
            SolidBrush blueFill = new SolidBrush(Color.Blue);

            float starRotation = 0;
            try
            {
                if (rotateInput.Text != "")
                {
                    starRotation = Convert.ToSingle(rotateInput.Text);
                }
                FillStar(blueFill, Convert.ToSingle(xInput.Text), Convert.ToSingle(yInput.Text), Convert.ToSingle(sizeInput.Text), starRotation);
            }
            catch
            {

            }
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels, float rotation = 0)
        {
            Graphics g = this.CreateGraphics();
            PointF[] star = new PointF[10];
            float size;
            for(int i = 0;i < star.Count();i++)
            {
                size = i % 2 == 1 ? pixels / 5 : pixels/2;
                star[i] = new PointF(x + (pixels / 2) + Convert.ToSingle(Math.Sin((36 + rotation + i * 36) / 57.2957795)) * size, y + (pixels / 2) + Convert.ToSingle(Math.Cos((36 + rotation + i * 36) / 57.2957795)) * size);
            }

            g.DrawPolygon(starPen, star);
        }
        public void FillStar(SolidBrush starBrush, float x, float y, float pixels, float rotation = 0)
        {
            Graphics g = this.CreateGraphics();
            PointF[] star = new PointF[10];
            float size;
            for (int i = 0; i < star.Count(); i++)
            {
                size = i % 2 == 1 ? pixels / 5 : pixels / 2;
                star[i] = new PointF(x + (pixels / 2) + Convert.ToSingle(Math.Sin((36 + rotation + i * 36) / 57.2957795)) * size, y + (pixels / 2) + Convert.ToSingle(Math.Cos((36 + rotation + i * 36) / 57.2957795)) * size);
            }

            g.FillPolygon(starBrush, star);
        }

    }
}
