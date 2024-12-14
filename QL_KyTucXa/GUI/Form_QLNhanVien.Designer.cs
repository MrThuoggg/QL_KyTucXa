namespace QL_KyTucXa.GUI
{
    partial class Form_QLNhanVien
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.Size = new Size(228, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
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
            // button2
            // 
            button2.Location = new Point(42, 104);
            button2.Name = "button2";
            button2.Size = new Size(145, 60);
            button2.TabIndex = 2;
            button2.Text = "CẬP NHẬT";
            button2.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 421);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 222);
            dataGridView1.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 26);
            label1.Name = "label1";
            label1.Size = new Size(275, 33);
            label1.TabIndex = 5;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(63, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 270);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN";
            // 
            // Form_QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 692);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form_QLNhanVien";
            Text = "Form_QLNhanVien";
            Load += Form_QLNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private BindingSource bindingSource1;
        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label1;
        private GroupBox groupBox2;
    }
}