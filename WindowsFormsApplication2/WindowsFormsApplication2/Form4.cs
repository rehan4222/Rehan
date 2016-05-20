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
    public partial class Multiple_height : Form
    {
        Label[] arr_label;
        int perpendicular = 0;
        Point loc;
        double b;
        double[] _angle;
        TextBox[] arr_text;
        public Multiple_height()
        {
            InitializeComponent();
        }
        public void generate_textbox(int _bases)
        {
            loc = label5.Location;
            arr_text = new TextBox[_bases];
            for (int i = 0; i < _bases; i++)
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
        public void generate_label(int _label)
        {


            loc = label5.Location;
            arr_label = new Label[_label];
            for (int i = 0; i < _label; i++)
            {
                if (i == 0)
                {
                    arr_label[i] = new Label();
                    arr_label[i].Name = "mrh " + i;
                    arr_label[i].Location = new Point(loc.X - 50, loc.Y + 30);
                    arr_label[i].Text = (i + 1).ToString();
                    this.Controls.Add(arr_label[i]);
                }
                else
                {
                    arr_label[i] = new Label();
                    arr_label[i].Name = "mrh " + i;
                    arr_label[i].Text = (i + 1).ToString();
                    arr_label[i].Location = new Point(arr_label[i - 1].Location.X, arr_label[i - 1].Location.Y + (30));
                    this.Controls.Add(arr_label[i]);
                }
            }
        }
        public double get_angle(double p, double _base)
        {
            double result;
            double angle_value;
            angle_value =  (Math.Tan(_base));
            result = p * angle_value;
            return Math.Abs (result);
}


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                perpendicular = Convert.ToInt32(no_of_angle.Text);
                generate_textbox(perpendicular);
                generate_label(perpendicular);
                b = Convert.ToDouble(Mul_height_base.Text);
                _angle = new double[perpendicular];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < perpendicular; i++)
                {
                    _angle[i] = Convert.ToDouble(arr_text[i].Text);

                    MessageBox.Show("Answer for Height " + _angle[i] + " is " + get_angle(b, _angle[i]).ToString() + " m ");
                    //  label3.Text = ("Answer for Height " + _angle[i] + " is " + get_angle(b, _angle[i]) + " m ");
                }
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.ToString());
            }

        }
    }
}
