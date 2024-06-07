using System.Data;
using WinFormsUtil;

namespace PrimesInRange
{
    public partial class FormPrimesInRange : Form
    {
        private readonly PrimeService _primeService;
        private readonly Validator _validator;
        private readonly ErrorDumper _err;

        public FormPrimesInRange()
        {
            InitializeComponent();

            _primeService = new();
            _validator = new(errorProvider);
            _err = new("Bitte wenden Sie sich an einen Administrator.");
        }

        /// <summary>
        ///  Determine whether the form is valid by checking input values
        ///  against regular expressions.
        /// </summary>
        /// <returns>
        ///  True if every control passed the validation check, false otherwise.
        /// </returns>
        private bool IsFormValid()
        {
            string intPattern = "^[0-9]\\d*$";
            string intError = "Please enter a whole number.";

            return
                _validator.IsValid(numericUpDownLower, intPattern, intError) &&
                _validator.IsValid(numericUpDownUpper, intPattern, intError) &&
                true;
        }

        private void PopulateDataGridView(
            Control numLower,
            Control numUpper,
            Control dataGridView
            )
        {
            if (
                int.TryParse(numLower.Text, out int lowerLimit) &&
                int.TryParse(numUpper.Text, out int upperLimit)
                )
            {
                String columnNameIndex = "#";
                String columnNamePrimes = "PrimeNumbers";

                List<int> primes = _primeService.GetPrimesInRange(
                    lowerLimit,
                    upperLimit
                    );
                var dataTable = new DataTable();
                dataTable.Columns.Add(columnNameIndex, typeof(int));
                dataTable.Columns.Add(columnNamePrimes, typeof(int));

                for (int i = 0; i < primes.Count; i++)
                {
                    dataTable.Rows.Add(i + 1, primes[i]);
                }

                dataGridViewPrimes.DataSource = dataTable;

                // resize according to content
                dataGridViewPrimes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPrimes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void buttonFindPrimes_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFormValid())
                {
                    PopulateDataGridView(
                        numericUpDownLower,
                        numericUpDownUpper,
                        dataGridViewPrimes
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
