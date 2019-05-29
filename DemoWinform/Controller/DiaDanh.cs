using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DemoWinform.Controller
{
    class DiaDanh
    {
        static public List<Models.DiaDanh> get()
        {
            List<Models.DiaDanh> list = new List<Models.DiaDanh>();
            DataTable data = Models.DiaDanh.get();
            foreach (DataRow item in data.Rows)
            {
                Models.DiaDanh row = new Models.DiaDanh(item);
                list.Add(row);
            }
            return list;
        }
    }
}
