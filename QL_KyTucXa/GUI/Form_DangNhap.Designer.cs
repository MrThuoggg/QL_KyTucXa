namespace QL_KyTucXa.GUI
{
    partial class Form_DangNhap
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            label1.Location = new Point(206, 140);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 0;
            label1.Text = "TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            label2.Location = new Point(206, 233);
            label2.Name = "label2";
            label2.Size = new Size(127, 27);
            label2.TabIndex = 0;
            label2.Text = "MẬT KHẨU";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(343, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(343, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 34);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            button1.Location = new Point(395, 307);
            button1.Name = "button1";
            button1.Size = new Size(194, 59);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            button2.Location = new Point(171, 307);
            button2.Name = "button2";
            button2.Size = new Size(194, 59);
            button2.TabIndex = 2;
            button2.Text = "Đăng xuất";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 48);
            label3.Name = "label3";
            label3.Size = new Size(181, 36);
            label3.TabIndex = 3;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_DangNhap";
            Text = "Form_DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}