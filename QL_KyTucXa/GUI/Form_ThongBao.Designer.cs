﻿namespace QL_KyTucXa.GUI
{
    partial class Form_ThongBao
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 38);
            label2.TabIndex = 0;
            label2.Text = "Thông Báo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã phòng:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 204);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 0;
            label5.Text = "Ngày hết hạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 78);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 0;
            label6.Text = "Mã SV:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 245);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 0;
            label1.Text = "Số tiền:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 31);
            textBox3.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 31);
            textBox4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(235, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 343);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN";
            // 
            // Form_ThongBao
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 508);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_ThongBao";
            Text = "Form_ThongBao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private GroupBox groupBox1;
    }
}