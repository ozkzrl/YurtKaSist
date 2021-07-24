using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YurtKaSist
{
    class Sqlbaglantim
    {

        public SqlConnection baglanti()
        {

       SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-990TK7I;Initial Catalog=YurtKayit;Integrated Security=True");
       baglan.Open();
       return baglan;


        }
    }
}
