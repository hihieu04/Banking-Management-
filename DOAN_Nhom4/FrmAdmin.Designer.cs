﻿namespace DOAN_Nhom4
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.gvQLKH = new System.Windows.Forms.DataGridView();
            this.txt_NgayDangKyThe = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Them = new CustomButton.VBButton();
            this.btn_Xoa = new CustomButton.VBButton();
            this.btn_Sua = new CustomButton.VBButton();
            this.btn_DichVu = new CustomButton.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1909, 114);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(850, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NGÂN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(907, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenDN.Location = new System.Drawing.Point(67, 208);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(244, 30);
            this.txt_TenDN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(67, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật Khẩu";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhau.Location = new System.Drawing.Point(67, 288);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(244, 30);
            this.txt_MatKhau.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(67, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Tài Khoản";
            // 
            // txt_SoTK
            // 
            this.txt_SoTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoTK.Location = new System.Drawing.Point(67, 367);
            this.txt_SoTK.Name = "txt_SoTK";
            this.txt_SoTK.Size = new System.Drawing.Size(244, 30);
            this.txt_SoTK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(67, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên Tài Khoản";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenTK.Location = new System.Drawing.Point(67, 446);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(244, 30);
            this.txt_TenTK.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(67, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Căn Cước Công Dân";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CCCD.Location = new System.Drawing.Point(67, 595);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(244, 30);
            this.txt_CCCD.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(67, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số Điện Thoại";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.Location = new System.Drawing.Point(67, 675);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(244, 30);
            this.txt_SDT.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(67, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày Sinh";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.CustomFormat = "MM/dd/yyyy";
            this.txt_NgaySinh.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgaySinh.Location = new System.Drawing.Point(67, 524);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(244, 28);
            this.txt_NgaySinh.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(67, 799);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số Tiền";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoDu.Location = new System.Drawing.Point(67, 825);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(244, 30);
            this.txt_SoDu.TabIndex = 19;
            // 
            // gvQLKH
            // 
            this.gvQLKH.BackgroundColor = System.Drawing.Color.White;
            this.gvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQLKH.Location = new System.Drawing.Point(409, 230);
            this.gvQLKH.Name = "gvQLKH";
            this.gvQLKH.RowHeadersWidth = 51;
            this.gvQLKH.RowTemplate.Height = 29;
            this.gvQLKH.Size = new System.Drawing.Size(1379, 516);
            this.gvQLKH.TabIndex = 21;
            this.gvQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQLKH_CellClick);
            // 
            // txt_NgayDangKyThe
            // 
            this.txt_NgayDangKyThe.CustomFormat = "MM/dd/yyyy";
            this.txt_NgayDangKyThe.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDangKyThe.Location = new System.Drawing.Point(67, 904);
            this.txt_NgayDangKyThe.Name = "txt_NgayDangKyThe";
            this.txt_NgayDangKyThe.Size = new System.Drawing.Size(244, 28);
            this.txt_NgayDangKyThe.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(67, 878);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ngày Đăng Ký Thẻ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(67, 723);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(67, 749);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(244, 30);
            this.txt_Email.TabIndex = 24;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Teal;
            this.btn_Them.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(473, 785);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(201, 60);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Teal;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(964, 785);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(201, 60);
            this.btn_Xoa.TabIndex = 27;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Teal;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1479, 785);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(201, 60);
            this.btn_Sua.TabIndex = 28;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_DichVu.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btn_DichVu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DichVu.BorderRadius = 20;
            this.btn_DichVu.BorderSize = 0;
            this.btn_DichVu.FlatAppearance.BorderSize = 0;
            this.btn_DichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DichVu.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DichVu.ForeColor = System.Drawing.Color.White;
            this.btn_DichVu.Location = new System.Drawing.Point(964, 878);
            this.btn_DichVu.Name = "btn_DichVu";
            this.btn_DichVu.Size = new System.Drawing.Size(201, 60);
            this.btn_DichVu.TabIndex = 30;
            this.btn_DichVu.Text = "Dịch Vụ Khác";
            this.btn_DichVu.TextColor = System.Drawing.Color.White;
            this.btn_DichVu.UseVisualStyleBackColor = false;
            this.btn_DichVu.Click += new System.EventHandler(this.btn_DichVu_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1909, 982);
            this.Controls.Add(this.btn_DichVu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_NgayDangKyThe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gvQLKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_SoDu);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SoTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_TenDN;
        private Label label3;
        private Label label4;
        private TextBox txt_MatKhau;
        private Label label5;
        private TextBox txt_SoTK;
        private Label label6;
        private TextBox txt_TenTK;
        private Label label7;
        private TextBox txt_CCCD;
        private Label label8;
        private TextBox txt_SDT;
        private Label label9;
        private DateTimePicker txt_NgaySinh;
        private Label label10;
        private TextBox txt_SoDu;
        private DataGridView gvQLKH;
        private DateTimePicker txt_NgayDangKyThe;
        private Label label11;
        private Label label12;
        private TextBox txt_Email;
        private CustomButton.VBButton btn_Them;
        private CustomButton.VBButton btn_Xoa;
        private CustomButton.VBButton btn_Sua;
        private CustomButton.VBButton btn_DichVu;
    }
}