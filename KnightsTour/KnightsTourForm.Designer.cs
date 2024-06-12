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
            ButtonBoardReset = new Button();
            labelSettingBoardSize = new Label();
            labelSettingSquares = new Label();
            ButtonBoardInit = new Button();
            numericSettingBoardSize = new NumericUpDown();
            numericSettingSquares = new NumericUpDown();
            groupBoxBoard = new GroupBox();
            trackBarSim = new TrackBar();
            groupBoxSim = new GroupBox();
            labelSimFoundSolution = new Label();
            textBoxSimFoundSolution = new TextBox();
            textBoxSimStart = new TextBox();
            labelSimStart = new Label();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSettingBoardSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSettingSquares).BeginInit();
            groupBoxBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSim).BeginInit();
            groupBoxSim.SuspendLayout();
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
            groupBoxSettings.Controls.Add(ButtonBoardReset);
            groupBoxSettings.Controls.Add(labelSettingBoardSize);
            groupBoxSettings.Controls.Add(labelSettingSquares);
            groupBoxSettings.Controls.Add(ButtonBoardInit);
            groupBoxSettings.Controls.Add(numericSettingBoardSize);
            groupBoxSettings.Controls.Add(numericSettingSquares);
            groupBoxSettings.Location = new Point(10, 9);
            groupBoxSettings.Margin = new Padding(3, 2, 3, 2);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Padding = new Padding(3, 2, 3, 2);
            groupBoxSettings.Size = new Size(250, 140);
            groupBoxSettings.TabIndex = 1;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Einstellungen";
            // 
            // ButtonBoardReset
            // 
            ButtonBoardReset.Enabled = false;
            ButtonBoardReset.Location = new Point(163, 111);
            ButtonBoardReset.Name = "ButtonBoardReset";
            ButtonBoardReset.Size = new Size(80, 23);
            ButtonBoardReset.TabIndex = 99;
            ButtonBoardReset.Text = "Reset";
            ButtonBoardReset.UseVisualStyleBackColor = true;
            ButtonBoardReset.Click += ButtonBoardReset_Click;
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
            // ButtonBoardInit
            // 
            ButtonBoardInit.Location = new Point(8, 111);
            ButtonBoardInit.Margin = new Padding(3, 2, 3, 2);
            ButtonBoardInit.Name = "ButtonBoardInit";
            ButtonBoardInit.Size = new Size(150, 23);
            ButtonBoardInit.TabIndex = 1;
            ButtonBoardInit.Text = "Board initialisieren";
            ButtonBoardInit.UseVisualStyleBackColor = true;
            ButtonBoardInit.Click += ButtonBoardInit_Click;
            // 
            // numericSettingBoardSize
            // 
            numericSettingBoardSize.Location = new Point(163, 50);
            numericSettingBoardSize.Margin = new Padding(3, 2, 3, 2);
            numericSettingBoardSize.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            numericSettingBoardSize.Minimum = new decimal(new int[] { 400, 0, 0, 0 });
            numericSettingBoardSize.Name = "numericSettingBoardSize";
            numericSettingBoardSize.Size = new Size(80, 23);
            numericSettingBoardSize.TabIndex = 1;
            numericSettingBoardSize.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // numericSettingSquares
            // 
            numericSettingSquares.Location = new Point(163, 20);
            numericSettingSquares.Margin = new Padding(3, 2, 3, 2);
            numericSettingSquares.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numericSettingSquares.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericSettingSquares.Name = "numericSettingSquares";
            numericSettingSquares.Size = new Size(80, 23);
            numericSettingSquares.TabIndex = 0;
            numericSettingSquares.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // groupBoxBoard
            // 
            groupBoxBoard.AutoSize = true;
            groupBoxBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxBoard.Controls.Add(flowLayoutPanelBoard);
            groupBoxBoard.Location = new Point(266, 11);
            groupBoxBoard.Margin = new Padding(3, 2, 3, 2);
            groupBoxBoard.Name = "groupBoxBoard";
            groupBoxBoard.Padding = new Padding(3, 2, 3, 2);
            groupBoxBoard.Size = new Size(361, 340);
            groupBoxBoard.TabIndex = 2;
            groupBoxBoard.TabStop = false;
            groupBoxBoard.Text = "Bitte platzieren Sie den Springer auf einem beliebigen Startfeld";
            // 
            // trackBarSim
            // 
            trackBarSim.Enabled = false;
            trackBarSim.LargeChange = 1;
            trackBarSim.Location = new Point(8, 129);
            trackBarSim.Name = "trackBarSim";
            trackBarSim.Size = new Size(235, 45);
            trackBarSim.TabIndex = 0;
            trackBarSim.Scroll += trackBarSim_Scroll;
            // 
            // groupBoxSim
            // 
            groupBoxSim.Controls.Add(labelSimFoundSolution);
            groupBoxSim.Controls.Add(textBoxSimFoundSolution);
            groupBoxSim.Controls.Add(textBoxSimStart);
            groupBoxSim.Controls.Add(labelSimStart);
            groupBoxSim.Controls.Add(trackBarSim);
            groupBoxSim.Enabled = false;
            groupBoxSim.Location = new Point(10, 154);
            groupBoxSim.Name = "groupBoxSim";
            groupBoxSim.Size = new Size(250, 180);
            groupBoxSim.TabIndex = 4;
            groupBoxSim.TabStop = false;
            groupBoxSim.Text = "Simulation";
            // 
            // labelSimFoundSolution
            // 
            labelSimFoundSolution.AutoSize = true;
            labelSimFoundSolution.Location = new Point(8, 50);
            labelSimFoundSolution.Name = "labelSimFoundSolution";
            labelSimFoundSolution.Size = new Size(136, 15);
            labelSimFoundSolution.TabIndex = 7;
            labelSimFoundSolution.Text = "Pfad von hier gefunden?";
            // 
            // textBoxSimFoundSolution
            // 
            textBoxSimFoundSolution.Location = new Point(163, 47);
            textBoxSimFoundSolution.Name = "textBoxSimFoundSolution";
            textBoxSimFoundSolution.ReadOnly = true;
            textBoxSimFoundSolution.Size = new Size(80, 23);
            textBoxSimFoundSolution.TabIndex = 99;
            // 
            // textBoxSimStart
            // 
            textBoxSimStart.Location = new Point(163, 16);
            textBoxSimStart.Name = "textBoxSimStart";
            textBoxSimStart.ReadOnly = true;
            textBoxSimStart.Size = new Size(80, 23);
            textBoxSimStart.TabIndex = 99;
            // 
            // labelSimStart
            // 
            labelSimStart.AutoSize = true;
            labelSimStart.Location = new Point(8, 19);
            labelSimStart.Name = "labelSimStart";
            labelSimStart.Size = new Size(90, 15);
            labelSimStart.TabIndex = 5;
            labelSimStart.Text = "Ausgangspunkt";
            // 
            // KnightsTourForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(962, 688);
            Controls.Add(groupBoxSim);
            Controls.Add(groupBoxBoard);
            Controls.Add(groupBoxSettings);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KnightsTourForm";
            Text = "Ü4 Schachbrett Knights Tour";
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSettingBoardSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSettingSquares).EndInit();
            groupBoxBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarSim).EndInit();
            groupBoxSim.ResumeLayout(false);
            groupBoxSim.PerformLayout();
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
        private TrackBar trackBarSim;
        private GroupBox groupBoxSim;
        private Button ButtonBoardReset;
        private Label labelSimStart;
        private TextBox textBoxSimStart;
        private Label labelSimFoundSolution;
        private TextBox textBoxSimFoundSolution;
    }
}
