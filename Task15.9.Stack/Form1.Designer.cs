namespace Task15._9.Stack
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
            this.buttonDoTask = new System.Windows.Forms.Button();
            this.buttonOpenResultFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoTask
            // 
            this.buttonDoTask.Location = new System.Drawing.Point(12, 12);
            this.buttonDoTask.Name = "buttonDoTask";
            this.buttonDoTask.Size = new System.Drawing.Size(224, 187);
            this.buttonDoTask.TabIndex = 5;
            this.buttonDoTask.Text = "Преобразовать последовательность действительных чисел, записанных в файле, распол" +
    "ожив  сначала отрицательные числа последовательности, а затем неотрицательные";
            this.buttonDoTask.UseVisualStyleBackColor = true;
            this.buttonDoTask.Click += new System.EventHandler(this.buttonDoTask_Click);
            // 
            // buttonOpenResultFile
            // 
            this.buttonOpenResultFile.Location = new System.Drawing.Point(288, 89);
            this.buttonOpenResultFile.Name = "buttonOpenResultFile";
            this.buttonOpenResultFile.Size = new System.Drawing.Size(226, 83);
            this.buttonOpenResultFile.TabIndex = 6;
            this.buttonOpenResultFile.Text = "Открыть файл с результатом";
            this.buttonOpenResultFile.UseVisualStyleBackColor = true;
            this.buttonOpenResultFile.Click += new System.EventHandler(this.buttonOpenResultFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 281);
            this.Controls.Add(this.buttonOpenResultFile);
            this.Controls.Add(this.buttonDoTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDoTask;
        private System.Windows.Forms.Button buttonOpenResultFile;
    }
}

