﻿namespace QuanLyChuoiCH.View
{
    partial class CuaHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNgQuanLyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuaHangLayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyChuoiCuaHang2DataSet = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cuaHang_LayTableAdapter = new QuanLyChuoiCH.View.QuanLyChuoiCuaHang2DataSetTableAdapters.CuaHang_LayTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công Cụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(111, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCHDataGridViewTextBoxColumn,
            this.tenCHDataGridViewTextBoxColumn,
            this.sDTCHDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.maNgQuanLyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuaHangLayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(555, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // maCHDataGridViewTextBoxColumn
            // 
            this.maCHDataGridViewTextBoxColumn.DataPropertyName = "MaCH";
            this.maCHDataGridViewTextBoxColumn.HeaderText = "Mã Cửa Hàng";
            this.maCHDataGridViewTextBoxColumn.Name = "maCHDataGridViewTextBoxColumn";
            this.maCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenCHDataGridViewTextBoxColumn
            // 
            this.tenCHDataGridViewTextBoxColumn.DataPropertyName = "TenCH";
            this.tenCHDataGridViewTextBoxColumn.HeaderText = "Tên Cửa Hàng";
            this.tenCHDataGridViewTextBoxColumn.Name = "tenCHDataGridViewTextBoxColumn";
            this.tenCHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenCHDataGridViewTextBoxColumn.Width = 110;
            // 
            // sDTCHDataGridViewTextBoxColumn
            // 
            this.sDTCHDataGridViewTextBoxColumn.DataPropertyName = "SDTCH";
            this.sDTCHDataGridViewTextBoxColumn.HeaderText = "SDT ";
            this.sDTCHDataGridViewTextBoxColumn.Name = "sDTCHDataGridViewTextBoxColumn";
            this.sDTCHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTCHDataGridViewTextBoxColumn.Width = 90;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNgQuanLyDataGridViewTextBoxColumn
            // 
            this.maNgQuanLyDataGridViewTextBoxColumn.DataPropertyName = "MaNgQuanLy";
            this.maNgQuanLyDataGridViewTextBoxColumn.HeaderText = "Người Quản Lý";
            this.maNgQuanLyDataGridViewTextBoxColumn.Name = "maNgQuanLyDataGridViewTextBoxColumn";
            this.maNgQuanLyDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNgQuanLyDataGridViewTextBoxColumn.Width = 110;
            // 
            // cuaHangLayBindingSource
            // 
            this.cuaHangLayBindingSource.DataMember = "CuaHang_Lay";
            this.cuaHangLayBindingSource.DataSource = this.quanLyChuoiCuaHang2DataSet;
            // 
            // quanLyChuoiCuaHang2DataSet
            // 
            this.quanLyChuoiCuaHang2DataSet.DataSetName = "QuanLyChuoiCuaHang2DataSet";
            this.quanLyChuoiCuaHang2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(44, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm Cửa Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(44, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sửa Cửa Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(44, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 68);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xóa Cửa Hàng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cuaHang_LayTableAdapter
            // 
            this.cuaHang_LayTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(602, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "Quản Lý";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 457);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Của Hàng";
            this.Load += new System.EventHandler(this.CuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangLayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyChuoiCuaHang2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private QuanLyChuoiCuaHang2DataSet quanLyChuoiCuaHang2DataSet;
        private System.Windows.Forms.BindingSource cuaHangLayBindingSource;
        private QuanLyChuoiCuaHang2DataSetTableAdapters.CuaHang_LayTableAdapter cuaHang_LayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNgQuanLyDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}