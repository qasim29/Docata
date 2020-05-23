using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace docata
{
    class activationclass
    {
        const string connectionstring = "Server = DESKTOP - ARDAV28; myServerAddress; Database=DocataDB;Trusted_Connection=True";
        private static bool Activated { get; set; }

        private static bool isActivated(string key)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionstring))
            {
                string CheckForActivationQuery = "SELECT activated FROM serialkey WHERE serialkey =@key";
                SqlCommand cmd = new SqlCommand(CheckForActivationQuery, sqlconn);
                cmd.Parameters.AddWithValue(@key, key);
                sqlconn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0) 
                {
                    return true;                
                }
                return false;
            }
        }
        public static void activationSoftware(string key) 
        {
            if (!isActivated(key))
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionstring))
                {
                    string CheckForKeyQuery = "SELECT COUNT(*) FROM serialkey WHERE serialkey =@key";
                    SqlCommand cmd = new SqlCommand(CheckForKeyQuery, sqlconn);
                    cmd.Parameters.AddWithValue(@key, key);
                    sqlconn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    
                    if(result > 0) 
                    {
                        updateActivation(key);
                        Activated = true;
                    }
                    else
                    {
                        MessageBox.Show("Your key was inccorect!");
                        Activated = false;
                    }
                }
            }
            else 
                {
                MessageBox.Show("your sofrware is alreday Activated");
                Activated = true;
                }
        }

        private static void updateActivation(string key)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionstring))
            {
                string updateQuery = "UPDATE serialkey SET activated = 1 WHERE serialkey=@key";
             
                SqlCommand cmd = new SqlCommand(updateQuery, sqlconn);
                cmd.Parameters.AddWithValue(@key, key);
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("your software has been activated");


            }

        }


    }
}


            