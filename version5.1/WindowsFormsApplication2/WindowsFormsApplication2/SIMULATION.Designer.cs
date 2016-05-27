namespace WindowsFormsApplication2
{
    partial class SIMULATION
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbHypotanous = new System.Windows.Forms.TextBox();
            this.tbPerpendicular = new System.Windows.Forms.TextBox();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(94, 100);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 23);
            this.btnDraw.TabIndex = 13;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tbHypotanous
            // 
            this.tbHypotanous.Location = new System.Drawing.Point(94, 73);
            this.tbHypotanous.Name = "tbHypotanous";
            this.tbHypotanous.Size = new System.Drawing.Size(100, 20);
            this.tbHypotanous.TabIndex = 12;
            // 
            // tbPerpendicular
            // 
            this.tbPerpendicular.Location = new System.Drawing.Point(94, 47);
            this.tbPerpendicular.Name = "tbPerpendicular";
            this.tbPerpendicular.Size = new System.Drawing.Size(100, 20);
            this.tbPerpendicular.TabIndex = 11;
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(94, 21);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(100, 20);
            this.tbBase.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hypotanous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Perpendicular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Base";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            // 
            // SIMULATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 365);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.tbHypotanous);
            this.Controls.Add(this.tbPerpendicular);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SIMULATION";
            this.Text = "SIMULATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbHypotanous;
        private System.Windows.Forms.TextBox tbPerpendicular;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}