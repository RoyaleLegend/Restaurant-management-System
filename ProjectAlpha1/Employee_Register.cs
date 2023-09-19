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
    public partial class Employee_Register : Form
    {
        string pathRegistration = "Data Source=ROYALELEGEND\\SQLEXPRESS01;Initial Catalog=Restaurant Management System;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        string pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string EName = "^[a-zA-Z]*?$";
        string ECnic = "^([0-9]){13}?$";
        string EPNO= "^([0-9]){11}?$";
        string num = "^[0-9]*?$";
        int ID;
        int EFnamecount=0,ELnamecount=0,Ecniccount=0,EEmailcount=0,EPhonenumbercount=0,ESalarycount=0,EIDcount=0;
        
        public Employee_Register()
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
            if (EIDcount==1) { ErrorEmpID.SetError(this.TextEmpid, "Only Positive Integers"); };

            int sum = EFnamecount+ELnamecount+EEmailcount+EPhonenumbercount+ESalarycount+EIDcount+Ecniccount;
            return(sum);
        }
        public void clear()
        {

            TextFname.Text="";
            TextLname.Text="";
            TextCnic.Text="";
            TextEmail.Text="";
            TextEmpid.Text="";
            TextPNO.Text="";
            TextSalary.Text="";
            TextEmpid.Text="";
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
            ErrorEmpID.Clear();
            Ecniccount=0;
            EEmailcount=0;
            EPhonenumbercount=0;
            ESalarycount=0;
            EIDcount=0;
            EFnamecount=0;
            ELnamecount=0;
        }

        private void Employee_Register_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (TextFname.Text==""||TextLname.Text==""||TextCnic.Text==""||TextEmail.Text=="" ||TextAddress.Text==""||TextPNO.Text==""||TextSalary.Text==""||TextEmpid.Text==""||TextPass.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();
            
            }
            else if((count() == 0) && (TextFname.Text!=""||TextLname.Text!=""||TextCnic.Text!=""||TextEmail.Text!="" ||TextAddress.Text!=""||TextPNO.Text!=""||TextSalary.Text!=""||TextEmpid.Text!=""||TextPass.Text!=""))
            {

                try
                {
                    int empid = Int32.Parse(TextEmpid.Text);
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
                    cmd=new SqlCommand("insert into EmployeeLogin values ('"+empid+"','"+TextPass.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    cmd=new SqlCommand("insert into Employee_Registration (Employee_First_Name,Employee_Last_Name,CNIC,Employee_Email,Gender,Address,Phone_Number,Employee_ID,Salary) values ('"+TextFname.Text+"','"+TextLname.Text+"','"+TextCnic.Text+"','"+TextEmail.Text+"','"+Gender+"','"+TextAddress.Text+"','"+TextPNO.Text+"','"+empid+"','"+Salary+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select Employee_ID as ID,(employee_first_name+' '+Employee_Last_Name) As Name ,CNIC ,Employee_Email As Email,Gender,Address,Phone_Number,Salary from Employee_Registration where Employee_ID ='"+empid+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    EmployeeDGV.DataSource=Edt;
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

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Textemail_TextChanged(object sender, EventArgs e)
        {
        }

        private void Textemail_Leave(object sender, EventArgs e)
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

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (TextFname.Text==""||TextLname.Text==""||TextCnic.Text==""||TextEmail.Text=="" ||TextAddress.Text==""||TextPNO.Text==""||TextSalary.Text==""||TextEmpid.Text==""||TextPass.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();
            }
            else if ((count() == 0) && (TextFname.Text!=""||TextLname.Text!=""||TextCnic.Text!=""||TextEmail.Text!="" ||TextAddress.Text!=""||TextPNO.Text!=""||TextSalary.Text!=""||TextEmpid.Text!=""||TextPass.Text!=""))
            {

                try
                {
                    int empid = Int32.Parse(TextEmpid.Text);
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
                    cmd=new SqlCommand("update Employee_Registration set Employee_First_Name='"+TextFname.Text+"',Employee_Last_Name='"+TextLname.Text+"',CNIC='"+TextCnic.Text+"',Employee_Email='"+TextEmail.Text+"',Gender='"+Gender+"',Address='"+TextAddress.Text+"',Phone_Number='"+TextPNO.Text+"',Salary='"+Salary+"' where Employee_ID='"+empid+"'", con);
                    cmd.ExecuteNonQuery();
                    cmd=new SqlCommand("update EmployeeLogin set EmployeePassword='"+TextPass.Text+"' where EmployeeID= '"+empid+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select Employee_ID as ID,(employee_first_name+' '+Employee_Last_Name) As Name ,CNIC ,Employee_Email As Email,Gender,Address,Phone_Number,Salary from Employee_Registration where Employee_ID ='"+empid+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    EmployeeDGV.DataSource=Edt;
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

        private void button1_Click(object sender, EventArgs e)
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
                        SqlDataAdapter Esda = new SqlDataAdapter("Select Employee_ID as ID,(employee_first_name+' '+Employee_Last_Name) As Name ,CNIC ,Employee_Email As Email,Gender,Address,Phone_Number,Salary from Employee_Registration where Employee_ID ='"+search+"'", con);
                        DataTable Edt = new DataTable();
                        Esda.Fill(Edt);

                        EmployeeDGV.DataSource=Edt;
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

        private void TextFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextEmpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {


            if (TextSearch.Text=="")
            {
                MessageBox.Show("Enter a ID to delete it");
            }
            else
            {
                if (Regex.IsMatch(TextEmpid.Text, num))
                {
                    if (int.Parse(TextEmpid.Text)>=1)
                    {
                        ID = int.Parse(TextEmpid.Text);
                        con.Open();
                        cmd=new SqlCommand("delete Employee_Registration where Employee_ID='"+ID+"'", con);
                        cmd.ExecuteNonQuery();
                        cmd=new SqlCommand("delete EmployeeLogin  where EmployeeID= '"+ID+"'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        clear();


                    }
                    else
                    {
                        ErrorEmpID.SetError(this.TextEmpid, "Id can't be lower than 0");

                    }
                }
                else
                {
                    ErrorEmpID.SetError(this.TextEmpid, "Only Input numeric values");

                }

            }
        }

        private void TextPNO_TextChanged(object sender, EventArgs e)
        {

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

        private void TextEmpid_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TextEmpid.Text, num))
            {
                if (int.Parse(TextEmpid.Text)>1)
                {
                    ErrorEmpID.Clear();
                    EIDcount=0;
                }
                else
                {
                    ErrorEmpID.SetError(this.TextEmpid, "Id can't be lower than 0");
                    EIDcount=1;
                }
            }
            else
            {
                ErrorEmpID.SetError(this.TextEmpid, "Only Input numeric values");
                EIDcount=1;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
