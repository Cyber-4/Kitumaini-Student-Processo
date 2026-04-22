namespace StudentProcessorGUI
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
            lblHeading = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHours = new TextBox();
            txtMod1 = new TextBox();
            txtMod2 = new TextBox();
            txtMod3 = new TextBox();
            chkLaptop = new CheckBox();
            btnCalculate = new Button();
            lstOutput = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 20F);
            lblHeading.Location = new Point(367, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(322, 37);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Student Readiness System";
            // 
            // txtName
            // 
            txtName.Location = new Point(439, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(439, 148);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 23);
            txtAge.TabIndex = 2;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(439, 212);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(250, 23);
            txtHours.TabIndex = 3;
            // 
            // txtMod1
            // 
            txtMod1.Location = new Point(439, 273);
            txtMod1.Name = "txtMod1";
            txtMod1.Size = new Size(250, 23);
            txtMod1.TabIndex = 4;
            // 
            // txtMod2
            // 
            txtMod2.Location = new Point(439, 340);
            txtMod2.Name = "txtMod2";
            txtMod2.Size = new Size(250, 23);
            txtMod2.TabIndex = 5;
            // 
            // txtMod3
            // 
            txtMod3.Location = new Point(439, 404);
            txtMod3.Name = "txtMod3";
            txtMod3.Size = new Size(250, 23);
            txtMod3.TabIndex = 6;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(439, 473);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(91, 19);
            chkLaptop.TabIndex = 7;
            chkLaptop.Text = "Has Laptop?";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(439, 535);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(250, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Readiness";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(794, 83);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(232, 259);
            lstOutput.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 86);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 10;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 151);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Student Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 215);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 12;
            label3.Text = "Study Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 276);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 13;
            label4.Text = "Module 1 (Ave)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 343);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 14;
            label5.Text = "Module 2 (Ave)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 407);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 15;
            label6.Text = "Module 3 (Ave)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 638);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstOutput);
            Controls.Add(btnCalculate);
            Controls.Add(chkLaptop);
            Controls.Add(txtMod3);
            Controls.Add(txtMod2);
            Controls.Add(txtMod1);
            Controls.Add(txtHours);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblHeading);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHours;
        private TextBox txtMod1;
        private TextBox txtMod2;
        private TextBox txtMod3;
        private CheckBox chkLaptop;
        private Button btnCalculate;
        private ListBox lstOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
