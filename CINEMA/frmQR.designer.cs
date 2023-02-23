using System.Windows.Forms;

namespace CINEMA
{
    partial class frmQR
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
            this.btnMoMo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMoMo
            // 
            this.btnMoMo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoMo.BackColor = System.Drawing.Color.SeaShell;
            this.btnMoMo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoMo.ForeColor = System.Drawing.Color.Brown;
            this.btnMoMo.Location = new System.Drawing.Point(168, 634);
            this.btnMoMo.Name = "btnMoMo";
            this.btnMoMo.Size = new System.Drawing.Size(280, 79);
            this.btnMoMo.TabIndex = 5;
            this.btnMoMo.Text = "Thanh toán Thành công!";
            this.btnMoMo.UseVisualStyleBackColor = false;
            this.btnMoMo.Click += new System.EventHandler(this.btnMoMo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CINEMA.Properties.Resources.momone;
            this.pictureBox2.Location = new System.Drawing.Point(214, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_qrcode.Location = new System.Drawing.Point(179, 306);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(250, 250);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_qrcode.TabIndex = 3;
            this.pic_qrcode.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CINEMA.Properties.Resources.momo_brand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quý khách vui lòng Quét Mã Thanh toán\r\nvà Xuất trình cho Nhân viên Đặt vé";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(25, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cảm ơn Quý Khách đã Sử dụng Dịch vụ!";
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(605, 754);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMoMo);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQR";
            this.Text = "frmQR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMoMo;
        internal System.Windows.Forms.PictureBox pic_qrcode;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}