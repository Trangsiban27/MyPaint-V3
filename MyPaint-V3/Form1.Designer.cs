namespace MyPaint_V3
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb1Color = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cdColor1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb2Color = new System.Windows.Forms.Label();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPatternFill = new System.Windows.Forms.RadioButton();
            this.rdbColorFill = new System.Windows.Forms.RadioButton();
            this.rdbNoFill = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbCircle = new System.Windows.Forms.RadioButton();
            this.rbdRectangle = new System.Windows.Forms.RadioButton();
            this.cdColor2 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(734, 466);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb1Color);
            this.groupBox1.Controls.Add(this.btnColor1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inpPenWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(740, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen";
            // 
            // lb1Color
            // 
            this.lb1Color.AutoSize = true;
            this.lb1Color.Location = new System.Drawing.Point(88, 104);
            this.lb1Color.Name = "lb1Color";
            this.lb1Color.Size = new System.Drawing.Size(0, 16);
            this.lb1Color.TabIndex = 9;
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(81, 78);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(110, 23);
            this.btnColor1.TabIndex = 3;
            this.btnColor1.Text = "Pick A Color";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(81, 33);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(81, 22);
            this.inpPenWidth.TabIndex = 1;
            this.inpPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb2Color);
            this.groupBox2.Controls.Add(this.btnColor2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdbPatternFill);
            this.groupBox2.Controls.Add(this.rdbColorFill);
            this.groupBox2.Controls.Add(this.rdbNoFill);
            this.groupBox2.Location = new System.Drawing.Point(740, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lb2Color
            // 
            this.lb2Color.AutoSize = true;
            this.lb2Color.Location = new System.Drawing.Point(65, 138);
            this.lb2Color.Name = "lb2Color";
            this.lb2Color.Size = new System.Drawing.Size(0, 16);
            this.lb2Color.TabIndex = 10;
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(61, 112);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(130, 23);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.Text = "Pcik A Color";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // rdbPatternFill
            // 
            this.rdbPatternFill.AutoSize = true;
            this.rdbPatternFill.Location = new System.Drawing.Point(15, 83);
            this.rdbPatternFill.Name = "rdbPatternFill";
            this.rdbPatternFill.Size = new System.Drawing.Size(90, 20);
            this.rdbPatternFill.TabIndex = 3;
            this.rdbPatternFill.Text = "Pattern Fill";
            this.rdbPatternFill.UseVisualStyleBackColor = true;
            // 
            // rdbColorFill
            // 
            this.rdbColorFill.AutoSize = true;
            this.rdbColorFill.Location = new System.Drawing.Point(15, 57);
            this.rdbColorFill.Name = "rdbColorFill";
            this.rdbColorFill.Size = new System.Drawing.Size(80, 20);
            this.rdbColorFill.TabIndex = 4;
            this.rdbColorFill.Text = "Color Fill";
            this.rdbColorFill.UseVisualStyleBackColor = true;
            // 
            // rdbNoFill
            // 
            this.rdbNoFill.AutoSize = true;
            this.rdbNoFill.Checked = true;
            this.rdbNoFill.Location = new System.Drawing.Point(15, 31);
            this.rdbNoFill.Name = "rdbNoFill";
            this.rdbNoFill.Size = new System.Drawing.Size(66, 20);
            this.rdbNoFill.TabIndex = 3;
            this.rdbNoFill.TabStop = true;
            this.rdbNoFill.Text = "No Fill";
            this.rdbNoFill.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbCircle);
            this.groupBox3.Controls.Add(this.rbdRectangle);
            this.groupBox3.Location = new System.Drawing.Point(740, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 127);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shape";
            // 
            // rdbCircle
            // 
            this.rdbCircle.AutoSize = true;
            this.rdbCircle.Location = new System.Drawing.Point(19, 81);
            this.rdbCircle.Name = "rdbCircle";
            this.rdbCircle.Size = new System.Drawing.Size(62, 20);
            this.rdbCircle.TabIndex = 8;
            this.rdbCircle.Text = "Circle";
            this.rdbCircle.UseVisualStyleBackColor = true;
            // 
            // rbdRectangle
            // 
            this.rbdRectangle.AutoSize = true;
            this.rbdRectangle.Checked = true;
            this.rbdRectangle.Location = new System.Drawing.Point(19, 38);
            this.rbdRectangle.Name = "rbdRectangle";
            this.rbdRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbdRectangle.TabIndex = 0;
            this.rbdRectangle.TabStop = true;
            this.rbdRectangle.Text = "Rectangle";
            this.rbdRectangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdColor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPatternFill;
        private System.Windows.Forms.RadioButton rdbColorFill;
        private System.Windows.Forms.RadioButton rdbNoFill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbCircle;
        private System.Windows.Forms.RadioButton rbdRectangle;
        private System.Windows.Forms.ColorDialog cdColor2;
        private System.Windows.Forms.Label lb1Color;
        private System.Windows.Forms.Label lb2Color;
    }
}

