namespace Demo_Programming_Courses
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
            this.NameOfStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkPython = new System.Windows.Forms.CheckBox();
            this.chkJS = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdvanced = new System.Windows.Forms.RadioButton();
            this.radInterm = new System.Windows.Forms.RadioButton();
            this.radBeginner = new System.Windows.Forms.RadioButton();
            this.newLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.Location = new System.Drawing.Point(138, 28);
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.Size = new System.Drawing.Size(271, 20);
            this.NameOfStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Of Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Lesson:";
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCsharp.ForeColor = System.Drawing.Color.White;
            this.chkCsharp.Location = new System.Drawing.Point(15, 105);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(95, 20);
            this.chkCsharp.TabIndex = 3;
            this.chkCsharp.Text = "C#  ($20.77)";
            this.chkCsharp.UseVisualStyleBackColor = true;
            this.chkCsharp.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            this.chkCsharp.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // chkPython
            // 
            this.chkPython.AutoSize = true;
            this.chkPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPython.ForeColor = System.Drawing.Color.White;
            this.chkPython.Location = new System.Drawing.Point(15, 128);
            this.chkPython.Name = "chkPython";
            this.chkPython.Size = new System.Drawing.Size(117, 20);
            this.chkPython.TabIndex = 3;
            this.chkPython.Text = "Python ($40.90)";
            this.chkPython.UseVisualStyleBackColor = true;
            this.chkPython.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            this.chkPython.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // chkJS
            // 
            this.chkJS.AutoSize = true;
            this.chkJS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJS.ForeColor = System.Drawing.Color.White;
            this.chkJS.Location = new System.Drawing.Point(15, 151);
            this.chkJS.Name = "chkJS";
            this.chkJS.Size = new System.Drawing.Size(131, 20);
            this.chkJS.TabIndex = 3;
            this.chkJS.Text = "Javascript ($9.00)";
            this.chkJS.UseVisualStyleBackColor = true;
            this.chkJS.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            this.chkJS.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC.ForeColor = System.Drawing.Color.White;
            this.chkC.Location = new System.Drawing.Point(15, 174);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(115, 20);
            this.chkC.TabIndex = 3;
            this.chkC.Text = "C/C++  ($19.00)";
            this.chkC.UseVisualStyleBackColor = true;
            this.chkC.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            this.chkC.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJava.ForeColor = System.Drawing.Color.White;
            this.chkJava.Location = new System.Drawing.Point(15, 200);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(106, 20);
            this.chkJava.TabIndex = 3;
            this.chkJava.Text = "Java ($55.98)";
            this.chkJava.UseVisualStyleBackColor = true;
            this.chkJava.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            this.chkJava.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.ForeColor = System.Drawing.Color.White;
            this.chkAll.Location = new System.Drawing.Point(12, 223);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(144, 16);
            this.chkAll.TabIndex = 4;
            this.chkAll.Text = "Check all that apply";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // TotalResult
            // 
            this.TotalResult.Location = new System.Drawing.Point(66, 262);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(101, 20);
            this.TotalResult.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdvanced);
            this.groupBox1.Controls.Add(this.radInterm);
            this.groupBox1.Controls.Add(this.radBeginner);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(209, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Level";
            // 
            // radAdvanced
            // 
            this.radAdvanced.AutoSize = true;
            this.radAdvanced.Location = new System.Drawing.Point(15, 93);
            this.radAdvanced.Name = "radAdvanced";
            this.radAdvanced.Size = new System.Drawing.Size(96, 20);
            this.radAdvanced.TabIndex = 0;
            this.radAdvanced.Text = "Advanced";
            this.radAdvanced.UseVisualStyleBackColor = true;
            // 
            // radInterm
            // 
            this.radInterm.AutoSize = true;
            this.radInterm.Location = new System.Drawing.Point(15, 61);
            this.radInterm.Name = "radInterm";
            this.radInterm.Size = new System.Drawing.Size(112, 20);
            this.radInterm.TabIndex = 0;
            this.radInterm.Text = "Intermediate";
            this.radInterm.UseVisualStyleBackColor = true;
            this.radInterm.CheckedChanged += new System.EventHandler(this.ComputeCost_checkedChanged);
            // 
            // radBeginner
            // 
            this.radBeginner.AutoSize = true;
            this.radBeginner.Checked = true;
            this.radBeginner.Location = new System.Drawing.Point(15, 29);
            this.radBeginner.Name = "radBeginner";
            this.radBeginner.Size = new System.Drawing.Size(88, 20);
            this.radBeginner.TabIndex = 0;
            this.radBeginner.TabStop = true;
            this.radBeginner.Text = "Beginner";
            this.radBeginner.UseVisualStyleBackColor = true;
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.ForeColor = System.Drawing.Color.Gray;
            this.newLabel.Location = new System.Drawing.Point(316, 266);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(0, 16);
            this.newLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(218, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skill Charge(s):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(434, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.chkJS);
            this.Controls.Add(this.chkPython);
            this.Controls.Add(this.chkCsharp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfStudent);
            this.Name = "Form1";
            this.Text = "Programming Course Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkPython;
        private System.Windows.Forms.CheckBox chkJS;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.Label chkAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalResult;
        private System.Windows.Forms.RadioButton radAdvanced;
        private System.Windows.Forms.RadioButton radInterm;
        private System.Windows.Forms.RadioButton radBeginner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Label label4;
    }
}

