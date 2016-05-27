using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Triangle
{
    public partial class Form1 : Form
    {
        int _base, _per, _hyp;
        int _agnle;
        bool btnPress = false;
        float _hypVar; // = 150.0F;
        SolidBrush brush;
        Graphics paper;
        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Blue);
        }
        int y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //PointF point5 = new PointF(500.0F, 250.0F);
            //PointF point6 = new PointF(300.0F, 250.0F);
            //PointF point7 = new PointF(500.0F, 100.0F);
            int x = 0;
            if (btnPress == true)
            {

                while (x !=1)
                {
                    for (int i = 0; i < 300; i++)
                    {
                        lbbase.Location = new Point(i, 270);
                    }
                    for (int i = 0; i < 360; i++)
                    {
                        labhyp.Location = new Point(i, 100);
                    }
                    for (int i = labhyp.Location.Y; i < y; i++)
                    {
                        labhyp.Location = new Point(labhyp.Location.X, i);
                    }
                    for (int i = 0; i < 520; i++)
                    {
                        lbperpen.Location = new Point(i, 170);
                    }

                    x++;
                }




                timer1.Stop();
            }
            
        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            _hypVar = float.Parse(tb_angle.Text.ToString()); //_agnle / 5;
            if (_hypVar >= 10 &&_hypVar <= 140)
            {

                try
                {
                    _base = Convert.ToInt32(tbBase.Text);
                    _per = Convert.ToInt32(tbPerpendicular.Text);
                    _hyp = Convert.ToInt32(tbHypotanous.Text);
                    lbbase.Text = _base.ToString();
                    lbperpen.Text = _per.ToString();
                    labhyp.Text = _hyp.ToString();
                    tbBase.Clear();
                    tbPerpendicular.Clear();
                    tbHypotanous.Clear();
                    _agnle = 80; //Convert.ToInt16(tb_angle.Text.ToString());
                    
                    btnPress = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("please enter the rite data");
                }

            }
            else
            {

                MessageBox.Show("please enter angle between 10 to 140");
            }
        }
        Font font = new Font("Arial", 12);
        public void drawRec(Graphics paper)
        {
            PointF ab = new PointF(500.0F, 250.0F);//base right 
            PointF bc = new PointF(300.0F, 250.0F);// base left
            PointF ca = new PointF(500.0F, 100.0F + (float) _hypVar); // base up
            PointF[] curvePoints = { ca, bc, ab };
            paper.FillPolygon(brush, curvePoints, System.Drawing.Drawing2D.FillMode.Alternate);
            y = Convert.ToInt16(ab.Y - labhyp.Location.Y);
            y -= 40;
            y += labhyp.Location.Y;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            if (btnPress)
            {
                drawRec(paper);
                this.Invalidate();
            }
            
            //drawRec(paper);
            //PointF ab = new PointF(500.0F, 250.0F);
            //PointF bc = new PointF(300.0F, 250.0F);
            //PointF ca = new PointF(500.0F, _hypVar);
            //PointF[] curvePoints = { ca, bc, ab };
            //e.Graphics.FillPolygon(brush, curvePoints, System.Drawing.Drawing2D.FillMode.Alternate); 
            
            
            
        }

        
    }
}
