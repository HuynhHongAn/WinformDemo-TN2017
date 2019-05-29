namespace DemoWinform.Views
{
    partial class NganSach
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
            this.provinceSearch = new System.Windows.Forms.ComboBox();
            this.kinhphi = new System.Windows.Forms.TextBox();
            this.addedit = new System.Windows.Forms.Panel();
            this.provinceAdd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.addedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(234, 65);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(774, 469);
            this.data.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(145, 193);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(16, 193);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Thêm";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // provinceSearch
            // 
            this.provinceSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceSearch.FormattingEnabled = true;
            this.provinceSearch.Location = new System.Drawing.Point(317, 38);
            this.provinceSearch.Name = "provinceSearch";
            this.provinceSearch.Size = new System.Drawing.Size(130, 21);
            this.provinceSearch.TabIndex = 3;
            this.provinceSearch.SelectedIndexChanged += new System.EventHandler(this.provinceSearch_SelectedIndexChanged);
            // 
            // kinhphi
            // 
            this.kinhphi.Location = new System.Drawing.Point(90, 89);
            this.kinhphi.MaxLength = 11;
            this.kinhphi.Name = "kinhphi";
            this.kinhphi.Size = new System.Drawing.Size(130, 20);
            this.kinhphi.TabIndex = 0;
            // 
            // addedit
            // 
            this.addedit.Controls.Add(this.provinceAdd);
            this.addedit.Controls.Add(this.label6);
            this.addedit.Controls.Add(this.year);
            this.addedit.Controls.Add(this.label4);
            this.addedit.Controls.Add(this.cancel);
            this.addedit.Controls.Add(this.submit);
            this.addedit.Controls.Add(this.label2);
            this.addedit.Controls.Add(this.label1);
            this.addedit.Controls.Add(this.kinhphi);
            this.addedit.Dock = System.Windows.Forms.DockStyle.Left;
            this.addedit.Location = new System.Drawing.Point(0, 0);
            this.addedit.Name = "addedit";
            this.addedit.Size = new System.Drawing.Size(234, 534);
            this.addedit.TabIndex = 2;
            // 
            // provinceAdd
            // 
            this.provinceAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceAdd.FormattingEnabled = true;
            this.provinceAdd.Location = new System.Drawing.Point(90, 155);
            this.provinceAdd.Name = "provinceAdd";
            this.provinceAdd.Size = new System.Drawing.Size(130, 21);
            this.provinceAdd.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tỉnh";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(90, 121);
            this.year.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(130, 20);
            this.year.TabIndex = 8;
            this.year.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý ngân sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kinh Phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tỉnh thành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Theo dõi kinh phí";
            // 
            // NganSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data);
            this.Controls.Add(this.addedit);
            this.Controls.Add(this.provinceSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(1008, 534);
            this.MinimumSize = new System.Drawing.Size(1008, 534);
            this.Name = "NganSach";
            this.Size = new System.Drawing.Size(1008, 534);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.addedit.ResumeLayout(false);
            this.addedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox provinceSearch;
        private System.Windows.Forms.TextBox kinhphi;
        private System.Windows.Forms.Panel addedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox provinceAdd;
        private System.Windows.Forms.Label label6;
    }
}
