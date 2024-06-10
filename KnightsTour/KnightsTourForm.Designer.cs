namespace KnightsTour
{
    partial class KnightsTourForm
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
            flowLayoutPanelBoard = new FlowLayoutPanel();
            groupBoxSettings = new GroupBox();
            labelSettingBoardSize = new Label();
            labelSettingSquares = new Label();
            numericSettingBoardSize = new NumericUpDown();
            numericSettingSquares = new NumericUpDown();
            groupBoxBoard = new GroupBox();
            ButtonBoardInit = new Button();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSettingBoardSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSettingSquares).BeginInit();
            groupBoxBoard.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBoard
            // 
            flowLayoutPanelBoard.Location = new Point(5, 20);
            flowLayoutPanelBoard.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelBoard.Name = "flowLayoutPanelBoard";
            flowLayoutPanelBoard.Size = new Size(350, 300);
            flowLayoutPanelBoard.TabIndex = 0;
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(labelSettingBoardSize);
            groupBoxSettings.Controls.Add(labelSettingSquares);
            groupBoxSettings.Controls.Add(numericSettingBoardSize);
            groupBoxSettings.Controls.Add(numericSettingSquares);
            groupBoxSettings.Location = new Point(10, 9);
            groupBoxSettings.Margin = new Padding(3, 2, 3, 2);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Padding = new Padding(3, 2, 3, 2);
            groupBoxSettings.Size = new Size(219, 164);
            groupBoxSettings.TabIndex = 1;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Einstellungen";
            // 
            // labelSettingBoardSize
            // 
            labelSettingBoardSize.AutoSize = true;
            labelSettingBoardSize.Location = new Point(5, 52);
            labelSettingBoardSize.Name = "labelSettingBoardSize";
            labelSettingBoardSize.Size = new Size(92, 15);
            labelSettingBoardSize.TabIndex = 3;
            labelSettingBoardSize.Text = "Brettgröße in px";
            // 
            // labelSettingSquares
            // 
            labelSettingSquares.AutoSize = true;
            labelSettingSquares.Location = new Point(5, 22);
            labelSettingSquares.Name = "labelSettingSquares";
            labelSettingSquares.Size = new Size(69, 15);
            labelSettingSquares.TabIndex = 2;
            labelSettingSquares.Text = "Felder/Seite";
            // 
            // numericSettingBoardSize
            // 
            numericSettingBoardSize.Location = new Point(122, 51);
            numericSettingBoardSize.Margin = new Padding(3, 2, 3, 2);
            numericSettingBoardSize.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            numericSettingBoardSize.Minimum = new decimal(new int[] { 400, 0, 0, 0 });
            numericSettingBoardSize.Name = "numericSettingBoardSize";
            numericSettingBoardSize.Size = new Size(70, 23);
            numericSettingBoardSize.TabIndex = 1;
            numericSettingBoardSize.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // numericSettingSquares
            // 
            numericSettingSquares.Location = new Point(122, 20);
            numericSettingSquares.Margin = new Padding(3, 2, 3, 2);
            numericSettingSquares.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numericSettingSquares.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericSettingSquares.Name = "numericSettingSquares";
            numericSettingSquares.Size = new Size(70, 23);
            numericSettingSquares.TabIndex = 0;
            numericSettingSquares.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // groupBoxBoard
            // 
            groupBoxBoard.AutoSize = true;
            groupBoxBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxBoard.Controls.Add(flowLayoutPanelBoard);
            groupBoxBoard.Location = new Point(234, 9);
            groupBoxBoard.Margin = new Padding(3, 2, 3, 2);
            groupBoxBoard.Name = "groupBoxBoard";
            groupBoxBoard.Padding = new Padding(3, 2, 3, 2);
            groupBoxBoard.Size = new Size(361, 340);
            groupBoxBoard.TabIndex = 2;
            groupBoxBoard.TabStop = false;
            groupBoxBoard.Text = "Board";
            // 
            // ButtonBoardInit
            // 
            ButtonBoardInit.Location = new Point(10, 177);
            ButtonBoardInit.Margin = new Padding(3, 2, 3, 2);
            ButtonBoardInit.Name = "ButtonBoardInit";
            ButtonBoardInit.Size = new Size(219, 22);
            ButtonBoardInit.TabIndex = 1;
            ButtonBoardInit.Text = "Board initialisieren";
            ButtonBoardInit.UseVisualStyleBackColor = true;
            ButtonBoardInit.Click += ButtonBoardInit_Click;
            // 
            // FormKnightsTour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(962, 688);
            Controls.Add(ButtonBoardInit);
            Controls.Add(groupBoxBoard);
            Controls.Add(groupBoxSettings);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormKnightsTour";
            Text = "Ü4 Schachbrett Knights Tour";
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSettingBoardSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSettingSquares).EndInit();
            groupBoxBoard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBoard;
        private GroupBox groupBoxSettings;
        private GroupBox groupBoxBoard;
        private Label labelSettingSquares;
        private NumericUpDown numericSettingSquares;
        private Label labelSettingBoardSize;
        private Button ButtonBoardInit;
        private NumericUpDown numericSettingBoardSize;
    }
}
