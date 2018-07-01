namespace Task15._9Queue
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonLoadFROMfile = new System.Windows.Forms.Button();
            this.buttonDeleteXnames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDisplayRes = new System.Windows.Forms.TextBox();
            this.textBoxEnterChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загруженные Фамилии";
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(17, 36);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(1175, 26);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // buttonLoadFROMfile
            // 
            this.buttonLoadFROMfile.Location = new System.Drawing.Point(17, 88);
            this.buttonLoadFROMfile.Name = "buttonLoadFROMfile";
            this.buttonLoadFROMfile.Size = new System.Drawing.Size(195, 38);
            this.buttonLoadFROMfile.TabIndex = 2;
            this.buttonLoadFROMfile.Text = "Load From File";
            this.buttonLoadFROMfile.UseVisualStyleBackColor = true;
            this.buttonLoadFROMfile.Click += new System.EventHandler(this.buttonLoadFROMfile_Click);
            // 
            // buttonDeleteXnames
            // 
            this.buttonDeleteXnames.Location = new System.Drawing.Point(817, 88);
            this.buttonDeleteXnames.Name = "buttonDeleteXnames";
            this.buttonDeleteXnames.Size = new System.Drawing.Size(375, 38);
            this.buttonDeleteXnames.TabIndex = 3;
            this.buttonDeleteXnames.Text = "Удалить фамилии, начинающиеся на Х";
            this.buttonDeleteXnames.UseVisualStyleBackColor = true;
            this.buttonDeleteXnames.Click += new System.EventHandler(this.buttonDeleteXnames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // textBoxDisplayRes
            // 
            this.textBoxDisplayRes.Location = new System.Drawing.Point(17, 207);
            this.textBoxDisplayRes.Name = "textBoxDisplayRes";
            this.textBoxDisplayRes.Size = new System.Drawing.Size(1175, 26);
            this.textBoxDisplayRes.TabIndex = 5;
            // 
            // textBoxEnterChar
            // 
            this.textBoxEnterChar.Location = new System.Drawing.Point(683, 94);
            this.textBoxEnterChar.Name = "textBoxEnterChar";
            this.textBoxEnterChar.Size = new System.Drawing.Size(100, 26);
            this.textBoxEnterChar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите ОДНУ букву:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEnterChar);
            this.Controls.Add(this.textBoxDisplayRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteXnames);
            this.Controls.Add(this.buttonLoadFROMfile);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonLoadFROMfile;
        private System.Windows.Forms.Button buttonDeleteXnames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDisplayRes;
        private System.Windows.Forms.TextBox textBoxEnterChar;
        private System.Windows.Forms.Label label3;
    }
}

