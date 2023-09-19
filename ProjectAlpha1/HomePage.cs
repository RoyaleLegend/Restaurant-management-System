namespace ProjectAlpha1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BTNmanager_Click(object sender, EventArgs e)
        {
            Manager_Registration MAR = new Manager_Registration();
            MAR.Show();
        }

        private void BTNemployee_Click(object sender, EventArgs e)
        {
            Employee_Register EMR = new Employee_Register();
            EMR.Show();
        }

        private void BTNMenu_Click(object sender, EventArgs e)
        {
            ADD_Product ADP=new ADD_Product();
            ADP.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BTNmanager_Click_1(object sender, EventArgs e)
        {

        }

        private void BTNtotalsale_Click(object sender, EventArgs e)
        {

        }
    }
}