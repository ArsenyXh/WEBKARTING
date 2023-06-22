
namespace WinFormsApp1
{
    partial class Form9
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            textBox5 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(154, 416);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Тип";
            columnHeader2.Width = 90;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new System.Drawing.Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(379, 461);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Карты";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(175, 130);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(193, 23);
            button3.TabIndex = 22;
            button3.Text = "Обновить данные";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(175, 92);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(193, 23);
            button2.TabIndex = 21;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(175, 53);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(193, 23);
            button1.TabIndex = 20;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(214, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(102, 23);
            textBox1.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(175, 57);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(0, 15);
            label7.TabIndex = 16;
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(175, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 15);
            label4.TabIndex = 15;
            label4.Text = "Тип";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(listView2);
            groupBox2.Location = new System.Drawing.Point(398, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(376, 461);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Экипировка";
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(172, 130);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(193, 23);
            button6.TabIndex = 25;
            button6.Text = "Обновить данные";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(172, 92);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(193, 23);
            button5.TabIndex = 24;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(172, 53);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(193, 23);
            button4.TabIndex = 23;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(211, 18);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(102, 23);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(172, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(27, 15);
            label5.TabIndex = 16;
            label5.Text = "Тип";
            label5.Click += label5_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader5 });
            listView2.HideSelection = false;
            listView2.Location = new System.Drawing.Point(6, 22);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(155, 416);
            listView2.TabIndex = 11;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Номер";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Тип";
            columnHeader5.Width = 90;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(779, 485);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form9";
            Text = "Карты и экипировка";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
    }
}