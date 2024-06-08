namespace PrimesInRange
{
    public abstract partial class FormBasePrime
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
            ButtonCalculate = new Button();
            dataGridViewResults = new DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownLower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpper).BeginInit();
            groupBoxLowerLimit.SuspendLayout();
            groupBoxUpperLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
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
            groupBoxLowerLimit.Text = "Untergrenze";
            // 
            // groupBoxUpperLimit
            // 
            groupBoxUpperLimit.Controls.Add(numericUpDownUpper);
            groupBoxUpperLimit.Location = new Point(12, 71);
            groupBoxUpperLimit.Name = "groupBoxUpperLimit";
            groupBoxUpperLimit.Size = new Size(150, 53);
            groupBoxUpperLimit.TabIndex = 3;
            groupBoxUpperLimit.TabStop = false;
            groupBoxUpperLimit.Text = "Obergrenze";
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(18, 130);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(125, 25);
            ButtonCalculate.TabIndex = 4;
            ButtonCalculate.Text = "Berechnen";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AllowUserToAddRows = false;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(168, 12);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersVisible = false;
            dataGridViewResults.Size = new Size(200, 300);
            dataGridViewResults.TabIndex = 5;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormBasePrime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 317);
            Controls.Add(dataGridViewResults);
            Controls.Add(ButtonCalculate);
            Controls.Add(groupBoxUpperLimit);
            Controls.Add(groupBoxLowerLimit);
            Name = "FormBasePrime";
            Text = "FormBasePrime";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLower).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpper).EndInit();
            groupBoxLowerLimit.ResumeLayout(false);
            groupBoxUpperLimit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected NumericUpDown numericUpDownLower;
        protected NumericUpDown numericUpDownUpper;
        protected GroupBox groupBoxLowerLimit;
        protected GroupBox groupBoxUpperLimit;
        protected Button ButtonCalculate;
        protected DataGridView dataGridViewResults;
        protected ErrorProvider errorProvider;
    }
}
