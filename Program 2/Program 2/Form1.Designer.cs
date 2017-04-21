namespace Program_2
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
            this.FreshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.JuniorRadioButton = new System.Windows.Forms.RadioButton();
            this.SeniorRadioButton = new System.Windows.Forms.RadioButton();
            this.SophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FreshmanRadioButton
            // 
            this.FreshmanRadioButton.AutoSize = true;
            this.FreshmanRadioButton.Location = new System.Drawing.Point(201, 12);
            this.FreshmanRadioButton.Name = "FreshmanRadioButton";
            this.FreshmanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.FreshmanRadioButton.TabIndex = 0;
            this.FreshmanRadioButton.TabStop = true;
            this.FreshmanRadioButton.Text = "Freshman";
            this.FreshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // JuniorRadioButton
            // 
            this.JuniorRadioButton.AutoSize = true;
            this.JuniorRadioButton.Location = new System.Drawing.Point(201, 58);
            this.JuniorRadioButton.Name = "JuniorRadioButton";
            this.JuniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.JuniorRadioButton.TabIndex = 2;
            this.JuniorRadioButton.TabStop = true;
            this.JuniorRadioButton.Text = "Junior";
            this.JuniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // SeniorRadioButton
            // 
            this.SeniorRadioButton.AutoSize = true;
            this.SeniorRadioButton.Location = new System.Drawing.Point(201, 81);
            this.SeniorRadioButton.Name = "SeniorRadioButton";
            this.SeniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.SeniorRadioButton.TabIndex = 3;
            this.SeniorRadioButton.TabStop = true;
            this.SeniorRadioButton.Text = "Senior";
            this.SeniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // SophomoreRadioButton
            // 
            this.SophomoreRadioButton.AutoSize = true;
            this.SophomoreRadioButton.Location = new System.Drawing.Point(201, 35);
            this.SophomoreRadioButton.Name = "SophomoreRadioButton";
            this.SophomoreRadioButton.Size = new System.Drawing.Size(79, 17);
            this.SophomoreRadioButton.TabIndex = 4;
            this.SophomoreRadioButton.TabStop = true;
            this.SophomoreRadioButton.Text = "Sophomore";
            this.SophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 105);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SophomoreRadioButton);
            this.Controls.Add(this.SeniorRadioButton);
            this.Controls.Add(this.JuniorRadioButton);
            this.Controls.Add(this.FreshmanRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FreshmanRadioButton;
        private System.Windows.Forms.RadioButton JuniorRadioButton;
        private System.Windows.Forms.RadioButton SeniorRadioButton;
        private System.Windows.Forms.RadioButton SophomoreRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

