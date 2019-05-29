namespace DemoWinform.Views
{
    partial class HoatDong
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
            this.data = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.addedit = new System.Windows.Forms.Panel();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kinhphi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenhd = new System.Windows.Forms.TextBox();
            this.idNganSach = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.addedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(333, 65);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(675, 469);
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.TabIndex = 7;
            this.data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellDoubleClick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(201, 243);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(50, 243);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Thêm";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // addedit
            // 
            this.addedit.Controls.Add(this.end);
            this.addedit.Controls.Add(this.label8);
            this.addedit.Controls.Add(this.start);
            this.addedit.Controls.Add(this.label7);
            this.addedit.Controls.Add(this.label6);
            this.addedit.Controls.Add(this.kinhphi);
            this.addedit.Controls.Add(this.label9);
            this.addedit.Controls.Add(this.label4);
            this.addedit.Controls.Add(this.tenhd);
            this.addedit.Controls.Add(this.idNganSach);
            this.addedit.Controls.Add(this.cancel);
            this.addedit.Controls.Add(this.delete);
            this.addedit.Controls.Add(this.submit);
            this.addedit.Controls.Add(this.label2);
            this.addedit.Dock = System.Windows.Forms.DockStyle.Left;
            this.addedit.Location = new System.Drawing.Point(0, 0);
            this.addedit.Name = "addedit";
            this.addedit.Size = new System.Drawing.Size(335, 534);
            this.addedit.TabIndex = 5;
            // 
            // end
            // 
            this.end.CustomFormat = "dd/MM/yyyy HH:mm";
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end.Location = new System.Drawing.Point(99, 206);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 20);
            this.end.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kết thúc";
            // 
            // start
            // 
            this.start.CustomFormat = "dd/MM/yyyy HH:mm";
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start.Location = new System.Drawing.Point(99, 168);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 20);
            this.start.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kinh Phí";
            // 
            // kinhphi
            // 
            this.kinhphi.Location = new System.Drawing.Point(99, 127);
            this.kinhphi.MaxLength = 11;
            this.kinhphi.Name = "kinhphi";
            this.kinhphi.Size = new System.Drawing.Size(215, 20);
            this.kinhphi.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tên hoạt động";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã ngân sách";
            // 
            // tenhd
            // 
            this.tenhd.Location = new System.Drawing.Point(99, 54);
            this.tenhd.MaxLength = 50;
            this.tenhd.Name = "tenhd";
            this.tenhd.Size = new System.Drawing.Size(215, 20);
            this.tenhd.TabIndex = 11;
            // 
            // idNganSach
            // 
            this.idNganSach.Location = new System.Drawing.Point(99, 89);
            this.idNganSach.MaxLength = 11;
            this.idNganSach.Name = "idNganSach";
            this.idNganSach.Size = new System.Drawing.Size(215, 20);
            this.idNganSach.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(124, 283);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý hoạt động";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tỉnh thành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Theo dõi hoạt động";
            // 
            // province
            // 
            this.province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.province.FormattingEnabled = true;
            this.province.Location = new System.Drawing.Point(455, 38);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(130, 21);
            this.province.TabIndex = 8;
            this.province.SelectedIndexChanged += new System.EventHandler(this.province_SelectedIndexChanged);
            // 
            // HoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data);
            this.Controls.Add(this.province);
            this.Controls.Add(this.addedit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(1008, 534);
            this.MinimumSize = new System.Drawing.Size(1008, 534);
            this.Name = "HoatDong";
            this.Size = new System.Drawing.Size(1008, 534);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.addedit.ResumeLayout(false);
            this.addedit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel addedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idNganSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kinhphi;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tenhd;
        private System.Windows.Forms.ComboBox province;
        private System.Windows.Forms.Button delete;
    }
}
