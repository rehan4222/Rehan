using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double angle, perpendicular, Base, Hypo, output;
            if (comboBox1.Text=="PBH calculation")
            {
                perpendicular = Convert.ToDouble(textBox3.Text);
                Base = Convert.ToDouble(textBox4.Text);
                Hypo = Convert.ToDouble(textBox5.Text);
                if (comboBox2.Text=="sin")
                {
                    output=perpendicular/Base;
                    textBox2.Text=output.ToString();
                }
                if (comboBox2.Text=="cos")
                {
                    output = Base / Hypo;
                    textBox2.Text = output.ToString();
                }
                if (comboBox2.Text == "tan")
                {
                    output = perpendicular / Hypo;
                    textBox2.Text = output.ToString();
                }
                if (comboBox2.Text == "sec")
                {
                    output = Hypo / Base;
                    textBox2.Text = output.ToString();
                }
                if (comboBox2.Text == "cosec")
                {
                    output = Hypo / Base;
                    textBox2.Text = output.ToString();
                }
                if (comboBox2.Text == "cot")
                {
                    output = Base / Hypo;
                    textBox2.Text = output.ToString();
                }
            }
            if (comboBox1.Text=="theta calculation")
            {
                if (comboBox2.Text=="sin ")
                {
                    int a = 30;
                    textBox1.Text = Convert.ToString (a);
                    textBox2.Text = a.ToString();

                }
            }
            if (comboBox1.Text=="phythagorean identities")
            {
                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "phythagorean identities")
            {
                panel1.Show();
                groupBox2.Show();
            }
            else
            {
                panel1.Hide();
            }
            groupBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label1.Show();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        double p = 0, ba = 0, h = 0, angle = 0;
        private void btn_OK_Dist_Click(object sender, EventArgs e)
        {
            double angle_value,result,angle2,tb,rb;
            try
            {
            ba = Convert.ToDouble(txt_Base.Text);
            h = Convert.ToDouble(txt_Hyp.Text);
            }
            catch (Exception)
            {
                
               
            }
            if (comboBox3.Text == "distance")
            {
                p = Convert.ToDouble(txt_Perpandicular.Text);
                angle = Convert.ToDouble(txt_Angle.Text);
                angle_value = Math.Tan(angle);
                result = p / angle_value;
                txt_result.Text = result.ToString();
            }
            else if (comboBox3.Text=="heigth")
            {
                angle = Convert.ToDouble(txt_Angle.Text);
                ba = Convert.ToDouble(txt_Base.Text);
                angle_value = Math.Tan(angle);
                result = ba * angle_value;
                txt_result.Text = result.ToString();
            }
            else if (comboBox3.Text == "angle")
            {
                if (txt_Hyp.Text=="")
                {
                    ba = Convert.ToDouble(txt_Base.Text);
                    p = Convert.ToDouble(txt_Perpandicular.Text);
                    result = p / ba;
                    result =1/( Math.Tan (result));
                    txt_result.Text = result.ToString();
                }
            }
            else if (comboBox3.Text== "multiple angles")
            {
                p = Convert.ToDouble(txt_Perpandicular.Text);
                angle = Convert.ToDouble(txt_Angle.Text);
                angle2 = Convert.ToDouble(txt_angle2.Text);
                angle_value = Math.Tan(angle);
                tb = p / angle_value;
                angle_value = Math.Tan(angle2);
                rb = p / angle_value;
                result = tb - rb;
                txt_result.Text = result.ToString();
            }
        }
    }
}
//distance
//heigth
//angle
//cos
//tan
//sec
//cosec
//cot
