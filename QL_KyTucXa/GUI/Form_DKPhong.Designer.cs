namespace QL_KyTucXa.GUI
{
    partial class Form_DKPhong
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
            label6 = new Label();
            label7 = new Label();
            dgdanhsach = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            txtmaphong = new TextBox();
            txttenphong = new TextBox();
            txtgiaphong = new TextBox();
            txtmasv = new TextBox();
            txtmanv = new TextBox();
            txtmadk = new TextBox();
            cbsoluongsv = new ComboBox();
            dtngaydk = new DateTimePicker();
            btdangky = new Button();
            bthuydangky = new Button();
            btcapnhat = new Button();
            btthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgdanhsach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản lý phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 95);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 158);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 213);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng sinh viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 95);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã sinh viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 158);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 213);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 0;
            label7.Text = "Mã đăng ký:";
            label7.Click += label7_Click;
            // 
            // dgdanhsach
            // 
            dgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdanhsach.Location = new Point(41, 409);
            dgdanhsach.Name = "dgdanhsach";
            dgdanhsach.RowHeadersWidth = 51;
            dgdanhsach.Size = new Size(728, 308);
            dgdanhsach.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 276);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 0;
            label8.Text = "Giá phòng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(416, 276);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 0;
            label9.Text = "Ngày đăng ký:";
            label9.Click += label7_Click;
            // 
            // txtmaphong
            // 
            txtmaphong.Location = new Point(226, 92);
            txtmaphong.Name = "txtmaphong";
            txtmaphong.Size = new Size(175, 27);
            txtmaphong.TabIndex = 2;
            // 
            // txttenphong
            // 
            txttenphong.Location = new Point(226, 155);
            txttenphong.Name = "txttenphong";
            txttenphong.Size = new Size(175, 27);
            txttenphong.TabIndex = 2;
            // 
            // txtgiaphong
            // 
            txtgiaphong.Location = new Point(226, 273);
            txtgiaphong.Name = "txtgiaphong";
            txtgiaphong.Size = new Size(175, 27);
            txtgiaphong.TabIndex = 2;
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(536, 92);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(175, 27);
            txtmasv.TabIndex = 2;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(536, 155);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(175, 27);
            txtmanv.TabIndex = 2;
            // 
            // txtmadk
            // 
            txtmadk.Location = new Point(536, 210);
            txtmadk.Name = "txtmadk";
            txtmadk.Size = new Size(175, 27);
            txtmadk.TabIndex = 2;
            // 
            // cbsoluongsv
            // 
            cbsoluongsv.FormattingEnabled = true;
            cbsoluongsv.Location = new Point(226, 210);
            cbsoluongsv.Name = "cbsoluongsv";
            cbsoluongsv.Size = new Size(175, 28);
            cbsoluongsv.TabIndex = 3;
            // 
            // dtngaydk
            // 
            dtngaydk.Format = DateTimePickerFormat.Custom;
            dtngaydk.Location = new Point(536, 273);
            dtngaydk.Name = "dtngaydk";
            dtngaydk.Size = new Size(175, 27);
            dtngaydk.TabIndex = 4;
            // 
            // btdangky
            // 
            btdangky.Location = new Point(85, 335);
            btdangky.Name = "btdangky";
            btdangky.Size = new Size(102, 45);
            btdangky.TabIndex = 5;
            btdangky.Text = "Đăng ký";
            btdangky.UseVisualStyleBackColor = true;
            // 
            // bthuydangky
            // 
            bthuydangky.Location = new Point(242, 335);
            bthuydangky.Name = "bthuydangky";
            bthuydangky.Size = new Size(102, 45);
            bthuydangky.TabIndex = 5;
            bthuydangky.Text = "Hủy đăng ký";
            bthuydangky.UseVisualStyleBackColor = true;
            // 
            // btcapnhat
            // 
            btcapnhat.Location = new Point(414, 335);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(102, 45);
            btcapnhat.TabIndex = 5;
            btcapnhat.Text = "Cập nhật";
            btcapnhat.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(609, 335);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(102, 45);
            btthoat.TabIndex = 5;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            // 
            // Form_DKPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 754);
            Controls.Add(btthoat);
            Controls.Add(btcapnhat);
            Controls.Add(bthuydangky);
            Controls.Add(btdangky);
            Controls.Add(dtngaydk);
            Controls.Add(cbsoluongsv);
            Controls.Add(txtgiaphong);
            Controls.Add(txtmadk);
            Controls.Add(txtmanv);
            Controls.Add(txtmasv);
            Controls.Add(txttenphong);
            Controls.Add(txtmaphong);
            Controls.Add(dgdanhsach);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_DKPhong";
            Text = "Form_DKPhong";
            Load += Form_DKPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgdanhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgdanhsach;
        private Label label8;
        private Label label9;
        private TextBox txtmaphong;
        private TextBox txttenphong;
        private TextBox txtgiaphong;
        private TextBox txtmasv;
        private TextBox txtmanv;
        private TextBox txtmadk;
        private ComboBox cbsoluongsv;
        private DateTimePicker dtngaydk;
        private Button btdangky;
        private Button bthuydangky;
        private Button btcapnhat;
        private Button btthoat;
    }
}