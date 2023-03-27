﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class ThongTinNguoiDungVay
    {
        private string danhXung;
        private string hoTen;
        private string cccd;
        private string diaChi;
        private string sdt;
        private string email;
        private string ngheNghiep;
        private string thuNhap;
        private string spVay;
        private string soTienVay;
        private string thoiGianVay;
        private string chiNhanhVay;
        private DateTime ngayVay;
        public string DanhXung
        {
            get { return danhXung; }
            set { danhXung = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string Cccd
        {
            get { return cccd; }
            set { cccd = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set
            {
                sdt = value;
            }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                diaChi = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public string NgheNghiep
        {
            get { return ngheNghiep; }
            set
            {
                ngheNghiep = value;
            }
        }
        public string ThuNhap
        {
            get { return thuNhap; }
            set
            {
                thuNhap = value;
            }
        }
        public string SpVay
        {
            get { return spVay; }
            set
            {
                spVay = value;
            }
        }
        public string SoTienVay
        {
            get { return soTienVay; }
            set
            {
                soTienVay = value;
            }
        }
        public string ThoiGianVay
        {
            get { return thoiGianVay; }
            set
            {
                thoiGianVay = value;
            }
        }
        public string ChiNhanhVay
        {
            get { return chiNhanhVay; }
            set
            {
                chiNhanhVay = value;
            }
        }
        public DateTime NgayVay
        {
            get { return ngayVay; }
            set
            {
                ngayVay = value;
            }
        }
        public ThongTinNguoiDungVay() { }
        public ThongTinNguoiDungVay(string danhXung, string hoTen, string cccd, string diaChi, string sdt, string email, string ngheNghiep, string thuNhap, string spVay, string soTienVay, string thoiGianVay, string chiNhanhVay, DateTime ngayVay)
        {
            this.danhXung = danhXung;
            this.hoTen = hoTen;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.ngheNghiep = ngheNghiep;
            this.thuNhap = thuNhap;
            this.spVay = spVay;
            this.soTienVay = soTienVay;
            this.thoiGianVay = thoiGianVay;
            this.chiNhanhVay = chiNhanhVay;
            this.ngayVay = ngayVay;
        }
    }
}