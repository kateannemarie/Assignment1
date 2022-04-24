namespace Project1
{
    public partial class tbAccountName : Form
    {
        public tbAccountName()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String middleName = tbMiddleName.Text;
            String lastName = tbLastName.Text;
            lbGoodDay.Text = "Good day, " + firstName + " " + middleName + " " + lastName + "!";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            tbLastName.Text = "";
            lbGoodDay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbGoodDay.Text = "";
        }

        private void lbGoodDay_Click(object sender, EventArgs e)
        {

        }
    }
}