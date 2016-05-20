using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int angles;
        TextBox[] arr_text;
        Label[] arr_label;
        Point loc;
        double p;
        double[] angle;
       
        public void generate_text_box(int _angles)
        {
            try
            {
                loc = label5.Location;
                arr_text = new TextBox[_angles];
                for (int i = 0; i < _angles; i++)
                {
                    if (i == 0)
                    {
                        arr_text[i] = new TextBox();
                        arr_text[i].Name = "mrh " + i;
                        arr_text[i].Location = new Point(loc.X, loc.Y + 30);
                        this.Controls.Add(arr_text[i]);
                    }
                    else
                    {
                        arr_text[i] = new TextBox();
                        arr_text[i].Name = "mrh " + i;
                        arr_text[i].Location = new Point(arr_text[i - 1].Location.X, arr_text[i - 1].Location.Y + (30));
                        this.Controls.Add(arr_text[i]);
                    }
                }
            }
            catch (IndexOutOfRangeException ee)
            {
                MessageBox.Show(ee.ToString());
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        public void generate_label(int _label)
        {
            try
            {
                loc = label5.Location;
                arr_label = new Label[_label];
                for (int i = 0; i < _label; i++)
                {
                    if (i == 0)
                    {
                        arr_label[i] = new Label();
                        arr_label[i].Name = "mrh " + i;
                        arr_label[i].Location = new Point(loc.X-50, loc.Y+30);
                        arr_label[i].Text=(i+1).ToString();
                        this.Controls.Add(arr_label[i]);
                    }
                    else
                    {
                        arr_label[i] = new Label();
                        arr_label[i].Name = "mrh " + i;
                        arr_label[i].Text = (i+1).ToString();
                        arr_label[i].Location = new Point(arr_label[i - 1].Location.X, arr_label[i - 1].Location.Y + (30));
                        this.Controls.Add(arr_label[i]);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        public double get_distance(double p, double angle)
        {
            double result;
            double angle_value;
            angle_value = Math.Tan(angle);
            result = p / angle_value;
            return Math.Abs (result);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < angles; i++)
                {
                    angle[i] = Convert.ToDouble(arr_text[i].Text);

                    MessageBox.Show("Answer for angle " + angle[i] + " is " + get_distance(p, angle[i]).ToString() + " m ");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                angles = Convert.ToInt32(textBox4.Text);
                generate_text_box(angles);
                generate_label(angles);
                p = Convert.ToDouble(textBox1.Text);
                angle = new double[angles];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
 
        private void button3_Click(object sender, EventArgs e)
        {
            angles = Convert.ToInt32(textBox4.Text);
            generate_text_box(angles);
            p = Convert.ToDouble(textBox1.Text);
        }
            
}


    
    


}
