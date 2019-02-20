namespace QuanLyChuoiCH.View
{
    partial class Them_CuaHang
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
            this.txt_MaCH = new System.Windows.Forms.TextBox();
            this.txt_TenCH = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.Cmb_QuanLy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.RichTextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_MaCH
            // 
            this.txt_MaCH.Location = new System.Drawing.Point(232, 74);
            this.txt_MaCH.Name = "txt_MaCH";
            this.txt_MaCH.Size = new System.Drawing.Size(223, 20);
            this.txt_MaCH.TabIndex = 0;
            this.txt_MaCH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_TenCH
            // 
            this.txt_TenCH.Location = new System.Drawing.Point(232, 112);
            this.txt_TenCH.Name = "txt_TenCH";
            this.txt_TenCH.Size = new System.Drawing.Size(223, 20);
            this.txt_TenCH.TabIndex = 1;
            this.txt_TenCH.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(232, 151);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(223, 20);
            this.txt_SDT.TabIndex = 2;
            this.txt_SDT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Cmb_QuanLy
            // 
            this.Cmb_QuanLy.FormattingEnabled = true;
            this.Cmb_QuanLy.Location = new System.Drawing.Point(232, 283);
            this.Cmb_QuanLy.Name = "Cmb_QuanLy";
            this.Cmb_QuanLy.Size = new System.Drawing.Size(168, 21);
            this.Cmb_QuanLy.TabIndex = 4;
            this.Cmb_QuanLy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm Cửa Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Cửa Hàng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Cửa Hàng :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT Cửa Hàng :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Người Quản Lý :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(232, 189);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(223, 69);
            this.txt_DiaChi.TabIndex = 11;
            this.txt_DiaChi.Text = "";
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(510, 74);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(111, 45);
            this.bt_Them.TabIndex = 12;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(510, 164);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(111, 44);
            this.bt_Thoat.TabIndex = 13;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // Them_CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 340);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_QuanLy);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenCH);
            this.Controls.Add(this.txt_MaCH);
            this.Name = "Them_CuaHang";
            this.Text = "Thêm Cửa Hàng";
            this.Load += new System.EventHandler(this.Them_CuaHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaCH;
        private System.Windows.Forms.TextBox txt_TenCH;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.ComboBox Cmb_QuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_DiaChi;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Thoat;
    }
}