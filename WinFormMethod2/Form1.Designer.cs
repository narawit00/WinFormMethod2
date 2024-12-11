namespace WinFormMethod2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblResult = new Label();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnOutputParameter = new Button();
            txtinput = new TextBox();
            btnRefParameter = new Button();
            btnTriangle01 = new Button();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aquamarine;
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(btnCircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.SeaGreen;
            lblResult.Location = new Point(90, 112);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(371, 42);
            lblResult.TabIndex = 4;
            lblResult.Text = ".........";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(367, 50);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(94, 29);
            btnCircumference.TabIndex = 3;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(233, 50);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(94, 29);
            btnCircleArea.TabIndex = 2;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(90, 50);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(107, 27);
            txtRadius.TabIndex = 1;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 50);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(btnOutputParameter);
            groupBox2.Controls.Add(txtinput);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(56, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(624, 341);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ funtion";
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(291, 272);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(293, 29);
            btnOutputParameter.TabIndex = 6;
            btnOutputParameter.Text = "ทดสอบ Output Parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // txtinput
            // 
            txtinput.Location = new Point(294, 189);
            txtinput.Multiline = true;
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(290, 34);
            txtinput.TabIndex = 5;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(294, 228);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(290, 29);
            btnRefParameter.TabIndex = 4;
            btnRefParameter.Text = "ทดสอบ reference Parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(367, 140);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(125, 29);
            btnTriangle01.TabIndex = 3;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(367, 91);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 2;
            txtSize.Text = "5";
            txtSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(367, 41);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(125, 27);
            txtLetter.TabIndex = 1;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(90, 41);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(188, 260);
            txtOutput.TabIndex = 0;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(686, 39);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(230, 57);
            btnArrayParameter.TabIndex = 2;
            btnArrayParameter.Text = "Parameter เเบบ Array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(939, 599);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCircumference;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtOutput;
        private Label lblResult;
        private TextBox txtSize;
        private TextBox txtLetter;
        private Button btnTriangle01;
        private Button btnRefParameter;
        private TextBox txtinput;
        private Button btnOutputParameter;
        private Button btnArrayParameter;
    }
}
