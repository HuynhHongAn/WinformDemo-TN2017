using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DemoWinform.Models
{
    public class TinhThanh
    {
        public int matinh { get; set; }
        public string tentinh { get; set; }

        public TinhThanh(DataRow row)
        {
            this.set((int)row["matinh"],
                    row["tentinh"].ToString());
        }

        public TinhThanh(int matinh, string tentinh)
        {
            this.set(matinh, tentinh);
        }

        public void set(int matinh, string tentinh)
        {
            this.matinh = matinh;
            this.tentinh = tentinh;
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getTinhthanh");
        }
    }
}
