using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DemoWinform.Models
{
    public class DiaDanh
    {
        public int madd { get; set; }
        public string tendd { get; set; }
        public int matinh { get; set; }
        public string tentinh { get; set; }

        public DiaDanh()
        {

        }

        public DiaDanh(DataRow row)
        {
            this.set((int)row["madd"],
                    row["tendd"].ToString(),
                    (int)row["matinh"],
                    row["tentinh"].ToString());
        }

        public DiaDanh(int madd, string tendd, int matinh, string tentinh)
        {
            this.set(madd, tendd, matinh, tentinh);
        }

        public void set(int madd, string tendd, int matinh, string tentinh)
        {
            this.madd = madd;
            this.tendd = tendd;
            this.matinh = matinh;
            this.tentinh = tentinh;
        }

        public void insert()
        {
            Connection.ExecuteNonQuery("sp_addDiadanh @tendd , @matinh", new object[] { tendd, matinh });
        }

        public void update()
        {
            Connection.ExecuteNonQuery("sp_updateDiadanh @madd , @tendd , @matinh", new object[] { madd,tendd, matinh });
        }

        public void delete()
        {
            Connection.ExecuteNonQuery("sp_delDiadanh @madd", new object[] { madd });
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getDiadanh");
        }
    }
}
