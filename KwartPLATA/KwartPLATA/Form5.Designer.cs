namespace KwartPLATA
{
    partial class Form5
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
            dataGridViewUsers = new DataGridView();
            button3 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "Администратор";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(1, 42);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(801, 265);
            dataGridViewUsers.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(617, 415);
            button3.Name = "button3";
            button3.Size = new Size(171, 23);
            button3.TabIndex = 5;
            button3.Text = "Удалить запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 416);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Click += comboBoxTables_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 356);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(617, 356);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 10;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddEmptyRow_Click;
            // 
            // button2
            // 
            button2.Location = new Point(617, 385);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 11;
            button2.Text = "Редактировать запись";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 338);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 12;
            label2.Text = "Введите данные";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(dataGridViewUsers);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private ComboBox comboBox1;
        protected DataGridView dataGridViewUsers;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}