using System.Text.RegularExpressions;

namespace Calculator
{
    internal class Validator
    {
        private readonly ErrorProvider _errorProvider;

        public Validator(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        /// <summary>
        ///  Determine whether the control content is valid and update its error message.
        /// </summary>
        public bool IsValid(Control control, string regexPattern, string errorMessage = "invalid input")
        {
            Regex regex = new Regex(regexPattern);
            Match match = regex.Match(control.Text);
            if (!match.Success)
            {
                _errorProvider.SetError(control, errorMessage);
                return false;
            }
            _errorProvider.SetError(control, "");
            return true;
        }
    }
}

