﻿namespace DOAN_Nhom4
{
    partial class FrmAdminDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_QuayLai = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ChuyenTien = new CustomButton.VBButton();
            this.btn_RutTien = new CustomButton.VBButton();
            this.btn_NapTien = new CustomButton.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pb_QuayLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 205);
            this.panel1.TabIndex = 32;
            // 
            // pb_QuayLai
            // 
            this.pb_QuayLai.Image = ((System.Drawing.Image)(resources.GetObject("pb_QuayLai.Image")));
            this.pb_QuayLai.Location = new System.Drawing.Point(-3, 5);
            this.pb_QuayLai.Margin = new System.Windows.Forms.Padding(5);
            this.pb_QuayLai.Name = "pb_QuayLai";
            this.pb_QuayLai.Size = new System.Drawing.Size(86, 77);
            this.pb_QuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QuayLai.TabIndex = 25;
            this.pb_QuayLai.TabStop = false;
            this.pb_QuayLai.Click += new System.EventHandler(this.pb_QuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(629, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "DỊCH VỤ NGÂN HÀNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btn_ChuyenTien);
            this.panel2.Controls.Add(this.btn_RutTien);
            this.panel2.Controls.Add(this.btn_NapTien);
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 867);
            this.panel2.TabIndex = 33;
            // 
            // btn_ChuyenTien
            // 
            this.btn_ChuyenTien.BackColor = System.Drawing.Color.Teal;
            this.btn_ChuyenTien.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_ChuyenTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ChuyenTien.BorderRadius = 0;
            this.btn_ChuyenTien.BorderSize = 0;
            this.btn_ChuyenTien.FlatAppearance.BorderSize = 0;
            this.btn_ChuyenTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenTien.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChuyenTien.ForeColor = System.Drawing.Color.White;
            this.btn_ChuyenTien.Location = new System.Drawing.Point(0, 689);
            this.btn_ChuyenTien.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChuyenTien.Name = "btn_ChuyenTien";
            this.btn_ChuyenTien.Size = new System.Drawing.Size(312, 178);
            this.btn_ChuyenTien.TabIndex = 43;
            this.btn_ChuyenTien.Text = "Chuyển Tiền";
            this.btn_ChuyenTien.TextColor = System.Drawing.Color.White;
            this.btn_ChuyenTien.UseVisualStyleBackColor = false;
            this.btn_ChuyenTien.Click += new System.EventHandler(this.btn_ChuyenTien_Click);
            // 
            // btn_RutTien
            // 
            this.btn_RutTien.BackColor = System.Drawing.Color.Teal;
            this.btn_RutTien.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_RutTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_RutTien.BorderRadius = 0;
            this.btn_RutTien.BorderSize = 0;
            this.btn_RutTien.FlatAppearance.BorderSize = 0;
            this.btn_RutTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RutTien.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RutTien.ForeColor = System.Drawing.Color.White;
            this.btn_RutTien.Location = new System.Drawing.Point(0, 330);
            this.btn_RutTien.Margin = new System.Windows.Forms.Padding(5);
            this.btn_RutTien.Name = "btn_RutTien";
            this.btn_RutTien.Size = new System.Drawing.Size(312, 178);
            this.btn_RutTien.TabIndex = 42;
            this.btn_RutTien.Text = "Rút Tiền";
            this.btn_RutTien.TextColor = System.Drawing.Color.White;
            this.btn_RutTien.UseVisualStyleBackColor = false;
            this.btn_RutTien.Click += new System.EventHandler(this.btn_RutTien_Click);
            // 
            // btn_NapTien
            // 
            this.btn_NapTien.BackColor = System.Drawing.Color.Teal;
            this.btn_NapTien.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_NapTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_NapTien.BorderRadius = 0;
            this.btn_NapTien.BorderSize = 0;
            this.btn_NapTien.FlatAppearance.BorderSize = 0;
            this.btn_NapTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NapTien.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NapTien.ForeColor = System.Drawing.Color.White;
            this.btn_NapTien.Location = new System.Drawing.Point(0, 0);
            this.btn_NapTien.Margin = new System.Windows.Forms.Padding(5);
            this.btn_NapTien.Name = "btn_NapTien";
            this.btn_NapTien.Size = new System.Drawing.Size(312, 178);
            this.btn_NapTien.TabIndex = 41;
            this.btn_NapTien.Text = "Nạp Tiền";
            this.btn_NapTien.TextColor = System.Drawing.Color.White;
            this.btn_NapTien.UseVisualStyleBackColor = false;
            this.btn_NapTien.Click += new System.EventHandler(this.btn_NapTien_Click);
            // 
            // FrmAdminDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1598, 1070);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAdminDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmAdminDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private CustomButton.VBButton btn_NapTien;
        private CustomButton.VBButton btn_ChuyenTien;
        private CustomButton.VBButton btn_RutTien;
        private PictureBox pb_QuayLai;
    }
}