using WinFormsUtil;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly Calculator _calculator;
        private readonly Validator _validator;

        public CalculatorForm()
        {
            InitializeComponent();

            _calculator = new Calculator();
            _validator = new(errorProvider);

            PopulateComboBoxItems(
                comboBoxOperator,
                _calculator.GetAllLiterals()
                );
        }

        /// <summary>
        ///  Determine whether the form is valid by checking input values against regular expressions.
        /// </summary>
        /// <returns>
        ///  True if every control passed the validation check, false otherwise.
        /// </returns>
        private bool IsFormValid()
        {
            string decimalPattern = "^[+-]?([0-9]*[,.])?[0-9]+$";
            string decimalError = "Bitte geben Sie eine Zahl ein.";

            string operatorPattern = _calculator.GetRegexPattern();
            string operatorError = "Bitte wählen Sie eine Rechenoperation.";

            return
                _validator.IsValid(textBoxInput1, decimalPattern, decimalError) &&
                _validator.IsValid(textBoxInput2, decimalPattern, decimalError) &&
                _validator.IsValid(comboBoxOperator, operatorPattern, operatorError);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                // accept numbers with both . and , as decimal separators
                string input1 = textBoxInput1.Text.Replace(".", ",");
                string input2 = textBoxInput2.Text.Replace(".", ",");

                if (
                    float.TryParse(input1, out float operand1) &&
                    float.TryParse(input2, out float operand2)
                    )
                {
                    float result = 0;
                    try
                    {
                        result = _calculator.Calculate(operand1, operand2, comboBoxOperator.Text);
                    }
                    catch (DivideByZeroException)
                    {
                        errorProvider.SetError(
                            textBoxInput2,
                            "Teilung durch 0 ist nicht möglich. Bitte geben Sie einen gültigen zweiten Operanden ein."
                            );
                        result = 0;
                    }
                    labelResult.Text = result.ToString();
                }
            }
        }
    }
}
