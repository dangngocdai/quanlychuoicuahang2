﻿namespace QuanLyChuoiCH.View
{
    partial class Sua_LoaiSP
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
            this.Rtxt_ThongTin = new System.Windows.Forms.RichTextBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.txt_TenNhom = new System.Windows.Forms.TextBox();
            this.txt_MaNhom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rtxt_ThongTin
            // 
            this.Rtxt_ThongTin.Location = new System.Drawing.Point(163, 149);
            this.Rtxt_ThongTin.Name = "Rtxt_ThongTin";
            this.Rtxt_ThongTin.Size = new System.Drawing.Size(208, 55);
            this.Rtxt_ThongTin.TabIndex = 719;
            this.Rtxt_ThongTin.Text = "";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(409, 158);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(115, 35);
            this.bt_Thoat.TabIndex = 718;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(404, 73);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(123, 64);
            this.bt_Them.TabIndex = 717;
            this.bt_Them.Text = "Sửa";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // txt_TenNhom
            // 
            this.txt_TenNhom.Location = new System.Drawing.Point(163, 111);
            this.txt_TenNhom.Name = "txt_TenNhom";
            this.txt_TenNhom.Size = new System.Drawing.Size(208, 29);
            this.txt_TenNhom.TabIndex = 716;
            // 
            // txt_MaNhom
            // 
            this.txt_MaNhom.Location = new System.Drawing.Point(163, 73);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.ReadOnly = true;
            this.txt_MaNhom.Size = new System.Drawing.Size(208, 29);
            this.txt_MaNhom.TabIndex = 720;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 715;
            this.label8.Text = "Thông Tin Loại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 714;
            this.label3.Text = "Tên Loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 713;
            this.label2.Text = "Mã Loại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 712;
            this.label1.Text = "Sửa Nhóm Sản Phẩm";
            // 
            // Sua_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 219);
            this.Controls.Add(this.Rtxt_ThongTin);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.txt_TenNhom);
            this.Controls.Add(this.txt_MaNhom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Sua_LoaiSP";
            this.Text = "Sửa Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.Sua_LoaiSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtxt_ThongTin;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.TextBox txt_TenNhom;
        private System.Windows.Forms.TextBox txt_MaNhom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}