namespace GPAcalculatorr
{
    public partial class Form1 : Form
    {
        double sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///4.00
            string strInput = textBoxGPA_input.Text;
            
            double sum = 0.0;

            double dInput = double.Parse(strInput);
            ///sum = 0.0 + 4.00
            sum = sum + dInput;

            textBoxGPAX.Text = sum.ToString();

        }

       
    }
}