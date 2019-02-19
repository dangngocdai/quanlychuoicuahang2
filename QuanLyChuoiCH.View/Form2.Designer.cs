namespace QuanLyChuoiCH.View
{
    partial class Form2
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
            this.txt_MaKho = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_TenKho = new System.Windows.Forms.TextBox();
            this.Txt_DiaChi = new System.Windows.Forms.TextBox();
            this.Txt_SDTKho = new System.Windows.Forms.TextBox();
            this.Txt_MaNgQuanLy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_MaKho
            // 
            this.txt_MaKho.Location = new System.Drawing.Point(180, 48);
            this.txt_MaKho.Name = "txt_MaKho";
            this.txt_MaKho.Size = new System.Drawing.Size(173, 20);
            this.txt_MaKho.TabIndex = 0;
            this.txt_MaKho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_TenKho
            // 
            this.txt_TenKho.Location = new System.Drawing.Point(180, 97);
            this.txt_TenKho.Name = "txt_TenKho";
            this.txt_TenKho.Size = new System.Drawing.Size(173, 20);
            this.txt_TenKho.TabIndex = 2;
            // 
            // Txt_DiaChi
            // 
            this.Txt_DiaChi.Location = new System.Drawing.Point(180, 132);
            this.Txt_DiaChi.Name = "Txt_DiaChi";
            this.Txt_DiaChi.Size = new System.Drawing.Size(173, 20);
            this.Txt_DiaChi.TabIndex = 3;
            // 
            // Txt_SDTKho
            // 
            this.Txt_SDTKho.Location = new System.Drawing.Point(180, 180);
            this.Txt_SDTKho.Name = "Txt_SDTKho";
            this.Txt_SDTKho.Size = new System.Drawing.Size(173, 20);
            this.Txt_SDTKho.TabIndex = 4;
            // 
            // Txt_MaNgQuanLy
            // 
            this.Txt_MaNgQuanLy.Location = new System.Drawing.Point(180, 223);
            this.Txt_MaNgQuanLy.Name = "Txt_MaNgQuanLy";
            this.Txt_MaNgQuanLy.Size = new System.Drawing.Size(173, 20);
            this.Txt_MaNgQuanLy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MaKho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TenKho";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DiaChi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SDTKho";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MaNgQuanLy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_MaNgQuanLy);
            this.Controls.Add(this.Txt_SDTKho);
            this.Controls.Add(this.Txt_DiaChi);
            this.Controls.Add(this.txt_TenKho);
            this.Controls.Add(this.txt_MaKho);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaKho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_TenKho;
        private System.Windows.Forms.TextBox Txt_DiaChi;
        private System.Windows.Forms.TextBox Txt_SDTKho;
        private System.Windows.Forms.TextBox Txt_MaNgQuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}