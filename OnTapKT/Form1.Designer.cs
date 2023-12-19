
namespace OnTapKT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labLogo1 = new System.Windows.Forms.Label();
            this.labTen = new System.Windows.Forms.Label();
            this.labTenCSDL = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLogo1
            // 
            this.labLogo1.AutoSize = true;
            this.labLogo1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labLogo1.Location = new System.Drawing.Point(12, 9);
            this.labLogo1.Name = "labLogo1";
            this.labLogo1.Size = new System.Drawing.Size(215, 35);
            this.labLogo1.TabIndex = 0;
            this.labLogo1.Text = "Kết nối hệ thống...";
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(12, 72);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(67, 20);
            this.labTen.TabIndex = 1;
            this.labTen.Text = "Tên máy:";
            // 
            // labTenCSDL
            // 
            this.labTenCSDL.AutoSize = true;
            this.labTenCSDL.Location = new System.Drawing.Point(12, 109);
            this.labTenCSDL.Name = "labTenCSDL";
            this.labTenCSDL.Size = new System.Drawing.Size(74, 20);
            this.labTenCSDL.TabIndex = 2;
            this.labTenCSDL.Text = "Tên CSDL:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(12, 146);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(41, 20);
            this.labUser.TabIndex = 3;
            this.labUser.Text = "User:";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Location = new System.Drawing.Point(12, 182);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(73, 20);
            this.labPass.TabIndex = 4;
            this.labPass.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(316, 27);
            this.textBox4.TabIndex = 8;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(302, 246);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(94, 29);
            this.btnKetNoi.TabIndex = 9;
            this.btnKetNoi.Text = "kết nối...";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(414, 246);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát...";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 296);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labTenCSDL);
            this.Controls.Add(this.labTen);
            this.Controls.Add(this.labLogo1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLogo1;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label labTenCSDL;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnThoat;
    }
}

