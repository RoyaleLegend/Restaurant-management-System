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

    public partial class ADD_Product : Form
    {
        string pathRegistration = "Data Source=ROYALELEGEND\\SQLEXPRESS01;Initial Catalog=Restaurant Management System;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        string EName = "^[a-zA-Z]*?$";
        string num = "^[0-9]*?$";
        int ENamecount = 0, EIDcount = 0, ETypecount = 0;

        public ADD_Product()
        {
            InitializeComponent();
            con=new SqlConnection(pathRegistration);
        }


        public int count()
        {
            if (ENamecount==1) { ErrorItemName.SetError(this.ItemName, "No Special character or Numbers"); };
            if (EIDcount==1) { ErrorItemID.SetError(this.ItemID, "Value should be numeric and above 0"); };
            if (ETypecount==1) { ErrorItemType.SetError(this.Itemtype, "Choose a Type first"); };

            int sum = ENamecount+EIDcount+ETypecount;
            return (sum);
        }
        public void clear()
        {

            TextNameSearch.Text="";
            MenuItemPrice.Text="";
            ItemID.Text="";
            ItemName.Text="";
            TextIDsearch.Text="";
            Itemtype.Text="";
            ErrorItemID.Clear();
            ErrorItemName.Clear();
            ErrorItemType.Clear();
            ErrorSearchId.Clear();
            ErrorSearchName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (ItemName.Text==""||MenuItemPrice.Text==""||Itemtype.Text==""||ItemID.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();

            }
            else if ((count() == 0) && (TextNameSearch.Text!=""||MenuItemPrice.Text!=""||Itemtype.Text!=""||ItemID.Text!=""))
            {

                try
                {
                    int Price = int.Parse(MenuItemPrice.Text);
                    int MEnuID = int.Parse(ItemID.Text);

                    con.Open();
                    cmd=new SqlCommand("update Menu set MenuItemName='"+ItemName.Text+"',MenuItemPrice='"+Price+"',MenuItemType='"+Itemtype.Text+"' where MenuItemID='"+MEnuID+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu where MenuItemID = '"+MEnuID+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    ProductDGV.DataSource=Edt;
                    con.Close();
                    clear();
                    MessageBox.Show("Data have been updated Successfully");

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (ItemName.Text==""||MenuItemPrice.Text==""||Itemtype.Text==""||ItemID.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();

            }
            else if ((count() == 0) && (TextNameSearch.Text!=""||MenuItemPrice.Text!=""||Itemtype.Text!=""||ItemID.Text!=""))
            {

                try
                {
                    int MenuID = int.Parse(ItemID.Text);

                    con.Open();
                    cmd=new SqlCommand("delete Menu  where MenuItemID = '"+MenuID+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu where MenuItemID = '"+MenuID+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    ProductDGV.DataSource=Edt;
                    con.Close();
                    clear();
                    MessageBox.Show("Data have been deleted Successfully");

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

        private void BTNClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu", con);
            DataTable Edt = new DataTable();
            Esda.Fill(Edt);

            ProductDGV.DataSource=Edt;
            clear();
            con.Close();
        }

        private void ItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemID_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ItemID.Text, num))
            {
                if (int.Parse(ItemID.Text)>=1)
                {
                    ErrorItemID.Clear();
                    EIDcount=0;
                }
                else
                {
                    ErrorItemID.SetError(this.ItemID, "Id can't be lower than 0");
                    EIDcount=1;
                }
            }
            else
            {
                ErrorItemID.SetError(this.ItemID, "Only Input numeric values");
                EIDcount=1;
            }
        }

        private void ItemName_Leave(object sender, EventArgs e)
        {

            if (Regex.IsMatch(ItemName.Text, EName))
            {
                ErrorItemName.Clear();
                ENamecount=0;
            }
            else
            {
                ErrorItemName.SetError(this.ItemName, "No Special Characters");
                ENamecount = 1;
            }
        }

        

        private void TextIDsearch_Leave(object sender, EventArgs e)
        {

        }

        private void TextNameSearch_Leave(object sender, EventArgs e)
        {

            
        }

        private void BTNSearchID_Click(object sender, EventArgs e)
        {

            if (TextIDsearch.Text=="")
            {
                MessageBox.Show("Enter a ID to start your search");
            }
            else
            {


                if (Regex.IsMatch(TextIDsearch.Text, num))
                {
                    if (int.Parse(TextIDsearch.Text)>=1)
                    {
                        int MenuID = int.Parse(TextIDsearch.Text);

                        con.Open();
                        SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu where MenuItemID = '"+MenuID+"'", con);
                        DataTable Edt = new DataTable();
                        Esda.Fill(Edt);

                        ProductDGV.DataSource=Edt;
                        clear();
                        con.Close();


                    }
                    else
                    {
                        ErrorSearchId.SetError(this.TextIDsearch, "Id can't be lower than 0");

                    }
                }
                else
                {
                    ErrorSearchId.SetError(this.TextIDsearch, "Only Input numeric values");

                }

            }
        }

        private void BTNSearchName_Click(object sender, EventArgs e)
        {
            if (TextNameSearch.Text=="")
            {
                MessageBox.Show("Enter a Name to start your search");
            }
            else
            {


                if (Regex.IsMatch(TextNameSearch.Text, EName))
                {
                    con.Open();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu where MenuItemName = '"+TextNameSearch.Text+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    ProductDGV.DataSource=Edt;
                    clear();
                    con.Close();
                }
                else
                {
                    ErrorSearchName.SetError(this.TextNameSearch, "No special characters");

                }

            }
        }

        private void MenuItemPrice_Leave(object sender, EventArgs e)
        {
            
        }

        private void Itemtype_Leave(object sender, EventArgs e)
        {
            if (Itemtype.SelectedIndex>=0)
            {
                ErrorItemType.Clear();
                ETypecount=0;
            }
            else
            {
                ErrorItemType.SetError(this.Itemtype, "Choose from one of the given types");
                ETypecount = 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ADD_Product_Load(object sender, EventArgs e)
        {
            Itemtype.Items.Add("Veg");
            Itemtype.Items.Add("Non-Veg");
            Itemtype.Items.Add("Soft Drink");
            Itemtype.Items.Add("Drink");
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (ItemName.Text==""||MenuItemPrice.Text==""||Itemtype.Text=="")
            {
                MessageBox.Show("Please Enter all the details");
                count();

            }
            else if ((count() == 0) && (TextNameSearch.Text!=""||MenuItemPrice.Text!=""||Itemtype.Text!=""))
            {

                try
                {
                    int Price = int.Parse(MenuItemPrice.Text);
                    int MenuID = int.Parse(ItemID.Text);


                    con.Open();
                    cmd=new SqlCommand("insert into Menu (MenuItemID,MenuItemName,MenuItemPrice,MenuItemType) values ('"+MenuID+"','"+ItemName.Text+"','"+Price+"','"+Itemtype.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Esda = new SqlDataAdapter("Select MenuItemID as ID,MenuItemName As Name,MenuItemPrice as Price,MenuItemType as Type from Menu where MenuItemID = '"+MenuID+"'", con);
                    DataTable Edt = new DataTable();
                    Esda.Fill(Edt);

                    ProductDGV.DataSource=Edt;
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
