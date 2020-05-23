using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace docata
{
    class activationclass
    {
        const string connectionstring = "SERVER =DESKTOP-ARDAV28;,DATABASE = Docata;,USER ID = ;,PASSWORD= ;";
        SqlCommand cmd = new SqlCommand(UpdateQuery, sqlconn);
        cmd.parameters.addwithvalues(@key ,key);
        sqlconn.open();
        cmd.ExecuteNonQuery();
        MessageBox.Show("")

    }abcabacabcabcabc

}
