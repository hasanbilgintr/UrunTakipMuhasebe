using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=.;Initial Catalog=Db_Muhasebe;Integrated Security=True");
            if (bgl.State == ConnectionState.Closed)
            {
                bgl.Open();
            }
            return bgl;
        }
    }
}
