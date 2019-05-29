using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinform.Views
{
    public partial class DiaDanh : UserControl
    {
        private bool isEdit = false;
        public DiaDanh()
        {
            InitializeComponent();
            LoadData();
            LoadTinh();
        }

        private void LoadData()
        {
            // DataTable dataTable = new DataTable();
            //dataTable = Models.DiaDanh.get();
            List<Models.DiaDanh> l = Controller.DiaDanh.get();
            this.data.DataSource = l;
            this.data.Columns[0].HeaderText = "Mã địa danh";
            this.data.Columns[1].HeaderText = "Tên địa danh";
            this.data.Columns[2].Visible = false;
            this.data.Columns[3].HeaderText = "Tên tỉnh";
            //
        }

        private void LoadTinh()
        {
            List<Models.TinhThanh> l = Controller.TinhThanh.get();
            this.province.DataSource = l;
            this.province.DisplayMember = "tentinh";
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data.CurrentRow;
            if (!row.IsNewRow)
            {
                Models.DiaDanh x = (Models.DiaDanh)this.data.CurrentRow.DataBoundItem;
                this.isEdit = true;
                this.submit.Text = "Sửa";
                this.name.Text = x.tendd;
                foreach (Models.TinhThanh i in this.province.Items)
                {
                    if (i.matinh == x.matinh)
                    {
                        this.province.SelectedItem = i;
                        break;
                    }
                }
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.isEdit = false;
            this.submit.Text= "Thêm";
            this.province.ResetText();
            this.name.ResetText();
        }

        private bool check()
        {
            if (
                this.name.TextLength > 0
            )
                return true;
            return false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Bạn chưa nhập hết dữ liệu!");
                return;
            }
            Models.DiaDanh x = new Models.DiaDanh();
            x.tendd = this.name.Text.Trim();
            x.matinh = (this.province.SelectedItem as Models.TinhThanh).matinh;
            if (this.isEdit)
            {
                x.madd = ((Models.DiaDanh)this.data.CurrentRow.DataBoundItem).madd;
                x.update();
            }
            else
            {
                x.insert();
            }
            this.cancel_Click(sender, e);
            this.LoadData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn muốn xóa địa danh này?", "Xác nhận?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (confirm == DialogResult.Yes)
            {
                Models.DiaDanh x = new Models.DiaDanh();
                x.madd = ((Models.DiaDanh)this.data.CurrentRow.DataBoundItem).madd;
                x.delete();
                this.cancel_Click(sender, e);
                this.LoadData();
            }
        }
    }
}
