namespace HotelReswervation
{
    public partial class DashboardForm : Form
    {
        LoginPageForm loginPageForm;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPageForm = new LoginPageForm();
            loginPageForm.ShowDialog();
        }
    }
}
