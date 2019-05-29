using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DemoWinform.Models
{
    class NganSach
    {
        public int mans { get; set; }
        public int kinhphi { get; set; }
        public int namcap { get; set; }
        public int matinh { get; set; }
        public string tentinh { get; set; }

        public NganSach()
        {

        }

        public NganSach(DataRow row)
        {
            this.set((int)row["mans"],
                    (int)row["kinhphi"],
                    (int)row["namcap"],
                    (int)row["matinh"],
                    row["tentinh"].ToString());
            
        }

        public NganSach(int mans, int kinhphi, int namcap, int matinh, string tentinh)
        {
            this.set(mans, kinhphi, namcap, matinh, tentinh);
        }

        public void set(int mans, int kinhphi,int namcap,int matinh,string tentinh)
        {
            this.mans = mans;
            this.kinhphi = kinhphi;
            this.namcap = namcap;
            this.matinh = matinh;
            this.tentinh = tentinh;
        }

        public void insert()
        {
            Connection.ExecuteNonQuery("sp_addNgansach @kinhphi , @nam , @matinh", new object[] { kinhphi, namcap, matinh });
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getNgansach");
        }
    }
}
