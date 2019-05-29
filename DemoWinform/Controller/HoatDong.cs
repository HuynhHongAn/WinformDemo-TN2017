using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DemoWinform.Controller
{
    class HoatDong
    {
        static public List<Models.HoatDong> get()
        {
            List<Models.HoatDong> list = new List<Models.HoatDong>();
            DataTable data = Models.HoatDong.get();
            foreach (DataRow item in data.Rows)
            {
                Models.HoatDong row = new Models.HoatDong(item);
                list.Add(row);
            }
            return list;
        }
    }
}
