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
using System.Text.RegularExpressions;

namespace ProjectAlpha1
{
    public partial class Manager_Registration : Form
    {

        string pathRegistration = "Data Source=ROYALELEGEND\\SQLEXPRESS01;Initial Catalog=Restaurant Management System;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        string pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string EName = "^[a-zA-Z]*?$";
        string ECnic = "^([0-9]){13}?$";
        string EPNO = "^([0-9]){11}?$";
        string num = "^[0-9]*?$";
        int ID;
        int EFnamecount = 0, ELnamecount = 0, Ecniccount = 0, EEmailcount = 0, EPhonenumbercount = 0, ESalarycount = 0, EIDcount = 0;

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {


            if (TextSearch.Text=="")
            {
                MessageBox.Show("Enter a ID to delete it");
            }
            else
            {
                if (Regex.IsMatch(TextManagerID.Text, num))
                {
                    if (int.Parse(TextManagerID.Text)>=1)
                    {
                        ID = int.Parse(TextManagerID.Text);
                        con.Open();
                        cmd=new SqlCommand("delete Manager_Registration where Manager_ID='"+ID+"'", con);
                        cmd.ExecuteNonQuery();
                        cmd=new SqlCommand("delete ManagerLogin  where ManagerID= '"+ID+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        clear();


                    }
                    else
                    {
                        ErrorManagerID.SetError(this.TextManagerID, "Id can't be lower than 0");

                    }
                }
                else
                {
                    ErrorManagerID.SetError(this.TextManagerID, "Only Input numeric values");

                }

            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (TextSearch.Text=="")
            {
                MessageBox.Show("Enter a ID to start your search");
            }
            else
            {


                if (Regex.IsMatch(TextSearch.Text, num))
                {
                    if (int.Parse(TextSearch.Text)>=1)
                    {
                        int search = int.Parse(TextSearch.Text);
                        con.Open();
                        SqlDataAdapter Esda = new SqlDataAdapter("Select Manager_ID as ID,(Manager_First_Name+' '+Manager_Last_Name) As Name ,Cnic ,Email,Gender,Address,Phone_Number,Salary from Manager_Registration where Manager_ID ='"+search+"'", con);
                        DataTable Edt = new DataTable();
                        Esda.Fill(Edt);

                        MAnagerDGV.DataSource=Edt;
                        con.Close();
                        clear();


                    }
                    else
                    {
                        ErrorSearch.SetError(this.TextSearch, "Id can't be lower than 0");

                    }
                }
                else
                {
                    ErrorSearch.SetError(this.TextSearch, "Only Input numeric values");

                }

            }
        }

        private void TextFname_Leave(object sender, EventArgs e)
        {

                if (Regex.IsMatch(TextFname.Text, EName))
                {
                    ErrorFname.Clear();
                    EFnamecount=0;
                }
                else
                {
                    ErrorFname.SetError(this.TextFname, "No Special Characters");
                    EFnamecount = 1;
                }
        }

        private void TextLname_Leave(object sender, EventArgs e)
        {

            
                if (Regex.IsMatch(TextLname.Text, EName))
                {
                    ErrorLname.Clear();
                    ELnamecount=0;
                }
                else
                {
                    ErrorLname.SetError(this.TextLname, "No Special Characters");
                    ELnamecount = 1;
                }

            
        }

        private void TextPNO_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TextPNO.Text, EPNO))
            {
                ErrorPNO.Clear();
                EPhonenumbercount=0;
            }
            else
            {
                ErrorPNO.SetError(this.TextPNO, "Only 11 digit Pakistani number starting with 0");
                EPhonenumbercount=1;
            }
        }

        private void TextCnic_Leave(object sender, EventArgs e)

        {
            if (Regex.IsMatch(TextCnic.Text, ECnic))
            {
                ErrorCnic.Clear();
                Ecniccount=0;
            }
            else
            {
                ErrorCnic.SetError(this.TextCnic, "13 Digits CNIC with no space");
                Ecniccount = 1;
            }
        }



        private void TextEmail_Leave(object sender, EventArgs e)
        {

            

                if (Regex.IsMatch(TextEmail.Text, pattern))
                {
                    EmailError.Clear();
                    EEmailcount=0;
                }
                else
                {
                    EmailError.SetError(this.TextEmail, "Please Enter a valid Email");
                    EEmailcount=0;
                }

            
        }

        private void TextSalary_Leave(object sender, EventArgs e)
        {

            
                if (Regex.IsMatch(TextSalary.Text, num))
                {
                    if (int.Parse(TextSalary.Text)>1)
                    {
                        ErrorSalary.Clear();
                        ESalarycount=0;
                    }
                    else
                    {
                        ErrorSalary.SetError(this.TextSalary, "Salary can't be zero or lower");
                        ESalarycount=1;
                    }
                }
                else
                {
                    ErrorSalary.SetError(this.TextSalary, "Only Input numeric values");
                    ESalarycount=1;
                }
            
        }

        private void TextManagerID_Leave(object sender, EventArgs e)
        {

            
                if (Regex.IsMatch(TextManagerID.Text, num))
                {
                    if (int.Parse(TextManagerID.Text)>1)
                    {
                        ErrorManagerID.Clear();
                        EIDcount=0;
                    }
                    else
                    {
                        ErrorManagerID.SetError(this.TextManagerID, "Id can't be lower than 0");
                        EIDcount=1;
                    }
                }
                else
                {
                    ErrorManagerID.SetError(this.TextManagerID, "Only Input numeric values");
                    EIDcount=1;
                }
            
        }

        private void TextSearch_Leave(object sender, EventArgs e)
        {
            if (TextSearch.Text=="")
            {
                MessageBox.Show("Enter a ID to start your search");
            }
            else
            {


                if (Regex.IsMatch(TextSearch.Text, num))
                {
                    if (int.Parse(TextSearch.Text)>=1)
                    {
                        int search = int.Parse(TextSearch.Text);
                        con.Open();
                        SqlDataAdapter Esda = new SqlDataAdapter("Select Manager_ID as ID,(Manager_First_Name+' '+Manager_Last_Name) As Name ,Cnic ,Email,Gender,Address,Phone_Number,Salary from Manager_Registration where Manager_ID ='"+search+"'", con);
                        DataTable Edt = new DataTable();
                        Esda.Fill(Edt);

                        MAnagerDGV.DataSource=Edt;
                        con.Close();
                        clear();


                    }
                    else
                    {
                        ErrorSearch.SetError(this.TextSearch, "Id can't be lower than 0");

                    }
                }
                else
                {
                    ErrorSearch.SetError(this.TextSearch, "Only Input numeric values");

                }

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void MAnagerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (TextFname.Text==""||TextLname.Text==""||TextCnic.Text==""||TextEmail.Text=="" ||TextAddress.Text==""||TextPNO.Text==""||TextSalary.Text==""||TextManagerID.Text==""||TextPass.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();
            }
            else if ((count() == 0) && (TextFname.Text!=""||TextLname.Text!=""||TextCnic.Text!=""||TextEmail.Text!="" ||TextAddress.Text!=""||TextPNO.Text!=""||TextSalary.Text!=""||TextManagerID.Text!=""||TextPass.Text!=""))
            {

                try
                {
                    int ManageID = Int32.Parse(TextManagerID.Text);
                    int Salary = Int32.Parse(TextSalary.Text);
                    string Gender;
                    if (RBTM.Checked)
                    {
                        Gender="Male";
                    }
                    else
                    {

                        Gender="Female";
                    }

                    con.Open();
                    cmd=new SqlCommand("update Manager_Registration set Manager_First_Name='"+TextFname.Text+"',Manager_Last_Name='"+TextLname.Text+"',Cnic='"+TextCnic.Text+"',Email='"+TextEmail.Text+"',Gender='"+Gender+"',Address='"+TextAddress.Text+"',Phone_Number='"+TextPNO.Text+"',Salary='"+Salary+"' where Manager_ID='"+ManageID+"'", con);
                    cmd.ExecuteNonQuery();
                    cmd=new SqlCommand("update ManagerLogin set ManagerPassword='"+TextPass.Text+"' where ManagerID= '"+ManageID+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select Manager_ID as ID,(Manager_First_Name+' '+Manager_Last_Name) As Name ,Cnic ,Email,Gender,Address,Phone_Number,Salary from Manager_Registration where Manager_ID ='"+ManageID+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    MAnagerDGV.DataSource=Edt;
                    con.Close();
                    clear();
                    MessageBox.Show("Data have been Updated Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                count();
            }
        }

        public Manager_Registration()
        {
            InitializeComponent();
            con = new SqlConnection(pathRegistration);
        }

        public int count()
        {
            if (EFnamecount==1) { ErrorFname.SetError(this.TextFname, "No Special character or Numbers"); };
            if (ELnamecount==1) { ErrorLname.SetError(this.TextLname, "No Special character or Numbers"); };
            if (Ecniccount==1) { ErrorCnic.SetError(this.TextCnic, "13 Digits Cnic with no space or special character"); };
            if (EEmailcount==1) { EmailError.SetError(this.TextEmail, "Enter a valid email"); };
            if (EPhonenumbercount==1) { ErrorPNO.SetError(this.TextPNO, "11 digits Local Pakistan's sim number starting with 0"); };
            if (ESalarycount==1) { ErrorSalary.SetError(this.TextSalary, "Only Positive Integers"); };
            if (EIDcount==1) { ErrorManagerID.SetError(this.TextManagerID, "Only Positive Integers"); };

            int sum = EFnamecount+ELnamecount+EEmailcount+EPhonenumbercount+ESalarycount+EIDcount+Ecniccount;
            return (sum);
        }
        public void clear()
        {

            TextFname.Text="";
            TextLname.Text="";
            TextCnic.Text="";
            TextEmail.Text="";
            TextManagerID.Text="";
            TextPNO.Text="";
            TextSalary.Text="";
            TextManagerID.Text="";
            RBTM.Checked=false;
            RBTFM.Checked=false;
            TextPass.Text="";
            TextAddress.Text="";
            EmailError.Clear();
            ErrorCnic.Clear();
            ErrorFname.Clear();
            ErrorLname.Clear();
            ErrorPNO.Clear();
            ErrorSalary.Clear();
            ErrorManagerID.Clear();
            Ecniccount=0;
            EEmailcount=0;
            EPhonenumbercount=0;
            ESalarycount=0;
            EIDcount=0;
            EFnamecount=0;
            ELnamecount=0;
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (TextFname.Text==""||TextLname.Text==""||TextCnic.Text==""||TextEmail.Text=="" ||TextAddress.Text==""||TextPNO.Text==""||TextSalary.Text==""||TextManagerID.Text==""||TextPass.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();

            }
            else if ((count() == 0) && (TextFname.Text!=""||TextLname.Text!=""||TextCnic.Text!=""||TextEmail.Text!="" ||TextAddress.Text!=""||TextPNO.Text!=""||TextSalary.Text!=""||TextManagerID.Text!=""||TextPass.Text!=""))
            {

                try
                {
                    int ManageID = int.Parse(TextManagerID.Text);
                    int Salary = int.Parse(TextSalary.Text);
                    string Gender;
                    if (RBTM.Checked)
                    {
                        Gender="Male";
                    }
                    else
                    {

                        Gender="Female";
                    }

                    con.Open();
                    cmd=new SqlCommand("insert into ManagerLogin values ('"+ManageID+"','"+TextPass.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    cmd=new SqlCommand("insert into Manager_Registration (Manager_First_Name,Manager_last_Name,Phone_Number,Cnic,Email,Gender,Manager_ID,Address,Salary) values ('"+TextFname.Text+"','"+TextLname.Text+"','"+TextPNO.Text+"','"+TextCnic.Text+"','"+TextEmail.Text+"','"+Gender+"','"+ManageID+"','"+TextAddress.Text+"','"+Salary+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select Manager_ID as ID,(Manager_First_Name+' '+Manager_Last_Name) As Name ,Cnic ,Email,Gender,Address,Phone_Number,Salary from Manager_Registration where Manager_ID ='"+ManageID+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    MAnagerDGV.DataSource=Edt;
                    con.Close();
                    clear();
                    MessageBox.Show("Data have been saved Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                count();
            }
        }
    }

}