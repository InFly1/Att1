namespace Task15._9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadFromfile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddD = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFromfile
            // 
            this.buttonLoadFromfile.Location = new System.Drawing.Point(17, 85);
            this.buttonLoadFromfile.Name = "buttonLoadFromfile";
            this.buttonLoadFromfile.Size = new System.Drawing.Size(98, 58);
            this.buttonLoadFromfile.TabIndex = 0;
            this.buttonLoadFromfile.Text = "Load From File";
            this.buttonLoadFromfile.UseVisualStyleBackColor = true;
            this.buttonLoadFromfile.Click += new System.EventHandler(this.buttonLoadFromfile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 26);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAddD
            // 
            this.buttonAddD.Location = new System.Drawing.Point(736, 95);
            this.buttonAddD.Name = "buttonAddD";
            this.buttonAddD.Size = new System.Drawing.Size(278, 39);
            this.buttonAddD.TabIndex = 4;
            this.buttonAddD.Text = "Add Element";
            this.buttonAddD.UseVisualStyleBackColor = true;
            this.buttonAddD.Click += new System.EventHandler(this.buttonAddD_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(13, 13);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(1001, 26);
            this.textBoxDisplay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод D (число типа double):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonAddD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLoadFromfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFromfile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddD;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label label1;
    }
}

