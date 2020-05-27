using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace docata
{
    public partial class mainwin : Form
    {
        public mainwin()
        {
            InitializeComponent();
        }

      //  private void button1_Click(object sender, EventArgs e)
        //{
          //  this.Hide();
            //activation_panel ap = new activation_panel();
            //ap.ShowDialog();

        //}
        private void mainwin_Load(object sender, EventArgs e)
        {
             CheckProductKeyDetails();
        }
        private void CheckProductKeyDetails()
        {
            activation prodlicense = GetProductKeyDetails();
            int totaldaysleft = 0;
            if (prodlicense.ProductKey == string.Empty)
            {
                if (prodlicense.TrialExpiryDate == new DateTime(1900, 1, 1))
                {
                    UpdateTrialExpiryDate();

                    totaldaysleft = FindTotalTrialDaysLeft(DateTime.Now.Date.AddMonths(1), DateTime.Now.Date);
                }
                else
                {
                    totaldaysleft = FindTotalTrialDaysLeft(prodlicense.TrialExpiryDate, DateTime.Now.Date);
                }
                ShowActivationForm(totaldaysleft);
            }
        }

        private void ShowActivationForm(int totaldaysleft)
        {
            activation_panel af = new activation_panel();
            af.TotalDaysLeft = totaldaysleft;
            af.ShowDialog();
        }

        private int FindTotalTrialDaysLeft(DateTime trialExpiryDate, DateTime currentDate)
        {
            int totaldaysleft =  Convert.ToInt16((trialExpiryDate - currentDate).TotalDays);

            if (totaldaysleft < 0)
                totaldaysleft = 0;
            
            return totaldaysleft;
                
        }

        private void UpdateTrialExpiryDate()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE productkey SET [TrialExpiryDate]=@TrialExpiryDate", conn))
                {
                    cmd.Parameters.AddWithValue("@TrialExpiryDate", DateTime.Now.Date.AddMonths(1));
                    
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private activation GetProductKeyDetails()
        {
            activation pl = new activation();
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM productkey", conn))
                {
                     conn.Open();
                     SqlDataReader reader = cmd.ExecuteReader();
                     reader.Read();
                    pl.ProductKey = reader["ProductKey"].ToString();
                    pl.TrialExpiryDate = Convert.ToDateTime(reader["TrialExpiryDate"]);
                }

            }
            return pl;
        }
    }
}
