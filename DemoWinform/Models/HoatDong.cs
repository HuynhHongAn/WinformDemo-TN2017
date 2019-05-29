using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DemoWinform.Models
{
    class HoatDong
    {
        public int mahd { get; set; }
        public string tenhd { get; set; }
        public int kinhphi { get; set; }
        public DateTime ngaybd { get; set; }
        public DateTime ngaykt { get; set; }
        public int mans { get; set; }
        public string tentinh { get; set; }

        public HoatDong()
        {

        }

        public HoatDong(DataRow row)
        {
            this.set((int)row["mahd"],
                    row["tenhd"].ToString(),
                    (int)row["kinhphi"],
                    (DateTime)row["ngaybd"],
                    (DateTime)row["ngaykt"],
                    (int)row["mans"],
                    row["tentinh"].ToString());
        }

        public HoatDong(int mahd,string tenhd,int kinhphi,DateTime ngaybd, DateTime ngaykt,int mans,string tentinh)
        {
            this.set(mahd, tenhd, kinhphi, ngaybd, ngaykt, mans, tentinh);
        }

        public void set(int mahd, string tenhd, int kinhphi, DateTime ngaybd, DateTime ngaykt, int mans, string tentinh)
        {
            this.mahd = mahd;
            this.tenhd = tenhd;
            this.kinhphi = kinhphi;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.mans = mans;
            this.tentinh = tentinh;
        }

        public bool insert()
        {
            int result = Connection.ExecuteNonQuery("exec sp_addHd @tenhd , @kinhphi , @ngaybd , @ngaykt , @mans",
                                     new object[] { tenhd,kinhphi,ngaybd,ngaykt,mans});
            return result > 0;
        }

        public bool update()
        {
            int result = Connection.ExecuteNonQuery("sp_updateHd @mahd , @tenhd , @kinhphi , @ngaybd , @ngaykt , @mans",
                                        new object[] {mahd, tenhd, kinhphi, ngaybd, ngaykt, mans });
            return result > 0;
        }

        public void delete()
        {
            Connection.ExecuteNonQuery("sp_delHd @mahd", new object[] { mahd });
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getHd");
        }
    }
}
