namespace QL_KyTucXa.GUI
{
    partial class Form_QLSinhVien
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 421);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 222);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            groupBox1.Location = new Point(895, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 348);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // button4
            // 
            button4.Location = new Point(42, 267);
            button4.Name = "button4";
            button4.Size = new Size(145, 60);
            button4.TabIndex = 4;
            button4.Text = "XÓA";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(42, 184);
            button3.Name = "button3";
            button3.Size = new Size(145, 60);
            button3.TabIndex = 3;
            button3.Text = "XÓA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(42, 104);
            button2.Name = "button2";
            button2.Size = new Size(145, 60);
            button2.TabIndex = 2;
            button2.Text = "CẬP NHẬT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(42, 28);
            button1.Name = "button1";
            button1.Size = new Size(145, 60);
            button1.TabIndex = 1;
            button1.Text = "THÊM";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_QLSinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 692);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form_QLSinhVien";
            Text = "Form_QLSinhVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}