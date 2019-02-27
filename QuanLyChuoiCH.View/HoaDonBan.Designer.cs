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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labal1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_MaCH = new System.Windows.Forms.ComboBox();
            this.cmb_MaKH = new System.Windows.Forms.ComboBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_ThongTin = new System.Windows.Forms.RichTextBox();
            this.tableAdapterManager1 = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSetTableAdapters.TableAdapterManager();
            this.quanLyChuoiCuaHang2DataSet1 = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label2.Location = new System.Drawing.Point(463, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hóa Đơn : ";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(603, 48);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(182, 29);
            this.txt_MaHD.TabIndex = 3;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(463, 91);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(128, 21);
            this.d.TabIndex = 4;
            this.d.Text = "Mã Cửa Hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin HĐ : ";
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(463, 126);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(145, 21);
            this.labal1.TabIndex = 8;
            this.labal1.Text = "Mã Khách Hàng : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Nhân Viên : ";
            // 
            // cmb_MaCH
            // 
            this.cmb_MaCH.FormattingEnabled = true;
            this.cmb_MaCH.Location = new System.Drawing.Point(603, 83);
            this.cmb_MaCH.Name = "cmb_MaCH";
            this.cmb_MaCH.Size = new System.Drawing.Size(182, 29);
            this.cmb_MaCH.TabIndex = 11;
            // 
            // cmb_MaKH
            // 
            this.cmb_MaKH.FormattingEnabled = true;
            this.cmb_MaKH.Location = new System.Drawing.Point(603, 118);
            this.cmb_MaKH.Name = "cmb_MaKH";
            this.cmb_MaKH.Size = new System.Drawing.Size(182, 29);
            this.cmb_MaKH.TabIndex = 12;
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(603, 209);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(182, 29);
            this.cmb_MaNV.TabIndex = 13;
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(603, 158);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(160, 29);
            this.textBox2.TabIndex = 16;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(160, 29);
            this.textBox3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên Sản Phẩm : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Loại Sản Phẩm : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nhóm Sản Phẩm : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nhà Cung Cấp : ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(149, 261);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(160, 42);
            this.richTextBox2.TabIndex = 28;
            this.richTextBox2.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Thông Tin HĐ : ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(149, 309);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(160, 29);
            this.textBox8.TabIndex = 30;
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
            this.label12.Location = new System.Drawing.Point(9, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Số Lượng SP : ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(149, 344);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(160, 29);
            this.textBox9.TabIndex = 32;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(160, 29);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(160, 29);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(160, 29);
            this.textBox6.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 223);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 87);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ThongTin);
            this.Controls.Add(this.cmb_MaNV);
            this.Controls.Add(this.cmb_MaKH);
            this.Controls.Add(this.cmb_MaCH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.d);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "HoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmb_MaCH;
        private System.Windows.Forms.ComboBox cmb_MaKH;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.RichTextBox txt_ThongTin;
        private QuanLyChuoiCuaHang2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private QuanLyChuoiCuaHang2DataSet quanLyChuoiCuaHang2DataSet1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}