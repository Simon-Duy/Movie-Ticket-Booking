namespace CINEMA.frmAdminUserControls.DataUserControl
{
    partial class TicketsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllListShowTimes = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowShowTimeNotCreateTickets = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAllTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAllTicketsBoughtByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.panel61.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel61
            // 
            this.panel61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel61.Controls.Add(this.btnShowAllTicketsBoughtByShowTime);
            this.panel61.Controls.Add(this.btnShowAllTicketsByShowTime);
            this.panel61.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.panel61.Controls.Add(this.btnAllListShowTimes);
            this.panel61.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel61.Controls.Add(this.btnAddTicketsByShowTime);
            this.panel61.Controls.Add(this.pictureBox1);
            this.panel61.Controls.Add(this.pictureBox2);
            this.panel61.Controls.Add(this.pictureBox3);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(1742, 80);
            this.panel61.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvAllListShowTimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(967, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 718);
            this.panel1.TabIndex = 11;
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(8, 9);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(746, 704);
            this.lsvAllListShowTimes.TabIndex = 9;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.SelectedIndexChanged += new System.EventHandler(this.lsvAllListShowTimes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.Width = 100;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToAddRows = false;
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 80);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 62;
            this.dtgvTicket.Size = new System.Drawing.Size(967, 718);
            this.dtgvTicket.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CINEMA.Properties.Resources._269853859_1391744411260800_8370556548525559817_n;
            this.pictureBox1.Location = new System.Drawing.Point(1493, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CINEMA.Properties.Resources._269853859_1391744411260800_8370556548525559817_n;
            this.pictureBox2.Location = new System.Drawing.Point(1355, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CINEMA.Properties.Resources._269863112_894352301445920_4818318561976082630_n1;
            this.pictureBox3.Location = new System.Drawing.Point(1421, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.Animated = true;
            this.btnAddTicketsByShowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTicketsByShowTime.BorderRadius = 10;
            this.btnAddTicketsByShowTime.FillColor = System.Drawing.Color.DarkGray;
            this.btnAddTicketsByShowTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicketsByShowTime.ForeColor = System.Drawing.Color.White;
            this.btnAddTicketsByShowTime.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(2, 2);
            this.btnAddTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(177, 74);
            this.btnAddTicketsByShowTime.TabIndex = 40;
            this.btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu";
            this.btnAddTicketsByShowTime.UseTransparentBackground = true;
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click_1);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Animated = true;
            this.btnDeleteTicketsByShowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTicketsByShowTime.BorderRadius = 10;
            this.btnDeleteTicketsByShowTime.FillColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTicketsByShowTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicketsByShowTime.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTicketsByShowTime.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(187, 2);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(177, 74);
            this.btnDeleteTicketsByShowTime.TabIndex = 64;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseTransparentBackground = true;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click_1);
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Animated = true;
            this.btnAllListShowTimes.BackColor = System.Drawing.Color.Transparent;
            this.btnAllListShowTimes.BorderRadius = 10;
            this.btnAllListShowTimes.FillColor = System.Drawing.Color.DarkGray;
            this.btnAllListShowTimes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllListShowTimes.ForeColor = System.Drawing.Color.White;
            this.btnAllListShowTimes.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAllListShowTimes.Location = new System.Drawing.Point(927, 6);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(177, 74);
            this.btnAllListShowTimes.TabIndex = 65;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu";
            this.btnAllListShowTimes.UseTransparentBackground = true;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click_1);
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.Animated = true;
            this.btnShowShowTimeNotCreateTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnShowShowTimeNotCreateTickets.BorderRadius = 10;
            this.btnShowShowTimeNotCreateTickets.FillColor = System.Drawing.Color.DarkGray;
            this.btnShowShowTimeNotCreateTickets.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowShowTimeNotCreateTickets.ForeColor = System.Drawing.Color.White;
            this.btnShowShowTimeNotCreateTickets.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(742, 5);
            this.btnShowShowTimeNotCreateTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(177, 74);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 66;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowShowTimeNotCreateTickets.UseTransparentBackground = true;
            this.btnShowShowTimeNotCreateTickets.Click += new System.EventHandler(this.btnShowShowTimeNotCreateTickets_Click_1);
            // 
            // btnShowAllTicketsByShowTime
            // 
            this.btnShowAllTicketsByShowTime.Animated = true;
            this.btnShowAllTicketsByShowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllTicketsByShowTime.BorderRadius = 10;
            this.btnShowAllTicketsByShowTime.FillColor = System.Drawing.Color.DarkGray;
            this.btnShowAllTicketsByShowTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTicketsByShowTime.ForeColor = System.Drawing.Color.White;
            this.btnShowAllTicketsByShowTime.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAllTicketsByShowTime.Location = new System.Drawing.Point(557, 5);
            this.btnShowAllTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            this.btnShowAllTicketsByShowTime.Size = new System.Drawing.Size(177, 74);
            this.btnShowAllTicketsByShowTime.TabIndex = 67;
            this.btnShowAllTicketsByShowTime.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnShowAllTicketsByShowTime.UseTransparentBackground = true;
            this.btnShowAllTicketsByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsByShowTime_Click_1);
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            this.btnShowAllTicketsBoughtByShowTime.Animated = true;
            this.btnShowAllTicketsBoughtByShowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllTicketsBoughtByShowTime.BorderRadius = 10;
            this.btnShowAllTicketsBoughtByShowTime.FillColor = System.Drawing.Color.DarkGray;
            this.btnShowAllTicketsBoughtByShowTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTicketsBoughtByShowTime.ForeColor = System.Drawing.Color.White;
            this.btnShowAllTicketsBoughtByShowTime.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAllTicketsBoughtByShowTime.Location = new System.Drawing.Point(372, 6);
            this.btnShowAllTicketsBoughtByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            this.btnShowAllTicketsBoughtByShowTime.Size = new System.Drawing.Size(177, 74);
            this.btnShowAllTicketsBoughtByShowTime.TabIndex = 68;
            this.btnShowAllTicketsBoughtByShowTime.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnShowAllTicketsBoughtByShowTime.UseTransparentBackground = true;
            this.btnShowAllTicketsBoughtByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsBoughtByShowTime_Click_1);
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel61);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1742, 798);
            this.panel61.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnAddTicketsByShowTime;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTicketsByShowTime;
        private Guna.UI2.WinForms.Guna2Button btnAllListShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnShowShowTimeNotCreateTickets;
        private Guna.UI2.WinForms.Guna2Button btnShowAllTicketsByShowTime;
        private Guna.UI2.WinForms.Guna2Button btnShowAllTicketsBoughtByShowTime;
    }
}
