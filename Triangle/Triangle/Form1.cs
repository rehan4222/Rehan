using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        int _base, _per, _hyp;
        bool btnPress = false;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Blue);
        }

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
                        tbBase.Location = new Point(i, 270);
                    }
                    for (int i = 0; i < 360; i++)
                    {
                        tbHypotanous.Location = new Point(i, 100);
                    }
                    for (int i = 0; i < 520; i++)
                    {
                        tbPerpendicular.Location = new Point(i, 170);
                    }
                    x++;
                }




                timer1.Stop();
            }
            
        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            _base = Convert.ToInt32(tbBase.Text);
            _per = Convert.ToInt32(tbPerpendicular.Text);
            _hyp = Convert.ToInt32(tbHypotanous.Text);
            btnPress = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PointF point5 = new PointF(500.0F, 250.0F);
            PointF point6 = new PointF(300.0F, 250.0F);
            PointF point7 = new PointF(500.0F, 100.0F);
            PointF[] curvePoints = { point7, point6, point5 };
            e.Graphics.FillPolygon(brush, curvePoints, System.Drawing.Drawing2D.FillMode.Alternate);
        }

        
    }
}
