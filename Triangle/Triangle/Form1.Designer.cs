namespace Triangle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.tbPerpendicular = new System.Windows.Forms.TextBox();
            this.tbHypotanous = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.angle = new System.Windows.Forms.Label();
            this.tb_angle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perpendicular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hypotanous";
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(93, 28);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(100, 20);
            this.tbBase.TabIndex = 3;
            // 
            // tbPerpendicular
            // 
            this.tbPerpendicular.Location = new System.Drawing.Point(93, 54);
            this.tbPerpendicular.Name = "tbPerpendicular";
            this.tbPerpendicular.Size = new System.Drawing.Size(100, 20);
            this.tbPerpendicular.TabIndex = 4;
            // 
            // tbHypotanous
            // 
            this.tbHypotanous.Location = new System.Drawing.Point(93, 80);
            this.tbHypotanous.Name = "tbHypotanous";
            this.tbHypotanous.Size = new System.Drawing.Size(100, 20);
            this.tbHypotanous.TabIndex = 5;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(93, 107);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 23);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(13, 9);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(33, 13);
            this.angle.TabIndex = 10;
            this.angle.Text = "angle";
            // 
            // tb_angle
            // 
            this.tb_angle.Location = new System.Drawing.Point(93, 2);
            this.tb_angle.Name = "tb_angle";
            this.tb_angle.Size = new System.Drawing.Size(100, 20);
            this.tb_angle.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 420);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.tb_angle);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.tbHypotanous);
            this.Controls.Add(this.tbPerpendicular);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Draw Triangle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.TextBox tbPerpendicular;
        private System.Windows.Forms.TextBox tbHypotanous;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.TextBox tb_angle;
    }
}

