using WinFormsUtil;

namespace PrimesInRange
{
    public abstract partial class BasePrimeForm : Form
    {
        protected readonly PrimeService _primeService;
        protected readonly Validator _validator;

        public BasePrimeForm()
        {
            InitializeComponent();

            _primeService = new();
            _validator = new(errorProvider);
        }

        protected bool IsFormValid()
        {
            string intPattern = "^[0-9]\\d*$";
            string intError = "Bitte geben Sie eine ganze Zahl ein.";

            return
                _validator.IsValid(numericUpDownLower, intPattern, intError) &&
                _validator.IsValid(numericUpDownUpper, intPattern, intError);
        }

        protected abstract void ButtonCalculate_Click(object sender, EventArgs e);
    }
}
