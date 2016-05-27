using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
        bool btnPress = false, btnTri = false;
        float _hypVar; // = 150.0F;
        SolidBrush brush;
        int angle1;
        int angle_value1;
        double p;
        double ba;
        double result;
        Graphics paper;
        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Blue);
            label7.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PointF point5 = new PointF(500.0F, 250.0F);
            //PointF point6 = new PointF(300.0F, 250.0F);
            //PointF point7 = new PointF(500.0F, 100.0F);
            
            if (btnPress == true)
            {
                
                int x = 0;
                while (x != 1)
                {
                    for (int i = 0; i < 300; i++)
                    {
                        label4.Location = new Point(i, 270);
                        //Thread.Sleep(5);
                    }
                    for (int i = 0; i < 330; i++)
                    {
                        label5.Location = new Point(i, 240 - Convert.ToInt32(_hypVar));
                    }
                    for (int i = 0; i < 520; i++)
                    {
                        label6.Location = new Point(i, 210 + Convert.ToInt32(_hypVar / 8));
                    }
                    x++;
                }


                btnPress = false;
                this.Invalidate();
                   timer1.Stop();
                timer1.Enabled = false;
            }
                //timer1.Stop();

        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            try
            {
                _hypVar = float.Parse(tb_angle.Text.ToString()); //_agnle / 5;
            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter The Rite Input");
            }
            
            if (_hypVar>=10 && _hypVar<=140)
            {
                try 
	        {	        
		        label4.Text = tbBase.Text.ToString();
                label6.Text = tbPerpendicular.Text.ToString();
                label5.Text = tbHypotanous.Text.ToString();

                _agnle = 80; //Convert.ToInt16(tb_angle.Text.ToString());
                
                btnPress = true;
                btnTri = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
               // timer1.Enabled = true;
                timer1.Start();
	        }
	        catch (Exception)
	{
		
		MessageBox.Show("plese enter the Rite Values");
	}
               
            }
            else
            {
                MessageBox.Show("Please Enter The Angle Between 10 To 140");
            }
            try
            {
                if (comboBox1.Text == "Distance")
                {
                    p = Convert.ToDouble(tbPerpendicular.Text);
                    angle1 = Convert.ToInt32(tb_angle.Text);
                    angle1 = Convert.ToInt32(angle1 * (180 / Math.PI));
                    angle_value1 = Convert.ToInt32(Math.Tan(angle1));
                    result = p / angle_value1;
                    if (result < 0)
                    {
                        result = (result * -2) - result;
                    }

                    label7.Show();
                    label7.Text = ("Distance is " + result.ToString() + " m ");
                    //MessageBox.Show("The distance is  " + result.ToString() + " m ");
                }
                else if (comboBox1.Text == "Height")
                {
                    angle1 = Convert.ToInt16(tb_angle.Text);
                    ba = Convert.ToDouble(tbBase.Text);
                    angle1 = Convert.ToInt32(angle1 * (180 / Math.PI));
                    angle_value1 = Convert.ToInt16(Math.Round(Math.Tan(angle1)));
                    angle_value1 = Math.Abs(angle_value1);
                    result = ba * angle_value1;
                    label7.Show();
                    label7.Text = ("Height is " + result.ToString() + " m ");
                    // MessageBox.Show("The Height is  " + result.ToString() + " m ");
                }
                else if (comboBox1.Text == "Length")
                {
                    p = Convert.ToDouble(tbPerpendicular.Text);
                    angle1 = Convert.ToInt16(tb_angle.Text);
                    angle1 = Convert.ToInt32(angle1 * (180 / Math.PI));
                    angle_value1 = Convert.ToInt16(Math.Sin(angle1));
                    angle_value1 = Math.Abs(angle_value1);
                    result = p / (angle_value1);
                    label7.Show();
                    label7.Text = ("Length is " + result.ToString() + " m ");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter Correct Values");
            }
            
           
        
        }

        public void drawRec(Graphics paper)
        {
            PointF ab = new PointF(500.0F, 250.0F); // rect right
            PointF bc = new PointF(300.0F, 250.0F); // rect left
            PointF ca;
            if (_hypVar <= 50 && _hypVar >= 0)
            {
                ca = new PointF(500.0F, Math.Abs(250.0F - (float)_hypVar)); // rect up
            }
            else if (_hypVar <= 100 && _hypVar >= 50)
            {
                ca = new PointF(500.0F, Math.Abs(250.0F - (float)_hypVar)); // rect up
            }
            else
            {
                ca = new PointF(500.0F, Math.Abs(250.0F - (float)_hypVar)); // rect up
            }
           
            PointF[] curvePoints = { ca, bc, ab };
            paper.FillPolygon(brush, curvePoints, System.Drawing.Drawing2D.FillMode.Alternate); 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            if (btnTri)
            {
                drawRec(paper);
                //this.Invalidate();
                
               
            }
   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
