namespace C__MS_Calculator
{
    public partial class CalculatorForm : Form
    {
        private Calculator calculator;

        public CalculatorForm()
        {
            InitializeComponent();

            calculator = new Calculator();
        }

        private void CalcOutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_Button_Click(object sender, EventArgs e)
        {

        }

        private void MC_Button_Click(object sender, EventArgs e)
        {

        }

        private void MR_Button_Click(object sender, EventArgs e)
        {

        }

        private void MS_Button_Click(object sender, EventArgs e)
        {

        }

        private void MPlus_Button_Click(object sender, EventArgs e)
        {

        }

        private void MMinus_Button_Click(object sender, EventArgs e)
        {

        }

        private void Backspace_Button_Click(object sender, EventArgs e)
        {

        }

        private void CE_Button_Click(object sender, EventArgs e)
        {

        }

        private void C_Button_Click(object sender, EventArgs e)
        {

        }

        private void ChangeSign_Button_Click(object sender, EventArgs e)
        {

        }

        private void Sqrt_Button_Click(object sender, EventArgs e)
        {

        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {

        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {

        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {

        }

        private void Percentage_Button_Click(object sender, EventArgs e)
        {

        }

        private void Four_Button_Click(object sender, EventArgs e)
        {

        }

        private void Five_Button_Click(object sender, EventArgs e)
        {

        }

        private void Six_Button_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {

        }

        private void Reciprocal_Button_Click(object sender, EventArgs e)
        {

        }

        private void One_Button_Click(object sender, EventArgs e)
        {

        }

        private void Two_Button_Click(object sender, EventArgs e)
        {

        }

        private void Three_Button_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {

        }

        private void Decimal_Button_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {

        }
    }

    internal class Calculator
    {
        private decimal answer;

        public Calculator()
        {
            answer = 0;
        }

        public decimal Answer()
        {
            return answer;
        }
    }
}