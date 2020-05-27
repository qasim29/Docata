using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docata
{
    public partial class activation_panel : Form
    {
        public int TotalDaysLeft { get; set; }
        public activation_panel()
        {
            InitializeComponent();
        }

        private void activation_panel_Load(object sender, EventArgs e)
        {
            TrialDaysLeftlabel.Text = "Your trial ends in " + TotalDaysLeft + " days. ";

            if (TotalDaysLeft > 0)
            {
                ExitButton.Text = "Continue Trial";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitMethod();

        }

        private void ExitMethod()
        {
            if (TotalDaysLeft == 0)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void EnterLicenseKeyButton_Click(object sender, EventArgs e)
        {
            if (IsValidated()) 
            {
                try
                {
                    EnterNmaeAndProductKeyToDB();
                    MessageBox.Show("Docata is Activated.","Success", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    this.Close();
                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                   
                }
            }

        }

        private void EnterNmaeAndProductKeyToDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE productkey SET [ProductKey]=@ProductKey", conn))
                {
                    cmd.Parameters.AddWithValue("@ProductKey", LicenseKeyTextBox.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }

            }

        }
        private bool IsValidated()
        {
            if (!LicenseKeyTextBox.MaskCompleted)
            {
                MessageBox.Show("Product Key must be 25 charachters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseKeyTextBox.Focus();
                return false;
            }
            else
            {
                bool isValid = CheckIsProductKeyValid(LicenseKeyTextBox.Text);
                if (!isValid)
                {
                    MessageBox.Show("Product Key is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LicenseKeyTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool CheckIsProductKeyValid(string productkey)
        {
            // "Z45QA-6SI56-MJEMJ-2AF32-098RY"
            string part1 = productkey.Substring(3, 2); //QA
            string part2 = productkey.Substring(7, 2); //SI
            string part3 = productkey.Substring(12, 2); //MJ
            string part4 = productkey.Substring(19, 2); //AF
            string part5 = productkey.Substring(27, 2); //RY
            productkey = part1 + part2 + part3 + part4 + part5;
            if (productkey != "QASIMJAFRY") 
            {
                return false;
            }
            return true;
        }

        private void activation_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitMethod();
        }

    }
}
