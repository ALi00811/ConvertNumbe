namespace ConvertNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum.Text, out decimal number) && txtNum.Text != "")
            {
                txtNum.Text = number.ToString("#,0.###");
                txtNum.SelectionStart = txtNum.Text.Length;

                var result = Main.ConvertNumber.Converter(txtNum.Text);
                lblText.Text = result;
            }
            else
            {
                lblText.Text = "”·«„!";
            }


        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}