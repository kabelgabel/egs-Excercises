using WinFormsUtil;

namespace KnightsTour
{
    public partial class KnightsTourForm : Form
    {
        private readonly ErrorDumper _err;
        private readonly Color _colWhiteOpen = Color.OldLace;
        private readonly Color _colBlackOpen = Color.Tan;

        private int _squaresPerSide;
        private int _boardSize;

        private bool _isSimOngoing;
        private bool _alternatingFlag;

        private Panel? _knightPanel;

        private int[] _starterPos;
        private int[,] _solution;

        public KnightsTourForm()
        {
            InitializeComponent();
            _err = new ErrorDumper();

            _isSimOngoing = false;
            _starterPos = new int[0];
            _solution = new int[0, 0];
        }

        #region Eventhandler

        private void ButtonBoardInit_Click(object sender, EventArgs e)
        {
            if (
                int.TryParse(numericSettingSquares.Text, out int squaresPerSide) &&
                int.TryParse(numericSettingBoardSize.Text, out int boardSize)
                )
            {
                InitializeBoard(squaresPerSide, boardSize);
            }

        }

        private void trackBarSim_Scroll(object sender, EventArgs e)
        {
            UpdateBoard(trackBarSim.Value);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;
            _starterPos = GetCoordsByPanelName(clickedPanel.Name);

            // start simulation
            KnightsTour kt = new KnightsTour(_squaresPerSide);
            _solution = kt.Find(_starterPos[0], _starterPos[1]);
            _isSimOngoing = true;
            UpdateDisplays(_solution.GetLength(0) > 0);
        }

        private void ButtonBoardReset_Click(object sender, EventArgs e)
        {
            _isSimOngoing = false;
            flowLayoutPanelBoard.Controls.Clear();
            UpdateDisplays(false);
        }

        #endregion

        #region Board Display

        private void InitializeBoard(int squaresPerSide, int boardSize)
        {
            _squaresPerSide = squaresPerSide;
            _boardSize = boardSize;
            _knightPanel = null;
            flowLayoutPanelBoard.Size = new Size(_boardSize, _boardSize);
            AddBackPanels();
        }

        private void UpdateDisplays(bool foundSolution)
        {
            numericSettingSquares.Enabled = !_isSimOngoing;
            numericSettingBoardSize.Enabled = !_isSimOngoing;
            ButtonBoardInit.Enabled = !_isSimOngoing;
            ButtonBoardReset.Enabled = _isSimOngoing;
            groupBoxSim.Enabled = _isSimOngoing;
            textBoxSimStart.Text = _isSimOngoing ? _starterPos[0] + "," + _starterPos[1] : "";
            textBoxSimFoundSolution.Text = _isSimOngoing ? foundSolution.ToString() : "";
            if (foundSolution)
            {
                trackBarSim.Enabled = true;
                trackBarSim.Maximum = (_squaresPerSide * _squaresPerSide) - 1;
                trackBarSim.Value = 0;
                // make it scrollable with arrow keys
                trackBarSim.Focus();
                UpdateBoard(0);
            }
            else
            {
                _isSimOngoing = false;
                trackBarSim.Enabled = false;
            }
        }

        private void UpdateBoard(int step)
        {
            for (int c = 0; c < _squaresPerSide; c++)
            {
                for (int r = 0; r < _squaresPerSide; r++)
                {
                    string lookup = c + "_" + r;
                    Panel panel = (Panel)flowLayoutPanelBoard.Controls.Find("panel_" + lookup, true)[0];

                    foreach (Control control in panel.Controls)
                    {
                        if (control is Label label)
                        {
                            label.Text = _solution[c, r].ToString();
                            if (_solution[c, r] == step)
                                UpdateKnightPos(panel);
                        }
                    }
                }
            }
        }

        private void AddBackPanels()
        {
            // reset 
            _alternatingFlag = true;
            flowLayoutPanelBoard.Controls.Clear();

            int panelSize = _boardSize / _squaresPerSide;

            for (int c = 0; c < _squaresPerSide; c++)
            {
                for (int r = 0; r < _squaresPerSide; r++)
                {
                    flowLayoutPanelBoard.Controls.Add(CreatePanel(panelSize, c, r));
                    _alternatingFlag = !_alternatingFlag;
                }
                // make sure square colors alternate through rows correctly
                if (_squaresPerSide % 2 == 0) _alternatingFlag = !_alternatingFlag;
            }
        }

        private Panel CreatePanel(int size, int col, int row)
        {
            Panel panel = new()
            {
                Location = new Point(col * size, row * size),
                // identify by name?
                Name = "panel_" + col + "_" + row,
                Size = new Size(size, size),
                Margin = new Padding(0, 0, 0, 0),
                TabIndex = 0
            };
            // add event handler, I guess there is a better way to do it
            panel.Click += panel_Click;
            if (_alternatingFlag)
            {
                panel.BackColor = _colWhiteOpen;
            }
            else
            {
                panel.BackColor = _colBlackOpen;
            }
            Label label = new()
            {
                Location = new Point(1, 1),
                Name = "label_" + col + "_" + row,
                Text = ""
            };
            label.SendToBack();
            panel.Controls.Add(label);
            return panel;
        }

        private void UpdateKnightPos(Panel targetPanel)
        {
            if (targetPanel.Controls.Count > 0)
            {
                foreach (Control control in targetPanel.Controls)
                {
                    // hide labels for knight icon
                    if (control is Label label)
                        label.Visible = false;
                }
            }
            // reset if there was a knight somewhere already
            if (_knightPanel != null && _knightPanel.Controls.Count > 0)
            {
                foreach (Control control in _knightPanel.Controls)
                {
                    // delete old knight icon
                    if (control is Panel panel)
                        _knightPanel.Controls.Remove(panel);
                    // make labels visible again
                    if (control is Label label)
                        label.Visible = true;
                }
            }

            double scale = .8;
            int scaledSize = (int)(scale * targetPanel.Size.Width);
            int scaledlocation = (int)((targetPanel.Size.Width - scaledSize) / 2);

            Panel newKnight = new()
            {
                Name = "icon",
                Location = new Point(scaledlocation, scaledlocation),
                Size = new Size(scaledSize, scaledSize),
                Margin = new Padding(0, 0, 0, 0),
                TabIndex = 0,
                BackgroundImage = Properties.Resources.icon_knight,
                BackgroundImageLayout = ImageLayout.Zoom,
            };
            newKnight.BringToFront();
            _knightPanel = targetPanel;
            _knightPanel.Controls.Add(newKnight);

        }

        private int[] GetCoordsByPanelName(string s)
        {
            string[] parts = s.Split('_');
            // parts[0] = "panel_"
            int col, row;
            if (int.TryParse(parts[1], out col) && int.TryParse(parts[2], out row))
            {
                return new int[] { col, row };
            }
            return new int[0];
        }

        #endregion

    }
}
