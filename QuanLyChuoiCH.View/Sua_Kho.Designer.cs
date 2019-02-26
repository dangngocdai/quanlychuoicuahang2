namespace QuanLyChuoiCH.View
{
    partial class Sua_Kho
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
            this.Rtxt_DiaChi = new System.Windows.Forms.RichTextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_NgQuanLy = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.txt_TenKho = new System.Windows.Forms.TextBox();
            this.txt_MaKho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rtxt_DiaChi
            // 
            this.Rtxt_DiaChi.Location = new System.Drawing.Point(213, 157);
            this.Rtxt_DiaChi.Name = "Rtxt_DiaChi";
            this.Rtxt_DiaChi.Size = new System.Drawing.Size(208, 68);
            this.Rtxt_DiaChi.TabIndex = 74;
            this.Rtxt_DiaChi.Text = "";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(213, 238);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(208, 29);
            this.txt_SDT.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "SDT Kho : ";
            // 
            // cmb_NgQuanLy
            // 
            this.cmb_NgQuanLy.FormattingEnabled = true;
            this.cmb_NgQuanLy.Location = new System.Drawing.Point(213, 278);
            this.cmb_NgQuanLy.Name = "cmb_NgQuanLy";
            this.cmb_NgQuanLy.Size = new System.Drawing.Size(176, 29);
            this.cmb_NgQuanLy.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "Địa Chỉ : ";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(459, 202);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(115, 35);
            this.bt_Thoat.TabIndex = 69;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(451, 103);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(123, 64);
            this.bt_sua.TabIndex = 68;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // txt_TenKho
            // 
            this.txt_TenKho.Location = new System.Drawing.Point(213, 117);
            this.txt_TenKho.Name = "txt_TenKho";
            this.txt_TenKho.Size = new System.Drawing.Size(208, 29);
            this.txt_TenKho.TabIndex = 67;
            // 
            // txt_MaKho
            // 
            this.txt_MaKho.Location = new System.Drawing.Point(213, 79);
            this.txt_MaKho.Name = "txt_MaKho";
            this.txt_MaKho.ReadOnly = true;
            this.txt_MaKho.Size = new System.Drawing.Size(208, 29);
            this.txt_MaKho.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Người Quản Lý :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tên Kho :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã Kho :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sửa Kho";
            // 
            // Sua_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 342);
            this.Controls.Add(this.Rtxt_DiaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_NgQuanLy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.txt_TenKho);
            this.Controls.Add(this.txt_MaKho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sua_Kho";
            this.Text = "Sửa Kho";
            this.Load += new System.EventHandler(this.Sua_Kho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtxt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_NgQuanLy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txt_TenKho;
        private System.Windows.Forms.TextBox txt_MaKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}