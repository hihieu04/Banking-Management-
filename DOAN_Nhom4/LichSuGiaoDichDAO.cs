﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class LichSuGiaoDichDAO
    {
        DBConnection data = new DBConnection();
        public LichSuGiaoDichDAO() { }

        public void Them(GiaoDich gd)
        {
            string sqlGD = string.Format("INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian, SoTien, LoiNhan) OUTPUT INSERTED.MaGD VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}')",gd.LoaiGD, gd.NganHangGui, gd.TenTKGui, gd.SoTKGui, gd.NganHangNhan, gd.TenTKNhan, gd.SoTKNhan, DateTime.Now, gd.SoTien, gd.LoiNhan);
            data.xuLi(sqlGD);
        }

        public DataTable LichSuGiaoDichNhanNguoiDung(NguoiDung kh, int x)
        {
            string sqlStr = String.Format("SELECT MaGD, ThoiGian, NganHangGui, SoTKGui, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKNhan = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTK, x);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable LichSuGiaoDichGuiNguoiDung(NguoiDung kh, int x)
        {
            string sqlStr = String.Format("SELECT MaGD, ThoiGian, NganHangNhan, SoTKNhan, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKGui = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTK, x);
            return data.LayDanhSach(sqlStr);
        }
    }
}