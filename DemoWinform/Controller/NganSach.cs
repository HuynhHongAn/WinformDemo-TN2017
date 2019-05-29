using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DemoWinform.Controller
{
    class NganSach
    {
        static public List<Models.NganSach> get()
        {
            List<Models.NganSach> list = new List<Models.NganSach>();
            DataTable data = Models.NganSach.get();
            foreach (DataRow item in data.Rows)
            {
                Models.NganSach row = new Models.NganSach(item);
                list.Add(row);
            }
            return list;
        }
    }
}
