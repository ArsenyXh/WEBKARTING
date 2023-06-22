namespace WinFormsApp1
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
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button5 = new System.Windows.Forms.Button();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader12, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(12, 4);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(807, 457);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Номер";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Тип";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Время начала";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Время конца";
            columnHeader4.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Цена";
            columnHeader12.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Статус";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Рабочий ";
            columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Карт";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Экипировка";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Центр";
            columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Клиент";
            columnHeader10.Width = 70;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new System.Drawing.Point(825, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(345, 54);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сортировка";
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(208, 21);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 19;
            button5.Text = "Старт";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "В обработке", "Принята", "Выполнена" });
            comboBox3.Location = new System.Drawing.Point(81, 22);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(9, 21);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(66, 15);
            label9.TabIndex = 18;
            label9.Text = "По статусу";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(825, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(345, 191);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменения";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(7, 150);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(332, 23);
            button2.TabIndex = 12;
            button2.Text = "Принять заявку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(152, 108);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(71, 23);
            numericUpDown4.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(110, 66);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(71, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(152, 29);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(71, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 15);
            label3.TabIndex = 2;
            label3.Text = "Назначить экипировку\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Назначить карт\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Назначить сотрудника";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(825, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(345, 23);
            button1.TabIndex = 16;
            button1.Text = "Обновить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(825, 292);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(345, 23);
            button3.TabIndex = 18;
            button3.Text = "Удалить заявку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1178, 469);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}