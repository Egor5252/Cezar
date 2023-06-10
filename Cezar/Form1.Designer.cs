namespace Cezar
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
            this.numericUpDown1_key = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_codeword = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_key)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ключевое слово";
            // 
            // numericUpDown1_key
            // 
            this.numericUpDown1_key.Location = new System.Drawing.Point(108, 38);
            this.numericUpDown1_key.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.numericUpDown1_key.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1_key.Name = "numericUpDown1_key";
            this.numericUpDown1_key.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1_key.TabIndex = 1;
            this.numericUpDown1_key.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // textBox1_codeword
            // 
            this.textBox1_codeword.Location = new System.Drawing.Point(108, 12);
            this.textBox1_codeword.Name = "textBox1_codeword";
            this.textBox1_codeword.Size = new System.Drawing.Size(100, 20);
            this.textBox1_codeword.TabIndex = 0;
            this.textBox1_codeword.TextChanged += new System.EventHandler(this.textBox1_codeword_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(108, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 123);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(108, 193);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(222, 123);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шифр";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(108, 322);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(222, 123);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расшифровка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1_codeword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1_key);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Шифр Цезаря";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_codeword;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label5;
    }
}

