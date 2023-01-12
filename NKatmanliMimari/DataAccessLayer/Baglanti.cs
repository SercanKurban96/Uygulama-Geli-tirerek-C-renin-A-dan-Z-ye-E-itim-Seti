using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-9H60TTH\\SERCANKURBAN;Initial Catalog=DbPersonel;User ID=WebMobile_302; Password=webmobile.302");
    }
}
