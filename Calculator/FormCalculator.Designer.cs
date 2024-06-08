namespace Calculator
{
    partial class FormCalculator
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

        /// <summary>
        ///  Populates ComboBox with the items from provided list of strings.
        /// </summary>
        /// <param name="cb">ComboBox control which will get populated</param>
        /// <param name="l">list of strings that will be added to the ComboBox's items collection</param>
        private void PopulateComboBoxItems(ComboBox cb, List<String> l)
        {
            cb.Items.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                cb.Items.Add(l[i]);
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupInputs = new GroupBox();
            textBoxInput2 = new TextBox();
            textBoxInput1 = new TextBox();
            groupOperation = new GroupBox();
            buttonCalculate = new Button();
            comboBoxOperator = new ComboBox();
            errorProvider = new ErrorProvider(components);
            groupResult = new GroupBox();
            labelResult = new Label();
            groupInputs.SuspendLayout();
            groupOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupInputs
            // 
            groupInputs.Controls.Add(textBoxInput2);
            groupInputs.Controls.Add(textBoxInput1);
            groupInputs.Location = new Point(12, 12);
            groupInputs.Name = "groupInputs";
            groupInputs.RightToLeft = RightToLeft.No;
            groupInputs.Size = new Size(175, 85);
            groupInputs.TabIndex = 0;
            groupInputs.TabStop = false;
            groupInputs.Text = "Eingaben";
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(6, 51);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(150, 23);
            textBoxInput2.TabIndex = 5;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(6, 22);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(150, 23);
            textBoxInput1.TabIndex = 1;
            // 
            // groupOperation
            // 
            groupOperation.Controls.Add(buttonCalculate);
            groupOperation.Controls.Add(comboBoxOperator);
            groupOperation.Location = new Point(194, 12);
            groupOperation.Name = "groupOperation";
            groupOperation.RightToLeft = RightToLeft.No;
            groupOperation.Size = new Size(100, 85);
            groupOperation.TabIndex = 1;
            groupOperation.TabStop = false;
            groupOperation.Text = "Operation";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(6, 51);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Berechnen";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.Location = new Point(6, 22);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(75, 23);
            comboBoxOperator.TabIndex = 2;
            comboBoxOperator.Text = "+";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // groupResult
            // 
            groupResult.Controls.Add(labelResult);
            groupResult.Location = new Point(12, 103);
            groupResult.Name = "groupResult";
            groupResult.Size = new Size(282, 43);
            groupResult.TabIndex = 2;
            groupResult.TabStop = false;
            groupResult.Text = "Ergebnis";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 19);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(13, 15);
            labelResult.TabIndex = 0;
            labelResult.Text = "0";
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 165);
            Controls.Add(groupResult);
            Controls.Add(groupOperation);
            Controls.Add(groupInputs);
            Name = "FormCalculator";
            Text = "Ü1: Taschenrechner";
            groupInputs.ResumeLayout(false);
            groupInputs.PerformLayout();
            groupOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupResult.ResumeLayout(false);
            groupResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInputs;
        private GroupBox groupOperation;
        private Button buttonCalculate;
        private ComboBox comboBoxOperator;
        private ErrorProvider errorProvider;
        private TextBox textBoxInput2;
        private TextBox textBoxInput1;
        private GroupBox groupResult;
        private Label labelResult;
    }
}
