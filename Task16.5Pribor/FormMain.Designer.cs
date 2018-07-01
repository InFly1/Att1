namespace Task16._5Pribor
{
    partial class FormMain
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
            this.dataGridViewForInput = new System.Windows.Forms.DataGridView();
            this.buttonDoIt = new System.Windows.Forms.Button();
            this.dataGridViewOutPut = new System.Windows.Forms.DataGridView();
            this.textBoxInputA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForInput
            // 
            this.dataGridViewForInput.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewForInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForInput.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewForInput.Name = "dataGridViewForInput";
            this.dataGridViewForInput.Size = new System.Drawing.Size(203, 452);
            this.dataGridViewForInput.TabIndex = 0;
            // 
            // buttonDoIt
            // 
            this.buttonDoIt.Location = new System.Drawing.Point(277, 206);
            this.buttonDoIt.Name = "buttonDoIt";
            this.buttonDoIt.Size = new System.Drawing.Size(92, 47);
            this.buttonDoIt.TabIndex = 1;
            this.buttonDoIt.Text = "Do IT";
            this.buttonDoIt.UseVisualStyleBackColor = true;
            this.buttonDoIt.Click += new System.EventHandler(this.buttonDoIt_Click);
            // 
            // dataGridViewOutPut
            // 
            this.dataGridViewOutPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut.Location = new System.Drawing.Point(435, 13);
            this.dataGridViewOutPut.Name = "dataGridViewOutPut";
            this.dataGridViewOutPut.Size = new System.Drawing.Size(501, 452);
            this.dataGridViewOutPut.TabIndex = 2;
            // 
            // textBoxInputA
            // 
            this.textBoxInputA.Location = new System.Drawing.Point(277, 108);
            this.textBoxInputA.Name = "textBoxInputA";
            this.textBoxInputA.Size = new System.Drawing.Size(92, 20);
            this.textBoxInputA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите А";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(948, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputA);
            this.Controls.Add(this.dataGridViewOutPut);
            this.Controls.Add(this.buttonDoIt);
            this.Controls.Add(this.dataGridViewForInput);
            this.Name = "FormMain";
            this.Text = "Task16.5Pribor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForInput;
        private System.Windows.Forms.Button buttonDoIt;
        private System.Windows.Forms.DataGridView dataGridViewOutPut;
        private System.Windows.Forms.TextBox textBoxInputA;
        private System.Windows.Forms.Label label1;
    }
}

