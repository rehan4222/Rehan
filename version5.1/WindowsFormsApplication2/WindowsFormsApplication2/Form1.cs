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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            combo_MultiAngles_options.Hide();
           label9.Hide();
            rad_PBH.Checked = true;
            rad_Cdistance.Hide();
            Rad_Rdistance.Hide();
            rad_covered_height.Hide();
            rad_remaining_height.Hide();
            rd_covered_length.Hide();
            rd_remaining_lengthM.Hide();
            rd_first_angle.Hide();
            rd_second_angle.Hide();
            label17.Hide();
            label13.Hide();
            label12.Hide();
            label14.Hide();
            label15.Hide();
            txt_angle2.Hide();
            txt_Angle.Hide();
            txt_angle2.Hide();
            txt_Base.Hide();
            txt_Hyp.Hide();
            txt_Perpandicular.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            result_label1.Hide();
            result_label.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double perpendicular, Base, Hypo, output;
            //int angle;
            try
            {
                if (rad_PBH.Checked == true)
                {
                    perpendicular = Convert.ToDouble(textBox3.Text);
                    Base = Convert.ToDouble(textBox4.Text);
                    Hypo = Convert.ToDouble(textBox5.Text);
                    if (comboBox2.Text == "sin")
                    {
                        output = perpendicular / Base;
                        result_label.Show();
                        result_label.Text = ("Value of sin  is " + output.ToString() + " m ");
                    }
                    if (comboBox2.Text == "cos")
                    {
                        output = Base / Hypo;
                        result_label.Show();
                        result_label.Text = ("Value of cos  is " + output.ToString() + " m ");
                    }
                    if (comboBox2.Text == "tan")
                    {
                        output = perpendicular / Hypo;
                        result_label.Show();
                        result_label.Text = ("Value of Tan  is " + output.ToString() + " m ");
                    }
                    if (comboBox2.Text == "sec")
                    {
                        output = Hypo / Base;
                        result_label.Show();
                        result_label.Text = ("Value of Sec  is " + output.ToString() + " m ");
                    }
                    if (comboBox2.Text == "cosec")
                    {
                        output = Hypo / Base;
                        result_label.Show();
                        result_label.Text = ("Value of cosec  is " + output.ToString() + " m ");
                    }
                    if (comboBox2.Text == "cot")
                    {
                        output = Base / Hypo;
                        result_label.Show();
                        result_label.Text = ("Value of Cot  is " + output.ToString() + " m ");
                    }
                }


                else if (rad_theta.Checked == true)
                {
                    int a;
                    a = Convert.ToInt32(textBox1.Text);
                    if (comboBox2.Text == "sin")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of sin is  " + Math.Sin(radians).ToString() + " ° ");
                    }
                    else if (comboBox2.Text == "cos")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of Cos is  " + Math.Cos(radians).ToString() + " ° ");
                    }
                    else if (comboBox2.Text == "tan")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of Tan is  " + Math.Tan(radians).ToString() + " ° ");
                    }
                    else if (comboBox2.Text == "cosec")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of Cosec is  " + (1 / Math.Cos(radians)).ToString() + " ° ");
                    }
                    else if (comboBox2.Text == "sec")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of Sec is  " + (1 / Math.Sin(radians)).ToString() + " ° ");
                    }
                    else if (comboBox2.Text == "cot")
                    {
                        a = Math.Abs(a);
                        double radians = a * (Math.PI / 180);
                        result_label.Show();
                        result_label.Text=("Value of Cot is  " + (1 / Math.Tan(radians)).ToString() + " ° ");
                    }
                }

            }
            catch (Exception eee)
            {
                MessageBox.Show("Please Enter The Exact Values");
            }
            
        }
        
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Angles Calculation" || comboBox1.Text=="Distance Calculation")
            {
                button2.Show();
                button3.Show();
                button4.Show();
            }
            if (comboBox1.Text == "Angles Calculation")
            {
                groupBox1.Show();
                groupBox2.Hide();
            }
            if (comboBox1.Text == "Distance Calculation")
            {
                groupBox1.Hide();
                groupBox2.Show();
            }
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
        double p = 0, ba = 0, h = 0; int angle = 0;

        private void btn_OK_Dist_Click_1(object sender, EventArgs e)
        {
            try
            {
                double angle2;
                double angle_value, result, tb, rb, ch, rh;
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
                    angle = Convert.ToInt16(txt_Angle.Text);
                     angle = Convert.ToInt32(angle * (180 / Math.PI));
                    angle_value = Math.Tan(angle);
                    angle_value = Math.Abs(angle_value);
                  result = p / angle_value;
                  result_label1.Show();
                  result_label1.Text = ("The distance is  " + result.ToString() + " m ");

                }
                else if (comboBox3.Text == "heigth")
                {
                    combo_MultiAngles_options.Hide();
                    label9.Hide();
                    angle = Convert.ToInt16(txt_Angle.Text);
                    ba = Convert.ToDouble(txt_Base.Text);
                    angle =Convert.ToInt32( angle * (180 / Math.PI));
                    angle_value = Math.Round(Math.Tan(angle));
                    angle_value = Math.Abs(angle_value);
                    result = ba * angle_value;
                    result_label1.Show();
                    result_label1.Text=("The Height is  " + result.ToString() + " m ");


                }
                else if (comboBox3.Text == "angle")
                {
                    if (txt_Hyp.Text == "")
                    {
                        combo_MultiAngles_options.Hide();
                        label9.Hide();
                        ba = Convert.ToDouble(txt_Base.Text);
                        p = Convert.ToDouble(txt_Perpandicular.Text);
                        result = p / ba;
                        result = result * (180 / Math.PI);
                        result = 1 / (Math.Tan(result));
                        result = Math.Abs(result);
                        result_label1.Show();
                       result_label1.Text=("The Measured angle  is  " + result.ToString() + " ° ");

                    }
                }
                else if (comboBox3.Text == "length")
                {
                    combo_MultiAngles_options.Hide();
                    label9.Hide();
                    p = Convert.ToDouble(txt_Perpandicular.Text);
                    angle = Convert.ToInt16(txt_Angle.Text);
                    angle = Convert.ToInt32( angle * (180 / Math.PI));
                    angle_value = Math.Sin(angle);
                    angle_value = Math.Abs(angle_value);
                    result = p / (angle_value);
                    result_label1.Show();
                   result_label1.Text=("The Measured Length is  " + result.ToString() + " m ");



                }
                else if (comboBox3.Text == "multiple angles")
                {

                    combo_MultiAngles_options.Visible = true;
                    label9.Visible = true;
                    if (combo_MultiAngles_options.Text == "distance")
                    {
                        if (rad_Cdistance.Checked == true)
                        {
                            p = Convert.ToDouble(txt_Perpandicular.Text);
                            angle = Convert.ToInt16(txt_Angle.Text);
                            angle2 = Convert.ToInt16(txt_angle2.Text);
                            angle = Convert.ToInt32(angle * (180 / Math.PI));
                            angle_value = Math.Tan(angle);
                            angle_value = Math.Abs(angle_value);
                            tb = p / angle_value;
                            angle2 = angle2 * (180 / Math.PI);
                            angle_value = Math.Tan(angle2);
                            angle_value = Math.Abs(angle_value);
                            rb = p / angle_value;
                            result = tb - rb;
                            result = Math.Abs(result);
                            result_label1.Show();
                            result_label1.Text=("The  Covered distance is  " + result.ToString() + " m ");
                        }
                        else if (Rad_Rdistance.Checked == true)
                        {
                            p = Convert.ToDouble(txt_Perpandicular.Text);
                            angle = Convert.ToInt16(txt_Angle.Text);
                            angle2 = Convert.ToInt32(txt_angle2.Text);
                            angle2 = angle2 * (180 / Math.PI);
                            angle_value = Math.Tan(angle2);
                            angle_value = Math.Abs(angle_value);
                            rb = p / angle_value;
                            rb = Math.Abs(rb);
                            result_label1.Show();
                           result_label1.Text=("The remaining distance is  " + rb.ToString() + " m ");
                        }

                    }
                    else if (combo_MultiAngles_options.Text == "heigth")
                    {
                        if (rad_covered_height.Checked == true)
                        {
                            ba = Convert.ToDouble(txt_Base.Text);
                            angle = Convert.ToInt32(txt_Angle.Text);
                            angle2 = Convert.ToInt32(txt_angle2.Text);
                            angle = Convert.ToInt32(angle * (3.14 / 180));

                            angle_value = Math.Tan(angle);
                            angle_value = Math.Abs(angle_value);
                            ch = angle_value * ba;
                            angle = Convert.ToInt32(angle * (3.14 / 180));
                            angle2 = angle2 * (180 / Math.PI);
                            angle_value = Math.Tan(angle2);
                            angle_value = Math.Abs(angle_value);
                            rh = angle_value * ba;
                            result = ch - rh;
                            result = Math.Abs(result);
                            result_label1.Show();
                           result_label1.Text=("The Covered Height is  " + result.ToString() + " m ");

                        }
                        else if (rad_remaining_height.Checked == true)
                        {
                            ba = Convert.ToDouble(txt_Base.Text);
                            angle = Convert.ToInt32(txt_Angle.Text);
                            angle2 = Convert.ToInt32(txt_angle2.Text);
                            angle2 = Convert.ToInt32(((angle2 )* (3.14 / 180)));
                            angle_value = Math.Tan(angle2);
                            angle_value = Math.Abs(angle_value);
                            rh = angle_value * ba;
                            rh = Math.Abs(rh);
                            result_label1.Show();
                            result_label1.Text=("The Remaining Height is  " + rh.ToString()+" m ");
                        }
                    }
                    else if (combo_MultiAngles_options.Text == "angle")
                    {
                        if (rd_first_angle.Checked == true)
                        {
                            ba = Convert.ToDouble(txt_Base.Text);
                            p = Convert.ToDouble(txt_Perpandicular.Text);
                            result = p / ba;
                            result = result * (180 / Math.PI);
                            result = 1 / (Math.Tan(result));
                            result = Math.Abs(result);
                            result_label1.Show();
                            result_label1.Text=("The First Angle is  " + result.ToString() + " ° ");
                        }
                        else if (rd_second_angle.Checked == true)
                        {
                            ba = Convert.ToDouble(txt_Base.Text);
                            p = Convert.ToDouble(txt_Perpandicular.Text);
                            h = Convert.ToDouble(txt_Hyp.Text);

                            result = p / ba;
                            result = result * (180 / Math.PI);
                            result = 1 / (Math.Tan(result));
                            result = Math.Abs(result);
                            result = result * (180 / Math.PI);
                            result = Math.Sin(result) * h;
                            result = Math.Abs(result);
                            result = result * (180 / Math.PI);
                            result = 1 / (Math.Sin(result / h));
                            result = Math.Abs(result);
                            result_label1.Show();
                            result_label1.Text=("The Second Angle is  " + result.ToString() + " ° ");

                        }

                    }
                    else if (combo_MultiAngles_options.Text == "length")
                    {
                        if (rd_covered_length.Checked == true)
                        {
                            p = Convert.ToDouble(txt_Perpandicular.Text);
                            //ladderAngle = Convert.ToDouble(txt_Angle.Text);
                            //ladderAngle = Math.Sin(ladderAngle);
                            //result = p / ladderAngle;
                            angle = Convert.ToInt32((txt_Angle.Text));

                            h = Convert.ToDouble(txt_Hyp.Text);
                            angle = Convert.ToInt32(angle * (3.14 / 180));



                        }
                    }

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Please Enter The Appropriate Values");
            }
        }

        private void rad_theta_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_theta.Checked==true)
            {
                groupBox3.Hide();
                groupBox4.Show();
            }
        }

        private void rad_PBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_PBH.Checked==true)
            {
                groupBox3.Show();
                groupBox4.Hide();
            }
        }

        private void btn_OK_Dist_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "distance")
            {
                show_distance_contents();

            }
            else if (comboBox3.Text=="heigth")
            {
                show_height_content();
            }
            else if (comboBox3.Text=="angle")
            {
                show_angle_content();
                
            }
            else if (comboBox3.Text=="length")
            {
                show_length_content();
            }


            else if (comboBox3.Text == "multiple angles")
            {
                combo_MultiAngles_options.Show();
                label9.Show();
                label17.Show();
                txt_angle2.Show();
               
            }
                         
        }
        public void show_distance_contents()
        {
            label12.Show();
            txt_Perpandicular.Show();
            label15.Show();
            txt_Angle.Show();
            txt_angle2.Hide();
            txt_Base.Hide();
            txt_Hyp.Hide();
            label13.Hide();
            label14.Hide();
            label17.Hide();

        }
        public void show_height_content()
        {
            txt_Base.Show();
            txt_Angle.Show();
            label13.Show();
            label15.Show();
            txt_Hyp.Hide();
            txt_Perpandicular.Hide();
            label14.Hide();
            label17.Hide();
            label12.Hide();
            txt_angle2.Hide();
        }
        public void show_angle_content()
        {
            txt_Perpandicular.Show();
            txt_Base.Show();
            label12.Show();
            label13.Show();
            txt_Hyp.Hide();
            txt_angle2.Hide();
            txt_Angle.Hide();
            label15.Hide();
            label17.Hide();
            label14.Hide();


            
            
        }
        public void show_length_content()
        {
            txt_Perpandicular.Show();
            txt_Angle.Show();
            label12.Show();
            label15.Show();
            txt_Hyp.Hide();
            txt_Base.Hide();
            label17.Hide();
            label14.Hide();
            txt_angle2.Hide();
            label13.Hide();
        }
        public void show_distance_multipleangle()
        {
            txt_Perpandicular.Show();
            txt_Angle.Show();
            txt_angle2.Show();
            label12.Show();
            label15.Show();
            label17.Show();
            label13.Hide();
            label14.Hide();
            txt_Base.Hide();
            txt_Hyp.Hide();
           
            rad_Cdistance.Show();
            Rad_Rdistance.Show();
            rad_covered_height.Hide();
            rad_remaining_height.Hide();

        }
        public void show_height_multipleangle()
        {

            txt_Base.Show();
            txt_Angle.Show();
            txt_angle2.Show();
            label13.Show();
            label15.Show();
            label17.Show();
            txt_Hyp.Hide();
            rd_first_angle.Hide();
            rd_second_angle.Hide();
            txt_Perpandicular.Hide();
            label14.Hide();
            label12.Hide();
            rad_covered_height.Show();
            rad_remaining_height.Show();
            rad_Cdistance.Hide();
            Rad_Rdistance.Hide();
}
        public void show_angle_multiple_angle()
        {
            txt_angle2.Hide();
            txt_Perpandicular.Show();
            txt_Base.Show();
            label12.Show();
            label13.Show();
            rd_first_angle.Show();
            rd_second_angle.Show();
            label14.Show();
            rad_covered_height.Hide();
            rad_remaining_height.Hide();
            txt_Angle.Hide();
            rad_Cdistance.Hide();
            Rad_Rdistance.Hide();
            label15.Hide();
            label17.Hide();
            
            txt_Hyp.Show();
            rd_covered_length.Hide();
            rd_remaining_lengthM.Hide();

        }

        private void combo_MultiAngles_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_MultiAngles_options.Text=="distance")
            {
                rad_Cdistance.Show();
                Rad_Rdistance.Show();
                show_distance_multipleangle();
            }
            else if (combo_MultiAngles_options.Text=="heigth")
            {
                show_height_multipleangle();
            }
            else if (combo_MultiAngles_options.Text=="angle")
            {
                show_angle_multiple_angle();
            }        
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiple_Angle obj = new Multiple_Angle();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Multiple_height obj = new Multiple_height();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SIMULATION obj = new SIMULATION();
            //obj.Show();
            Triangle.Form1 obj = new Triangle.Form1();
            obj.Show();
        }
    }
}

