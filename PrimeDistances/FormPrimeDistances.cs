using PrimesInRange;
using System.Data;

namespace PrimeDistances
{
    public partial class FormPrimeDistances : FormBasePrime
    {
        public FormPrimeDistances()
        {
            Text = "Ü3: Primzahl Differenzbestimmung";
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
                String columnNameDelta = "Differenz";
                String columnNameAmount = "Anzahl";

                List<int> primes = _primeService.GetPrimesInRange(
                    lowerLimit,
                    upperLimit
                    );

                Dictionary<int, int> distances = _primeService.GetPrimeDistances(primes);

                var dataTable = new DataTable();
                dataTable.Columns.Add(columnNameDelta, typeof(int));
                dataTable.Columns.Add(columnNameAmount, typeof(int));

                for (int i = 0; i < distances.Count; i++)
                {
                    int key = distances.Keys.ElementAt(i);
                    dataTable.Rows.Add(key, distances[key]);
                }

                // enable sorting on delta column
                dataTable.DefaultView.Sort = columnNameDelta + " DESC";

                // bind dataTable to DataGridView
                dataGridView.DataSource = dataTable;

                // resize according to content
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    }
}
