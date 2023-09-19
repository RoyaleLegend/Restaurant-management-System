using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectAlpha1
{
    public partial class loginform : Form
    {
        HomePage Menu = new HomePage();
        string pathLoginform = "Data Source=ROYALELEGEND\\SQLEXPRESS01;Initial Catalog=Restaurant Management System;Integrated Security=True";
        SqlConnection lform;
        DataTable dt = new DataTable();
        string Loginusername = "", Loginpassword = "";
        string MorE = "";
        public loginform()
        {
            InitializeComponent();
            lform = new SqlConnection(pathLoginform);

        }

        private void loginform_Load(object sender, EventArgs e)
        {
            Login_Cmbobox.Items.Add("Manager Login");
            Login_Cmbobox.Items.Add("Employee Login");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTNexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CHKpass_CheckedChanged(object sender, EventArgs e)
        {
            bool check =CHKpass.Checked;
            switch(check)
            {
                case true:
                    txt_password.UseSystemPasswordChar = false;
                    break;
                default:
                    txt_password.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MorE = Login_Cmbobox.SelectedItem.ToString();

        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            Loginusername = txt_username.Text;
            Loginpassword = txt_password.Text;

            try
            {
                if (MorE=="Manager Login")
                {
                    string Logquery = "Select * from ManagerLogin where ManagerID ='"+txt_username.Text+"' AND ManagerPassword = '"+txt_password.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(Logquery, lform);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count>0)
                    {
                        Loginusername = txt_username.Text;
                        Loginpassword = txt_password.Text;

                        Menu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();
                    }
                    lform.Close();
                }
                else if(MorE=="Employee Login")
                {
                    string Logquery = "Select * from EmployeeLogin where EmployeeID ='"+txt_username.Text+"' AND EmployeePassword = '"+txt_password.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(Logquery, lform);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count>0)
                    {
                        Loginusername = txt_username.Text;
                        Loginpassword = txt_password.Text;

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();
                    }
                    lform.Close();

                }
                else
                {
                    MessageBox.Show("Please Login choosing from one of the choices");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}