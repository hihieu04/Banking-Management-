﻿using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DOAN_Nhom4
{
    public partial class ChuyenTien : UserControl
    {
        public ChuyenTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        NguoiDungDAO ndDAO = new NguoiDungDAO();
        ChuyenTienDAO chuyentienDAO = new ChuyenTienDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public void HienThiThongTinNguoiChuyen()
        {
            KhachHang ngDung = new KhachHang();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = ndDAO.LayKhachHang(txtSoTKChuyen.Text,"HHB");           
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSoTKChuyen.Text, "TenNH", "HHB");
            if (ngDung != null)
            {
                txtTenTKChuyen.Text = ngDung.TenKh.ToString();
                txtCCCD.Text = ngDung.Cccd.ToString();
                txtSDT.Text = ngDung.Sdt.ToString();
                lblSoDu.Text = tk.SoDu.ToString("N0") + " VNĐ";
            }
            else
            {
                txtTenTKChuyen.Text = "Khong ton tai";
                txtCCCD.Text = "";
                txtSDT.Text = "";
                lblSoDu.Text = "-";
            }
        }

        public void HienThiThongTinNguoiNhan()
        {
            KhachHang ngDungNhan = new KhachHang();
            ngDungNhan = ndDAO.LayKhachHang(txtSoTKNhan.Text, cbTenNH.Text);
            if (ngDungNhan != null)
            {
                txtTenTKNhan.Text = ngDungNhan.TenKh.ToString();
            }
            else
            {
                txtTenTKNhan.Text = "Khong ton tai";
            }
        }
        public void HienThiThongTinNguoiNhanCoDieuKien()
        {
            KhachHang ngDungNhan = new KhachHang();
            ngDungNhan = ndDAO.LayKhachHang(txtSoTKNhan.Text, cbTenNH.Text);
            KhachHang ngDungChuyen = new KhachHang();
            ngDungChuyen = ndDAO.LayKhachHang(txtSoTKChuyen.Text, "HHB");
            if (ngDungNhan != null)
            {
                if (ngDungChuyen.TenNh == ngDungNhan.TenNh && ngDungChuyen.SoTk == ngDungNhan.SoTk)
                    txtTenTKNhan.Text = "Khong duoc chuyen cho chinh minh";
                else
                    txtTenTKNhan.Text = ngDungNhan.TenKh.ToString();
            }
            else
            {
                txtTenTKNhan.Text = "Khong ton tai";
            }
        }
        private void txt_SoTKChuyen_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTinNguoiChuyen();
        }

        private void txt_SoTKNhan_TextChanged(object sender, EventArgs e)
        {
            if(txtSoTKChuyen.Text == "")
            {
                HienThiThongTinNguoiNhan();
            }
            else
            {
                HienThiThongTinNguoiNhanCoDieuKien();
            }
        }

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkGui = new TaiKhoanNganHang();
            tkGui = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSoTKChuyen.Text, "TenNH", "HHB");
            KhachHang ndGui = new KhachHang();
            ndGui = ndDAO.LayKhachHang(txtSoTKChuyen.Text, "HHB");
            TaiKhoanNganHang tkNhan = new TaiKhoanNganHang();
            tkNhan = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSoTKNhan.Text, "TenNH", cbTenNH.Text);
            KhachHang ndNhan = new KhachHang();
            ndNhan = ndDAO.LayKhachHang(txtSoTKNhan.Text, cbTenNH.Text);
            GiaoDich gd = new GiaoDich("Chuyen Tien", tkGui.TenNH, ndGui.TenKh, tkGui.SoTK, tkNhan.TenNH, ndNhan.TenKh, tkNhan.SoTK, decimal.Parse(txtSoTien.Text), txtLoiNhan.Text);
            if (tkGui != null)
            {
                if (tkNhan != null)
                {
                    if (tkGui.TenNH != tkNhan.TenNH|| tkGui.TenNH == tkNhan.TenNH && tkGui.SoTK != tkNhan.SoTK)
                    {
                        if (gd.SoTien >= 10000 && gd.SoTien <= tkGui.SoDu)
                        {
                            chuyentienDAO.ChuyenTien(tkGui, gd, tkNhan);
                            lsgdDAO.Them(gd);
                            txtSoTKNhan.Text = "";
                            txtSoTKChuyen.Text = "";
                            cbTenNH.Text = "HHB";
                            txtSoTien.Text = "";
                            txtCCCD.Text = "";
                            txtSDT.Text = "";
                            txtLoiNhan.Text = "";
                            MessageBox.Show("Chuyển tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Số tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Khong the thuc hien giao dich. Kiem tra lai !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }      
            }
            else
                MessageBox.Show("Số tài khoản chuyển không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            txtSoTKChuyen.Text = "";
            txtSoTien.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtTenTKNhan.Text = "";
            txtTenTKChuyen.Text = "";
            txtTenTKNhan.Text = "";
            cbTenNH.Text = "HHB";
            lblSoDu.Text = "-";
            txtLoiNhan.Text = "";
        }
    }
}
