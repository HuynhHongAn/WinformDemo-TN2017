using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DemoWinform.Controller
{
    class TinhThanh
    {
        static public List<Models.TinhThanh> get()
        {
            List<Models.TinhThanh> list = new List<Models.TinhThanh>();
            DataTable data = Models.TinhThanh.get();
            foreach (DataRow item in data.Rows)
            {
                Models.TinhThanh row = new Models.TinhThanh(item);
                list.Add(row);
            }
            return list;
        }
    }
}
