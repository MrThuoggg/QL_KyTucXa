namespace QL_KyTucXa.GUI
{
    partial class Form_QLPhong
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtmaphong = new TextBox();
            txttenphong = new TextBox();
            txtgiaphong = new TextBox();
            txtsoluong = new TextBox();
            dgdanhsach = new DataGridView();
            btthem = new Button();
            btcapnhat = new Button();
            btxoa = new Button();
            btthoat = new Button();
            cbtinhtrang = new ComboBox();
            btghi = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgdanhsach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 26);
            label1.Name = "label1";
            label1.Size = new Size(223, 33);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 69);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 132);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 0;
            label3.Text = "Tên phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 200);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 0;
            label4.Text = "Tình trạng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 69);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 0;
            label5.Text = "Số lượng SV:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 132);
            label7.Name = "label7";
            label7.Size = new Size(124, 27);
            label7.TabIndex = 0;
            label7.Text = "Giá phòng:";
            // 
            // txtmaphong
            // 
            txtmaphong.Location = new Point(135, 66);
            txtmaphong.Name = "txtmaphong";
            txtmaphong.Size = new Size(241, 34);
            txtmaphong.TabIndex = 1;
            // 
            // txttenphong
            // 
            txttenphong.Location = new Point(135, 129);
            txttenphong.Name = "txttenphong";
            txttenphong.Size = new Size(241, 34);
            txttenphong.TabIndex = 1;
            // 
            // txtgiaphong
            // 
            txtgiaphong.Location = new Point(585, 132);
            txtgiaphong.Name = "txtgiaphong";
            txtgiaphong.Size = new Size(241, 34);
            txtgiaphong.TabIndex = 1;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(585, 69);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(241, 34);
            txtsoluong.TabIndex = 1;
            // 
            // dgdanhsach
            // 
            dgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdanhsach.Location = new Point(63, 421);
            dgdanhsach.Name = "dgdanhsach";
            dgdanhsach.RowHeadersWidth = 51;
            dgdanhsach.Size = new Size(1059, 222);
            dgdanhsach.TabIndex = 2;
            dgdanhsach.CellContentClick += dgdanhsach_CellContentClick;
            // 
            // btthem
            // 
            btthem.Location = new Point(51, 105);
            btthem.Name = "btthem";
            btthem.Size = new Size(145, 60);
            btthem.TabIndex = 3;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btcapnhat
            // 
            btcapnhat.Location = new Point(51, 168);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(145, 60);
            btcapnhat.TabIndex = 3;
            btcapnhat.Text = "Cập nhật";
            btcapnhat.UseVisualStyleBackColor = true;
            btcapnhat.Click += btcapnhat_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(51, 229);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(145, 60);
            btxoa.TabIndex = 3;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(51, 295);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(145, 60);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // cbtinhtrang
            // 
            cbtinhtrang.FormattingEnabled = true;
            cbtinhtrang.Location = new Point(135, 196);
            cbtinhtrang.Name = "cbtinhtrang";
            cbtinhtrang.Size = new Size(241, 35);
            cbtinhtrang.TabIndex = 4;
            // 
            // btghi
            // 
            btghi.Location = new Point(51, 43);
            btghi.Name = "btghi";
            btghi.Size = new Size(145, 60);
            btghi.TabIndex = 5;
            btghi.Text = "Ghi";
            btghi.UseVisualStyleBackColor = true;
            btghi.Click += btghi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btthem);
            groupBox1.Controls.Add(btghi);
            groupBox1.Controls.Add(btthoat);
            groupBox1.Controls.Add(btcapnhat);
            groupBox1.Controls.Add(btxoa);
            groupBox1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(895, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 367);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtgiaphong);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbtinhtrang);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtsoluong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txttenphong);
            groupBox2.Controls.Add(txtmaphong);
            groupBox2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(63, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 270);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN";
            // 
            // Form_QLPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 692);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgdanhsach);
            Controls.Add(label1);
            Name = "Form_QLPhong";
            Text = "Form_QLPhong";
            Load += Form_QLPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgdanhsach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtmaphong;
        private TextBox txttenphong;
        private TextBox txtgiaphong;
        private TextBox txtsoluong;
        private DataGridView dgdanhsach;
        private Button btthem;
        private Button btcapnhat;
        private Button btxoa;
        private Button btthoat;
        private ComboBox cbtinhtrang;
        private Button btghi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}