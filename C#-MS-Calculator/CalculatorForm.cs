using System.Numerics;

namespace C__MS_Calculator
{
    public partial class CalculatorForm : Form
    {
        private double prevNumber = 0;
        private double memoryNumber = 0;
        private Operation_Enum operation = Operation_Enum.None;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void MC_Button_Click(object sender, EventArgs e)
        {
            memoryNumber = 0;
        }

        private void MR_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = memoryNumber.ToString();
        }

        private void MS_Button_Click(object sender, EventArgs e)
        {
            memoryNumber = double.Parse(CalcOutputTextBox.Text);
        }

        private void MPlus_Button_Click(object sender, EventArgs e)
        {
            memoryNumber += double.Parse(CalcOutputTextBox.Text);
        }

        private void MMinus_Button_Click(object sender, EventArgs e)
        {
            memoryNumber -= double.Parse(CalcOutputTextBox.Text);
        }

        private void Backspace_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text.Length > 1)
            {
                CalcOutputTextBox.Text = CalcOutputTextBox.Text.Remove(CalcOutputTextBox.Text.Length - 1);
            }
            else
            {
                CalcOutputTextBox.Text = "0";
            }
        }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = "0";
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            CalcAnswerTextBox.Text = "";
            CalcOutputTextBox.Text = "0";
            prevNumber = 0;
            operation = Operation_Enum.None;
        }

        private void ChangeSign_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = (double.Parse(CalcOutputTextBox.Text) * -1).ToString();
        }

        private void Sqrt_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = Math.Sqrt(double.Parse(CalcOutputTextBox.Text)).ToString();
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "7";
            }
            else
            {
                CalcOutputTextBox.Text += "7";
            }
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "8";
            }
            else
            {
                CalcOutputTextBox.Text += "8";
            }
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "9";
            }
            else
            {
                CalcOutputTextBox.Text += "9";
            }
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "4";
            }
            else
            {
                CalcOutputTextBox.Text += "4";
            }
        }

        private void Five_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "5";
            }
            else
            {
                CalcOutputTextBox.Text += "5";
            }
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "6";
            }
            else
            {
                CalcOutputTextBox.Text += "6";
            }
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "1";
            }
            else
            {
                CalcOutputTextBox.Text += "1";
            }
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "2";
            }
            else
            {
                CalcOutputTextBox.Text += "2";
            }
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "3";
            }
            else
            {
                CalcOutputTextBox.Text += "3";
            }
        }

        private void Zero_Button_Click(object sender, EventArgs e)
        {
            if (CalcOutputTextBox.Text == "0")
            {
                CalcOutputTextBox.Text = "0";
            }
            else
            {
                CalcOutputTextBox.Text += "0";
            }
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            operation = Operation_Enum.Divide;

            prevNumber = double.Parse(CalcOutputTextBox.Text);

            CalcAnswerTextBox.Text = CalcOutputTextBox.Text += " ÷ ";

            CalcOutputTextBox.Text = "0";
        }

        private void Percentage_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = (double.Parse(CalcOutputTextBox.Text) / 100).ToString();
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            operation = Operation_Enum.Multiply;

            prevNumber = double.Parse(CalcOutputTextBox.Text);

            CalcAnswerTextBox.Text = CalcOutputTextBox.Text += " × ";

            CalcOutputTextBox.Text = "0";
        }

        private void Reciprocal_Button_Click(object sender, EventArgs e)
        {
            CalcOutputTextBox.Text = (1 / double.Parse(CalcOutputTextBox.Text)).ToString();
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            operation = Operation_Enum.Subtract;

            prevNumber = double.Parse(CalcOutputTextBox.Text);

            CalcAnswerTextBox.Text = CalcOutputTextBox.Text += " - ";

            CalcOutputTextBox.Text = "0";
        }

        private void Decimal_Button_Click(object sender, EventArgs e)
        {
            if (!CalcOutputTextBox.Text.Contains("."))
            {
                CalcOutputTextBox.Text += ".";
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            operation = Operation_Enum.Add;

            prevNumber = double.Parse(CalcOutputTextBox.Text);

            CalcAnswerTextBox.Text = CalcOutputTextBox.Text += " + ";

            CalcOutputTextBox.Text = "0";
        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {
            if (operation != Operation_Enum.None)
            {
                CalcAnswerTextBox.Text += CalcOutputTextBox.Text + " =";
            }

            try
            {
                switch (operation)
                {
                    case Operation_Enum.Add:
                        CalcOutputTextBox.Text = (prevNumber + double.Parse(CalcOutputTextBox.Text)).ToString();
                        break;
                    case Operation_Enum.Subtract:
                        CalcOutputTextBox.Text = (prevNumber - double.Parse(CalcOutputTextBox.Text)).ToString();
                        break;
                    case Operation_Enum.Multiply:
                        CalcOutputTextBox.Text = (prevNumber * double.Parse(CalcOutputTextBox.Text)).ToString();
                        break;
                    case Operation_Enum.Divide:
                        CalcOutputTextBox.Text = (prevNumber / double.Parse(CalcOutputTextBox.Text)).ToString();
                        break;
                    case Operation_Enum.None:
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                CalcOutputTextBox.Text = "Error";
            }
        }

        internal enum Operation_Enum
        {
            None = 0,
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4
        }

        internal class Calculator
        {
            private double memoryNumber;
            private List<KeyValuePair<Operation_Enum, double>> prevValues;

            public Calculator()
            {
                memoryNumber = 0;
                prevValues = new List<KeyValuePair<Operation_Enum, double>>();
            }

            public void AddValue(Operation_Enum operation, double value)
            {
                prevValues.Add(new KeyValuePair<Operation_Enum, double>(operation, value));
            }

            public int ValueCount()
            {
                return prevValues.Count;
            }

            public string Calculate()
            {
                double result = prevValues[0].Value;

                try
                {
                    for (int i = 1; i < prevValues.Count; ++i)
                    {
                        switch (prevValues[i].Key)
                        {
                            case Operation_Enum.Add:
                                result += prevValues[i].Value;
                                break;
                            case Operation_Enum.Subtract:
                                result -= prevValues[i].Value;
                                break;
                            case Operation_Enum.Multiply:
                                result *= prevValues[i].Value;
                                break;
                            case Operation_Enum.Divide:
                                result /= prevValues[i].Value;
                                break;
                            case Operation_Enum.None:
                            default:
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    return "Error";
                }

                return result.ToString();
            }

            public double memory
            {
                get
                {
                    return memoryNumber;
                }
                set
                {
                    memoryNumber = value;
                }
            }

            public void MemoryAdd(double value)
            {
                memoryNumber += value;
            }

            public void MemorySubtract(double value)
            {
                memoryNumber -= value;
            }

            public void Clear()
            {
                memoryNumber = 0;
                prevValues.Clear();
            }

            public void ClearMemory()
            {
                memoryNumber = 0;
            }
        }
    }
}