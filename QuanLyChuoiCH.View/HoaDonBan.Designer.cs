namespace QuanLyChuoiCH.View
{
    partial class HoaDonBan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labal1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_MaKH = new System.Windows.Forms.ComboBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_ThongTin = new System.Windows.Forms.RichTextBox();
            this.tableAdapterManager1 = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSetTableAdapters.TableAdapterManager();
            this.quanLyChuoiCuaHang2DataSet1 = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSet();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ThongTinSP = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_BaoHanh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_LoaiSP = new System.Windows.Forms.TextBox();
            this.txt_NCC = new System.Windows.Forms.TextBox();
            this.num_SoSP = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_CH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bt_ThemKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.SoLuong,
            this.GiaBan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 70;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 200;
            // 
            // LoaiSP
            // 
            this.LoaiSP.HeaderText = "Loại Sản Phẩm";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 80;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hóa Đơn : ";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(605, 46);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(182, 29);
            this.txt_MaHD.TabIndex = 3;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(471, 89);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(99, 21);
            this.d.TabIndex = 4;
            this.d.Text = "Cửa Hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin HĐ : ";
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(471, 124);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(116, 21);
            this.labal1.TabIndex = 8;
            this.labal1.Text = "Khách Hàng : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Nhân Viên : ";
            // 
            // cmb_MaKH
            // 
            this.cmb_MaKH.FormattingEnabled = true;
            this.cmb_MaKH.Location = new System.Drawing.Point(605, 116);
            this.cmb_MaKH.Name = "cmb_MaKH";
            this.cmb_MaKH.Size = new System.Drawing.Size(182, 29);
            this.cmb_MaKH.TabIndex = 12;
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(605, 207);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(182, 29);
            this.cmb_MaNV.TabIndex = 13;
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(605, 156);
            this.txt_ThongTin.Name = "txt_ThongTin";
            this.txt_ThongTin.Size = new System.Drawing.Size(182, 42);
            this.txt_ThongTin.TabIndex = 14;
            this.txt_ThongTin.Text = "";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quanLyChuoiCuaHang2DataSet1
            // 
            this.quanLyChuoiCuaHang2DataSet1.DataSetName = "QuanLyChuoiCuaHang2DataSet";
            this.quanLyChuoiCuaHang2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(149, 48);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.ReadOnly = true;
            this.txt_MaSP.Size = new System.Drawing.Size(160, 29);
            this.txt_MaSP.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Sản Phẩm : ";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(149, 89);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.ReadOnly = true;
            this.txt_TenSP.Size = new System.Drawing.Size(160, 29);
            this.txt_TenSP.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên Sản Phẩm : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Loại Sản Phẩm : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nhà Cung Cấp : ";
            // 
            // txt_ThongTinSP
            // 
            this.txt_ThongTinSP.Location = new System.Drawing.Point(149, 261);
            this.txt_ThongTinSP.Name = "txt_ThongTinSP";
            this.txt_ThongTinSP.ReadOnly = true;
            this.txt_ThongTinSP.Size = new System.Drawing.Size(160, 42);
            this.txt_ThongTinSP.TabIndex = 28;
            this.txt_ThongTinSP.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Thông Tin SP : ";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(149, 309);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.ReadOnly = true;
            this.txt_GiaBan.Size = new System.Drawing.Size(160, 29);
            this.txt_GiaBan.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Giá Bán : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Số Lượng SP : ";
            // 
            // txt_BaoHanh
            // 
            this.txt_BaoHanh.Location = new System.Drawing.Point(149, 344);
            this.txt_BaoHanh.Name = "txt_BaoHanh";
            this.txt_BaoHanh.ReadOnly = true;
            this.txt_BaoHanh.Size = new System.Drawing.Size(160, 29);
            this.txt_BaoHanh.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Bảo Hành : ";
            // 
            // txt_LoaiSP
            // 
            this.txt_LoaiSP.Location = new System.Drawing.Point(149, 130);
            this.txt_LoaiSP.Name = "txt_LoaiSP";
            this.txt_LoaiSP.ReadOnly = true;
            this.txt_LoaiSP.Size = new System.Drawing.Size(160, 29);
            this.txt_LoaiSP.TabIndex = 20;
            // 
            // txt_NCC
            // 
            this.txt_NCC.Location = new System.Drawing.Point(149, 171);
            this.txt_NCC.Name = "txt_NCC";
            this.txt_NCC.ReadOnly = true;
            this.txt_NCC.Size = new System.Drawing.Size(160, 29);
            this.txt_NCC.TabIndex = 24;
            // 
            // num_SoSP
            // 
            this.num_SoSP.Location = new System.Drawing.Point(149, 214);
            this.num_SoSP.Name = "num_SoSP";
            this.num_SoSP.Size = new System.Drawing.Size(120, 29);
            this.num_SoSP.TabIndex = 33;
            this.num_SoSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 87);
            this.button1.TabIndex = 34;
            this.button1.Text = "Chọn Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_CH
            // 
            this.txt_CH.Location = new System.Drawing.Point(605, 81);
            this.txt_CH.Name = "txt_CH";
            this.txt_CH.ReadOnly = true;
            this.txt_CH.Size = new System.Drawing.Size(226, 29);
            this.txt_CH.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(663, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 68);
            this.button2.TabIndex = 36;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 55);
            this.button3.TabIndex = 37;
            this.button3.Text = "Thêm Vào Giỏ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 101);
            this.button4.TabIndex = 38;
            this.button4.Text = "Xóa Sản Phẩm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(663, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 55);
            this.button5.TabIndex = 39;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_ThemKH
            // 
            this.bt_ThemKH.BackgroundImage = global::QuanLyChuoiCH.View.Properties.Resources.plus_black_symbol;
            this.bt_ThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_ThemKH.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_ThemKH.Location = new System.Drawing.Point(794, 114);
            this.bt_ThemKH.Name = "bt_ThemKH";
            this.bt_ThemKH.Size = new System.Drawing.Size(37, 32);
            this.bt_ThemKH.TabIndex = 40;
            this.bt_ThemKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_ThemKH.UseVisualStyleBackColor = true;
            this.bt_ThemKH.Click += new System.EventHandler(this.bt_ThemKH_Click);
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 583);
            this.Controls.Add(this.bt_ThemKH);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_CH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_SoSP);
            this.Controls.Add(this.txt_BaoHanh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_ThongTinSP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_NCC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_LoaiSP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ThongTin);
            this.Controls.Add(this.cmb_MaNV);
            this.Controls.Add(this.cmb_MaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.d);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_MaKH;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.RichTextBox txt_ThongTin;
        private QuanLyChuoiCuaHang2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private QuanLyChuoiCuaHang2DataSet quanLyChuoiCuaHang2DataSet1;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txt_ThongTinSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_BaoHanh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_LoaiSP;
        private System.Windows.Forms.TextBox txt_NCC;
        private System.Windows.Forms.NumericUpDown num_SoSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_CH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bt_ThemKH;
    }
}