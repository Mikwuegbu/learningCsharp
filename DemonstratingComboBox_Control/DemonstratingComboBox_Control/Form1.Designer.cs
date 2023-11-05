namespace DemonstratingComboBox_Control
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
            this.comboStephens = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboStephens
            // 
            this.comboStephens.FormattingEnabled = true;
            this.comboStephens.Items.AddRange(new object[] {
            "Chiamaka",
            "Lisa",
            "Blessing",
            "Uchechukwu",
            "Nkechinyere",
            "Augustine ",
            "Raymond "});
            this.comboStephens.Location = new System.Drawing.Point(40, 109);
            this.comboStephens.Name = "comboStephens";
            this.comboStephens.Size = new System.Drawing.Size(184, 24);
            this.comboStephens.TabIndex = 0;
            this.comboStephens.SelectedIndexChanged += new System.EventHandler(this.comboStephens_SelectedIndexChanged);
            this.comboStephens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboStephens_KeyPress);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(40, 40);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(184, 22);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stephen\'s Family:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboStephens);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStephens;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}

