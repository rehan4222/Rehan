namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rad_theta = new System.Windows.Forms.RadioButton();
            this.rad_PBH = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_remaining_lengthM = new System.Windows.Forms.RadioButton();
            this.rd_covered_length = new System.Windows.Forms.RadioButton();
            this.rd_second_angle = new System.Windows.Forms.RadioButton();
            this.rd_first_angle = new System.Windows.Forms.RadioButton();
            this.rad_remaining_height = new System.Windows.Forms.RadioButton();
            this.rad_covered_height = new System.Windows.Forms.RadioButton();
            this.Rad_Rdistance = new System.Windows.Forms.RadioButton();
            this.rad_Cdistance = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_MultiAngles_options = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_OK_Dist = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txt_angle2 = new System.Windows.Forms.TextBox();
            this.txt_Perpandicular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Base = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Angle = new System.Windows.Forms.TextBox();
            this.txt_Hyp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.result_label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Angles Calculation",
            "Distance Calculation"});
            this.comboBox1.Location = new System.Drawing.Point(153, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calculation Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.result_label);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rad_theta);
            this.groupBox1.Controls.Add(this.rad_PBH);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 314);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angles Calculation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "sin",
            "cos",
            "tan",
            "sec",
            "cosec",
            "cot"});
            this.comboBox2.Location = new System.Drawing.Point(539, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Angle";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(387, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 139);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Theta Calculation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 21);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Theta Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(19, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 144);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triangle Values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Base";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 21);
            this.textBox5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hypotenuse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Perpandicular";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 21);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 21);
            this.textBox3.TabIndex = 15;
            // 
            // rad_theta
            // 
            this.rad_theta.AutoSize = true;
            this.rad_theta.Location = new System.Drawing.Point(478, 64);
            this.rad_theta.Name = "rad_theta";
            this.rad_theta.Size = new System.Drawing.Size(158, 17);
            this.rad_theta.TabIndex = 16;
            this.rad_theta.TabStop = true;
            this.rad_theta.Text = "Theta Calculation";
            this.rad_theta.UseVisualStyleBackColor = true;
            this.rad_theta.CheckedChanged += new System.EventHandler(this.rad_theta_CheckedChanged);
            // 
            // rad_PBH
            // 
            this.rad_PBH.AutoSize = true;
            this.rad_PBH.Location = new System.Drawing.Point(98, 64);
            this.rad_PBH.Name = "rad_PBH";
            this.rad_PBH.Size = new System.Drawing.Size(136, 17);
            this.rad_PBH.TabIndex = 15;
            this.rad_PBH.TabStop = true;
            this.rad_PBH.Text = "Triangle Values";
            this.rad_PBH.UseVisualStyleBackColor = true;
            this.rad_PBH.CheckedChanged += new System.EventHandler(this.rad_PBH_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.result_label1);
            this.groupBox2.Controls.Add(this.rd_remaining_lengthM);
            this.groupBox2.Controls.Add(this.rd_covered_length);
            this.groupBox2.Controls.Add(this.rd_second_angle);
            this.groupBox2.Controls.Add(this.rd_first_angle);
            this.groupBox2.Controls.Add(this.rad_remaining_height);
            this.groupBox2.Controls.Add(this.rad_covered_height);
            this.groupBox2.Controls.Add(this.Rad_Rdistance);
            this.groupBox2.Controls.Add(this.rad_Cdistance);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.combo_MultiAngles_options);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_OK_Dist);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.txt_angle2);
            this.groupBox2.Controls.Add(this.txt_Perpandicular);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_Base);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_Angle);
            this.groupBox2.Controls.Add(this.txt_Hyp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(19, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 314);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distance Calculation";
            // 
            // rd_remaining_lengthM
            // 
            this.rd_remaining_lengthM.AutoSize = true;
            this.rd_remaining_lengthM.Location = new System.Drawing.Point(574, 200);
            this.rd_remaining_lengthM.Name = "rd_remaining_lengthM";
            this.rd_remaining_lengthM.Size = new System.Drawing.Size(151, 17);
            this.rd_remaining_lengthM.TabIndex = 46;
            this.rd_remaining_lengthM.TabStop = true;
            this.rd_remaining_lengthM.Text = "Remaining Length";
            this.rd_remaining_lengthM.UseVisualStyleBackColor = true;
            // 
            // rd_covered_length
            // 
            this.rd_covered_length.AutoSize = true;
            this.rd_covered_length.Location = new System.Drawing.Point(406, 200);
            this.rd_covered_length.Name = "rd_covered_length";
            this.rd_covered_length.Size = new System.Drawing.Size(134, 17);
            this.rd_covered_length.TabIndex = 45;
            this.rd_covered_length.TabStop = true;
            this.rd_covered_length.Text = "Covered Length";
            this.rd_covered_length.UseVisualStyleBackColor = true;
            // 
            // rd_second_angle
            // 
            this.rd_second_angle.AutoSize = true;
            this.rd_second_angle.Location = new System.Drawing.Point(574, 174);
            this.rd_second_angle.Name = "rd_second_angle";
            this.rd_second_angle.Size = new System.Drawing.Size(118, 17);
            this.rd_second_angle.TabIndex = 44;
            this.rd_second_angle.TabStop = true;
            this.rd_second_angle.Text = "Second Angle\r\n";
            this.rd_second_angle.UseVisualStyleBackColor = true;
            // 
            // rd_first_angle
            // 
            this.rd_first_angle.AutoSize = true;
            this.rd_first_angle.Location = new System.Drawing.Point(406, 174);
            this.rd_first_angle.Name = "rd_first_angle";
            this.rd_first_angle.Size = new System.Drawing.Size(103, 17);
            this.rd_first_angle.TabIndex = 43;
            this.rd_first_angle.TabStop = true;
            this.rd_first_angle.Text = "First angle";
            this.rd_first_angle.UseVisualStyleBackColor = true;
            // 
            // rad_remaining_height
            // 
            this.rad_remaining_height.AutoSize = true;
            this.rad_remaining_height.Location = new System.Drawing.Point(574, 145);
            this.rad_remaining_height.Name = "rad_remaining_height";
            this.rad_remaining_height.Size = new System.Drawing.Size(148, 17);
            this.rad_remaining_height.TabIndex = 42;
            this.rad_remaining_height.TabStop = true;
            this.rad_remaining_height.Text = "Remaining Height\r\n";
            this.rad_remaining_height.UseVisualStyleBackColor = true;
            // 
            // rad_covered_height
            // 
            this.rad_covered_height.AutoSize = true;
            this.rad_covered_height.Location = new System.Drawing.Point(406, 147);
            this.rad_covered_height.Name = "rad_covered_height";
            this.rad_covered_height.Size = new System.Drawing.Size(131, 17);
            this.rad_covered_height.TabIndex = 41;
            this.rad_covered_height.TabStop = true;
            this.rad_covered_height.Text = "Covered height\r\n";
            this.rad_covered_height.UseVisualStyleBackColor = true;
            // 
            // Rad_Rdistance
            // 
            this.Rad_Rdistance.AutoSize = true;
            this.Rad_Rdistance.Location = new System.Drawing.Point(574, 118);
            this.Rad_Rdistance.Name = "Rad_Rdistance";
            this.Rad_Rdistance.Size = new System.Drawing.Size(161, 17);
            this.Rad_Rdistance.TabIndex = 40;
            this.Rad_Rdistance.TabStop = true;
            this.Rad_Rdistance.Text = "Remaining Distance";
            this.Rad_Rdistance.UseVisualStyleBackColor = true;
            // 
            // rad_Cdistance
            // 
            this.rad_Cdistance.AutoSize = true;
            this.rad_Cdistance.Location = new System.Drawing.Point(406, 120);
            this.rad_Cdistance.Name = "rad_Cdistance";
            this.rad_Cdistance.Size = new System.Drawing.Size(144, 17);
            this.rad_Cdistance.TabIndex = 39;
            this.rad_Cdistance.TabStop = true;
            this.rad_Cdistance.Text = "Covered Distance";
            this.rad_Cdistance.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Options";
            // 
            // combo_MultiAngles_options
            // 
            this.combo_MultiAngles_options.FormattingEnabled = true;
            this.combo_MultiAngles_options.Items.AddRange(new object[] {
            "distance",
            "heigth",
            "angle"});
            this.combo_MultiAngles_options.Location = new System.Drawing.Point(539, 57);
            this.combo_MultiAngles_options.Name = "combo_MultiAngles_options";
            this.combo_MultiAngles_options.Size = new System.Drawing.Size(159, 21);
            this.combo_MultiAngles_options.TabIndex = 37;
            this.combo_MultiAngles_options.SelectedIndexChanged += new System.EventHandler(this.combo_MultiAngles_options_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Operations";
            // 
            // btn_OK_Dist
            // 
            this.btn_OK_Dist.Location = new System.Drawing.Point(615, 239);
            this.btn_OK_Dist.Name = "btn_OK_Dist";
            this.btn_OK_Dist.Size = new System.Drawing.Size(99, 23);
            this.btn_OK_Dist.TabIndex = 22;
            this.btn_OK_Dist.Text = "OK";
            this.btn_OK_Dist.UseVisualStyleBackColor = true;
            this.btn_OK_Dist.Click += new System.EventHandler(this.btn_OK_Dist_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Angle 2";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "distance",
            "heigth",
            "angle",
            "length",
            "multiple angles"});
            this.comboBox3.Location = new System.Drawing.Point(542, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txt_angle2
            // 
            this.txt_angle2.Location = new System.Drawing.Point(154, 209);
            this.txt_angle2.Name = "txt_angle2";
            this.txt_angle2.Size = new System.Drawing.Size(132, 21);
            this.txt_angle2.TabIndex = 34;
            // 
            // txt_Perpandicular
            // 
            this.txt_Perpandicular.Location = new System.Drawing.Point(154, 67);
            this.txt_Perpandicular.Name = "txt_Perpandicular";
            this.txt_Perpandicular.Size = new System.Drawing.Size(132, 21);
            this.txt_Perpandicular.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Perpandicular";
            // 
            // txt_Base
            // 
            this.txt_Base.Location = new System.Drawing.Point(154, 105);
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(132, 21);
            this.txt_Base.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Angle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Base";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_Angle
            // 
            this.txt_Angle.Location = new System.Drawing.Point(154, 173);
            this.txt_Angle.Name = "txt_Angle";
            this.txt_Angle.Size = new System.Drawing.Size(132, 21);
            this.txt_Angle.TabIndex = 30;
            // 
            // txt_Hyp
            // 
            this.txt_Hyp.Location = new System.Drawing.Point(154, 140);
            this.txt_Hyp.Name = "txt_Hyp";
            this.txt_Hyp.Size = new System.Drawing.Size(132, 21);
            this.txt_Hyp.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hypotenuse";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F);
            this.button2.Location = new System.Drawing.Point(499, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 45);
            this.button2.TabIndex = 17;
            this.button2.TabStop = false;
            this.button2.Text = "Multiple Distance Calculation";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F);
            this.button3.Location = new System.Drawing.Point(81, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 46);
            this.button3.TabIndex = 18;
            this.button3.TabStop = false;
            this.button3.Text = "MULTIPLE ANGLE CALCULATION";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F);
            this.button4.Location = new System.Drawing.Point(291, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 45);
            this.button4.TabIndex = 19;
            this.button4.TabStop = false;
            this.button4.Text = "MULTIPLE HEIGHT CALCULATION";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F);
            this.button5.Location = new System.Drawing.Point(291, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 38);
            this.button5.TabIndex = 20;
            this.button5.Text = "Simulation";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Kristen ITC", 14.25F);
            this.result_label.Location = new System.Drawing.Point(233, 267);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(119, 27);
            this.result_label.TabIndex = 21;
            this.result_label.Text = "result_label";
            // 
            // result_label1
            // 
            this.result_label1.AutoSize = true;
            this.result_label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F);
            this.result_label1.Location = new System.Drawing.Point(158, 267);
            this.result_label1.Name = "result_label1";
            this.result_label1.Size = new System.Drawing.Size(128, 27);
            this.result_label1.TabIndex = 47;
            this.result_label1.Text = "result_label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Trignometry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_OK_Dist;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txt_angle2;
        private System.Windows.Forms.TextBox txt_Perpandicular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Base;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Angle;
        private System.Windows.Forms.TextBox txt_Hyp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rad_theta;
        private System.Windows.Forms.RadioButton rad_PBH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_MultiAngles_options;
        private System.Windows.Forms.RadioButton Rad_Rdistance;
        private System.Windows.Forms.RadioButton rad_Cdistance;
        private System.Windows.Forms.RadioButton rad_remaining_height;
        private System.Windows.Forms.RadioButton rad_covered_height;
        private System.Windows.Forms.RadioButton rd_second_angle;
        private System.Windows.Forms.RadioButton rd_first_angle;
        private System.Windows.Forms.RadioButton rd_remaining_lengthM;
        private System.Windows.Forms.RadioButton rd_covered_length;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label result_label1;
    }
}

