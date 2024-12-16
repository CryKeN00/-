using System.Diagnostics.Eventing.Reader;

namespace KwartPLATA
{
    partial class Form4
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox9 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox10 = new TextBox();
            button2 = new Button();
            label10 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(265, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 322);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(29, 271);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(29, 221);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(131, 23);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(29, 174);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 23);
            textBox8.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(29, 158);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Горячая вода";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(29, 205);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 10;
            label3.Text = "Холодная вода";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SandyBrown;
            label4.Location = new Point(29, 255);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "Свет";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SandyBrown;
            label5.Location = new Point(29, 306);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 12;
            label5.Text = "Газ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.SandyBrown;
            label6.Location = new Point(265, 158);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 13;
            label6.Text = "Домофон";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.SandyBrown;
            label7.Location = new Point(265, 205);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Мусор";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.SandyBrown;
            label8.Location = new Point(265, 255);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 15;
            label8.Text = "Кап.ремонт";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.SandyBrown;
            label9.Location = new Point(265, 306);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 16;
            label9.Text = "Отопление";
            label9.Click += label9_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(278, 49);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(240, 23);
            textBox9.TabIndex = 17;
            // 
            // button1
            // 
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(524, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pngwing1;
            pictureBox1.Location = new Point(252, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 23);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(589, 322);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(131, 23);
            textBox10.TabIndex = 20;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // button2
            // 
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(614, 351);
            button2.Name = "button2";
            button2.Size = new Size(79, 23);
            button2.TabIndex = 21;
            button2.Text = "Раcсчитать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(589, 306);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 22;
            label10.Text = "Общая квартплата";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(29, 394);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 23;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(135, 394);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 24;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(241, 394);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(29, 359);
            label11.Name = "label11";
            label11.Size = new Size(170, 15);
            label11.TabIndex = 26;
            label11.Text = "Введите данные счетчиков:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.SandyBrown;
            label12.Location = new Point(29, 374);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 27;
            label12.Text = "Горячая вода";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.SandyBrown;
            label13.Location = new Point(135, 376);
            label13.Name = "label13";
            label13.Size = new Size(93, 15);
            label13.TabIndex = 28;
            label13.Text = "Холодная вода";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.SandyBrown;
            label14.Location = new Point(241, 376);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 29;
            label14.Text = "Свет";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._502db913adbe888c68f896d67d66d291;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(textBox10);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.SandyBrown;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public static class FormSwitcher
        {
            public static void SwitchMainForm(Form Form4, Form Form1)
            {
                Form4.Close();
                Form1.FormClosed += (s, args) => Form1.Show();
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            FormSwitcher.SwitchMainForm(this, newForm);

        }




        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox10;
        private Button button2;
        private Label label10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}