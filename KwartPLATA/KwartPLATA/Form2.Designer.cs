using System.Data.OleDb;
namespace KwartPLATA
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 139);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(129, 85);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(191, 23);
            textBox7.TabIndex = 7;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(486, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(129, 67);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Ф.И.О";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(129, 121);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Паспорт";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SandyBrown;
            label4.Location = new Point(129, 174);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 11;
            label4.Text = "Жил.площадь";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SandyBrown;
            label5.Location = new Point(486, 67);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.SandyBrown;
            label6.Location = new Point(486, 121);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 13;
            label6.Text = "Наличие домофона";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.SandyBrown;
            label7.Location = new Point(486, 174);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 14;
            label7.Text = "Количество жильцов";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.SandyBrown;
            label8.Location = new Point(304, 230);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 15;
            label8.Text = "Пароль";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(304, 317);
            button1.Name = "button1";
            button1.Size = new Size(209, 36);
            button1.TabIndex = 16;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pngwing_com__6_;
            pictureBox1.Location = new Point(101, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.pngwing_com__7_;
            pictureBox2.Location = new Point(287, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 23);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.pngwing_com__8_;
            pictureBox3.Location = new Point(101, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 24);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.pngwing_com__10_;
            pictureBox4.Location = new Point(458, 83);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 21);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.pngwing_com__9_;
            pictureBox5.Location = new Point(101, 191);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 23);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.pngwing_com__12_;
            pictureBox6.Location = new Point(458, 191);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 22);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.pngwing_com__11_;
            pictureBox7.Location = new Point(458, 139);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(21, 23);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(486, 83);
            maskedTextBox1.Mask = "00 .00 . 0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(191, 23);
            maskedTextBox1.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._502db913adbe888c68f896d67d66d291;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Регистрация";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public static class FormSwitcher
        {
            public static void SwitchMainForm(Form Form2, Form Form1)
            {
                Form2.Close();
            }
        }
        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private MaskedTextBox maskedTextBox1;
    }
}
