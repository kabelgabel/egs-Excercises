using Calculator.Operators;
using WinFormsUtil;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private readonly OperatorService _operatorService;
        private readonly Validator _validator;
        private readonly ErrorDumper _err;

        public FormCalculator()
        {
            InitializeComponent();

            _operatorService = new();
            _validator = new(errorProvider);
            _err = new("Bitte wenden Sie sich an einen Administrator.");

            try
            {
                PopulateComboBoxItems(
                    comboBoxOperator,
                    _operatorService.GetAllLiterals()
                    );
            }
            catch (Exception ex)
            {
                _err.Dump(ex);
            }
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

            string operatorPattern = _operatorService.GetRegexPattern();
            string operatorError = "Bitte wählen Sie eine Rechenoperation.";

            return
                _validator.IsValid(textBoxInput1, decimalPattern, decimalError) &&
                _validator.IsValid(textBoxInput2, decimalPattern, decimalError) &&
                _validator.IsValid(comboBoxOperator, operatorPattern, operatorError) &&
                true;
        }

        private void Calculate(
            Control textBoxInput1,
            Control textBoxInput2,
            ComboBox comboBoxOperator,
            Control labelResult
            )
        {
            // accept numbers with both . and , as decimal separators
            string input1 = textBoxInput1.Text.Replace(".", ",");
            string input2 = textBoxInput2.Text.Replace(".", ",");

            float result = 0;

            // if float casting was successful ...
            if (
                float.TryParse(input1, out float operand1) &&
                float.TryParse(input2, out float operand2)
                )
            {
                IOperator op = _operatorService.GetOperatorByLiteral(comboBoxOperator.Text);
                // ... do the calculation
                try
                {
                    result = op.run(operand1, operand2);
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFormValid())
                {
                    Calculate(
                        textBoxInput1,
                        textBoxInput2,
                        comboBoxOperator,
                        labelResult
                        );
                }
            }
            catch (Exception ex)
            {
                _err.Dump(ex);
            }
        }
    }
}
