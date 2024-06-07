namespace PrimesInRange
{
    partial class FormPrimesInRange
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            numericUpDownLower = new NumericUpDown();
            numericUpDownUpper = new NumericUpDown();
            groupBoxLowerLimit = new GroupBox();
            groupBoxUpperLimit = new GroupBox();
            buttonFindPrimes = new Button();
            dataGridViewPrimes = new DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownLower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpper).BeginInit();
            groupBoxLowerLimit.SuspendLayout();
            groupBoxUpperLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownLower
            // 
            numericUpDownLower.Location = new Point(6, 21);
            numericUpDownLower.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownLower.Name = "numericUpDownLower";
            numericUpDownLower.Size = new Size(125, 23);
            numericUpDownLower.TabIndex = 0;
            numericUpDownLower.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownUpper
            // 
            numericUpDownUpper.Location = new Point(6, 22);
            numericUpDownUpper.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownUpper.Name = "numericUpDownUpper";
            numericUpDownUpper.Size = new Size(125, 23);
            numericUpDownUpper.TabIndex = 1;
            numericUpDownUpper.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBoxLowerLimit
            // 
            groupBoxLowerLimit.Controls.Add(numericUpDownLower);
            groupBoxLowerLimit.Location = new Point(12, 12);
            groupBoxLowerLimit.Name = "groupBoxLowerLimit";
            groupBoxLowerLimit.Size = new Size(150, 53);
            groupBoxLowerLimit.TabIndex = 2;
            groupBoxLowerLimit.TabStop = false;
            groupBoxLowerLimit.Text = "Lower Limit";
            // 
            // groupBoxUpperLimit
            // 
            groupBoxUpperLimit.Controls.Add(numericUpDownUpper);
            groupBoxUpperLimit.Location = new Point(12, 71);
            groupBoxUpperLimit.Name = "groupBoxUpperLimit";
            groupBoxUpperLimit.Size = new Size(150, 53);
            groupBoxUpperLimit.TabIndex = 3;
            groupBoxUpperLimit.TabStop = false;
            groupBoxUpperLimit.Text = "Upper Limit";
            // 
            // buttonFindPrimes
            // 
            buttonFindPrimes.Location = new Point(18, 130);
            buttonFindPrimes.Name = "buttonFindPrimes";
            buttonFindPrimes.Size = new Size(125, 25);
            buttonFindPrimes.TabIndex = 4;
            buttonFindPrimes.Text = "Find Primes";
            buttonFindPrimes.UseVisualStyleBackColor = true;
            buttonFindPrimes.Click += buttonFindPrimes_Click;
            // 
            // dataGridViewPrimes
            // 
            dataGridViewPrimes.AllowUserToAddRows = false;
            dataGridViewPrimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrimes.Location = new Point(168, 12);
            dataGridViewPrimes.Name = "dataGridViewPrimes";
            dataGridViewPrimes.RowHeadersVisible = false;
            dataGridViewPrimes.Size = new Size(200, 300);
            dataGridViewPrimes.TabIndex = 5;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormPrimesInRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 317);
            Controls.Add(dataGridViewPrimes);
            Controls.Add(buttonFindPrimes);
            Controls.Add(groupBoxUpperLimit);
            Controls.Add(groupBoxLowerLimit);
            Name = "FormPrimesInRange";
            Text = "Ex.2: Find prime numbers";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLower).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpper).EndInit();
            groupBoxLowerLimit.ResumeLayout(false);
            groupBoxUpperLimit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownLower;
        private NumericUpDown numericUpDownUpper;
        private GroupBox groupBoxLowerLimit;
        private GroupBox groupBoxUpperLimit;
        private Button buttonFindPrimes;
        private DataGridView dataGridViewPrimes;
        private ErrorProvider errorProvider;
    }
}
