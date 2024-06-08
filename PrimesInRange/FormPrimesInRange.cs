using System.Data;

namespace PrimesInRange
{
    internal class FormPrimesInRange : FormBasePrime
    {
        public FormPrimesInRange() {
            Text = "Ü2: Primzahl-Bestimmung";
        }

        protected override void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFormValid())
                {
                    PopulateDataGridView(
                        numericUpDownLower,
                        numericUpDownUpper,
                        dataGridViewResults
                        );
                }
            }
            catch (Exception ex)
            {
                _err.Dump(ex);
            }
        }

        private void PopulateDataGridView(
            Control numLower,
            Control numUpper,
            DataGridView dataGridView
            )
        {
            if (
                int.TryParse(numLower.Text, out int lowerLimit) &&
                int.TryParse(numUpper.Text, out int upperLimit)
                )
            {
                String columnNameIndex = "#";
                String columnNamePrimes = "Primzahlen";

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

                // bind dataTable to DataGridView
                dataGridView.DataSource = dataTable;

                // resize according to content
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    }
}
