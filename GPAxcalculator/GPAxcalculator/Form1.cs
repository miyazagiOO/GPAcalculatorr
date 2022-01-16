namespace GPAxcalculator
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        double max = 0;
         public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///4.00
            string strInput = this.textBoxGPA_input.Text;
            double dInput = double. Parse(strInput);
           
            if (dInput > max)
                max = dInput;

            ///sum = 0.0 + 4.00
            sum = sum + dInput;
            n = n+ 1;
            
            double result = sum / n;
            textBoxGPAx.Text = result.ToString();

            textBoxName_input.Text = "";
            textBoxMAX_GPA.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxName_input.Text = "";
            textBoxMAX_GPA.Text = "";
            textBoxMin_GPA.Text = "";

            sum = 0;
            n = 0;
        }
    }
}