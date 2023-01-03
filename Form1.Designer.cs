
namespace SAOD_kyrsach
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
            this.Btn_add_font = new System.Windows.Forms.Button();
            this.Btn_del = new System.Windows.Forms.Button();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_add_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_add_font
            // 
            this.Btn_add_font.Location = new System.Drawing.Point(12, 263);
            this.Btn_add_font.Name = "Btn_add_font";
            this.Btn_add_font.Size = new System.Drawing.Size(78, 45);
            this.Btn_add_font.TabIndex = 0;
            this.Btn_add_font.Text = "Добавить \r\nв начало";
            this.Btn_add_font.UseVisualStyleBackColor = true;
            this.Btn_add_font.Click += new System.EventHandler(this.Btn_add_font_Click);
            // 
            // Btn_del
            // 
            this.Btn_del.Location = new System.Drawing.Point(180, 263);
            this.Btn_del.Name = "Btn_del";
            this.Btn_del.Size = new System.Drawing.Size(78, 45);
            this.Btn_del.TabIndex = 1;
            this.Btn_del.Text = "Удалить \r\nИмя";
            this.Btn_del.UseVisualStyleBackColor = true;
            this.Btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(264, 263);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(78, 45);
            this.Btn_Find.TabIndex = 2;
            this.Btn_Find.Text = "Найти имя\r\n";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(55, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(274, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Btn_add_back
            // 
            this.Btn_add_back.Location = new System.Drawing.Point(96, 263);
            this.Btn_add_back.Name = "Btn_add_back";
            this.Btn_add_back.Size = new System.Drawing.Size(78, 45);
            this.Btn_add_back.TabIndex = 7;
            this.Btn_add_back.Text = "Добавить \r\nв конец\r\n";
            this.Btn_add_back.UseVisualStyleBackColor = true;
            this.Btn_add_back.Click += new System.EventHandler(this.Btn_add_back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(603, 214);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(639, 319);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_add_back);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Btn_del);
            this.Controls.Add(this.Btn_add_font);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Кольцевой список";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_add_font;
        private System.Windows.Forms.Button Btn_del;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_add_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

