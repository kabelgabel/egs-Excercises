using WinFormsUtil;

namespace PrimesInRange
{
    public abstract partial class FormBasePrime : Form
    {
        protected readonly PrimeService _primeService;
        protected readonly Validator _validator;
        protected readonly ErrorDumper _err;

        public FormBasePrime()
        {
            InitializeComponent();

            _primeService = new();
            _validator = new(errorProvider);
            _err = new("Bitte wenden Sie sich an einen Administrator.");
        }

        protected bool IsFormValid()
        {
            string intPattern = "^[0-9]\\d*$";
            string intError = "Bitte geben Sie eine ganze Zahl ein.";

            return
                _validator.IsValid(numericUpDownLower, intPattern, intError) &&
                _validator.IsValid(numericUpDownUpper, intPattern, intError) &&
                true;
        }

        protected abstract void ButtonCalculate_Click(object sender, EventArgs e);
    }
}
