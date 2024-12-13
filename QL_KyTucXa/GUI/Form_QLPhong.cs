﻿using QL_KyTucXa.BUS;
using QL_KyTucXa.DAO;
using QL_KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KyTucXa.GUI
{
    public partial class Form_QLPhong : Form
    {
        public Form_QLPhong()
        {
            InitializeComponent();
        }
        public void DanhSachPhong()
        {
            DataTable dtphong = new DataTable();
            dtphong = QuanLiKTX_DAO.ThongTinPhong();
            dgdanhsach.DataSource = dtphong;
        }
        public void DanhSachTinhTrang()
        {
            DataTable dt = new DataTable();
            dt = QuanLiKTX_DAO.ThongTinPhong();
            cbtinhtrang.DataSource = dt;
            cbtinhtrang.DisplayMember = "TinhTrang";
            cbtinhtrang.ValueMember = "TinhTrang";
        }
        private void Form_QLPhong_Load(object sender, EventArgs e)
        {
            DanhSachPhong();
            DanhSachTinhTrang();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QuanLiKTX_DAO.ThongTinPhongLonNhat();
            string maphong = dt.Rows[0][0].ToString();
            txtmaphong.Text = "P" + (int.Parse(maphong.Substring(1, maphong.Length - 1)) + 1).ToString("000");
            txttenphong.Text = "Phòng " + (int.Parse(maphong.Substring(1, maphong.Length - 1)) + 1).ToString("000");
            txtsoluong.Text = "0";
            txtgiaphong.Text = "";
            cbtinhtrang.SelectedIndex = 0;
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            QuanLiKTX_DTO dt = new QuanLiKTX_DTO();
            dt.Maphong = txtmaphong.Text;
            dt.Tenphong = txttenphong.Text;
            dt.Tinhtrang = cbtinhtrang.SelectedValue.ToString();
            dt.Soluongsv = txtsoluong.Text;
            dt.Giaphong = txtgiaphong.Text;
            QuanLiKTX_BUS.capnhatphong(dt);
            DanhSachPhong();
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            QuanLiKTX_DTO dt = new QuanLiKTX_DTO();
            dt.Maphong = txtmaphong.Text;
            dt.Tenphong = txttenphong.Text;
            dt.Tinhtrang = cbtinhtrang.SelectedValue.ToString();
            dt.Soluongsv = txtsoluong.Text;
            dt.Giaphong = txtgiaphong.Text;
            QuanLiKTX_BUS.themphong(dt);
            DanhSachPhong();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            QuanLiKTX_DTO dt = new QuanLiKTX_DTO();
            dt.Maphong = txtmaphong.Text;
            QuanLiKTX_BUS.Xoaphong(dt);
            DanhSachPhong();
        }

        private void dgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphong.Text = dgdanhsach.CurrentRow.Cells[0].Value.ToString();
            txttenphong.Text= dgdanhsach.CurrentRow.Cells[1].Value.ToString();
            cbtinhtrang.SelectedValue= dgdanhsach.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text= dgdanhsach.CurrentRow.Cells[3].Value.ToString();
            txtgiaphong.Text= dgdanhsach.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
