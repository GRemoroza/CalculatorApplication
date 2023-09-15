namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private double num1;
        private double num2;
        private CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string selectedOperator = cbOperator.SelectedItem?.ToString();

            if (selectedOperator != null)
            {

                if (double.TryParse(txtBoxInput1.Text, out double num1) && double.TryParse(txtBoxInput2.Text, out double num2))
                {
                    switch (selectedOperator)
                    {
                        case "+":
                            lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                            break;
                        case "-":
                            lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                            break;
                        case "*":
                            lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                            }
                            else
                            {
                                lblDisplayTotal.Text = "Division by zero error";
                            }
                            break;
                        default:
                            lblDisplayTotal.Text = "Invalid operator";
                            break;
                    }
                }
                else
                {
                    lblDisplayTotal.Text = "Invalid input";
                }
            }
        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }
    }
}