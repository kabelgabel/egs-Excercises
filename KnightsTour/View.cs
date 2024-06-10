namespace KnightsTour
{
    internal class View
    {
        private readonly FlowLayoutPanel _flpBoard;
        private int _squaresPerSide;
        private int _boardSize;

        private readonly Color _colorWhite;
        private readonly Color _colorBlack;

        private bool _alternatingFlag;
        private Panel? _knightPanel;

        public View (FlowLayoutPanel flpBoard) { 
            _flpBoard = flpBoard;
            _squaresPerSide = 0;
            _boardSize = 0;

            _colorWhite = Color.OldLace;
            _colorBlack = Color.Tan;

            _alternatingFlag = true;
            _knightPanel = null;
        }

        public void UpdateBoardSize(int squaresPerSide, int boardSize)
        {
            _squaresPerSide = squaresPerSide;
            _boardSize = boardSize;
            _flpBoard.Size = new Size(_boardSize, _boardSize);
            AddBackPanels();
        }

        private void AddBackPanels()
        {
            // reset 
            _alternatingFlag = true;
            _flpBoard.Controls.Clear();

            int panelSize = _boardSize / _squaresPerSide;

            for (int c = 0; c < _squaresPerSide; c++)
            {
                for (int r = 0; r < _squaresPerSide; r++)
                {
                    _flpBoard.Controls.Add(CreatePanel(panelSize, c, r));
                    _alternatingFlag = !_alternatingFlag;
                }
                // make sure square colors alternate through rows correctly
                if (_squaresPerSide % 2 == 0) _alternatingFlag = !_alternatingFlag;
            }
        }

        private Panel CreatePanel(int size, int col, int row)
        {
            Panel panel = new Panel();
            panel.Location = new Point(col*size, row*size);
            // identify by name?
            panel.Name = "panel_" + col + "-" + row;
            panel.Size = new Size(size, size);
            panel.Margin = new Padding(0, 0, 0, 0);
            panel.TabIndex = 0;
            panel.Click += panel_Click;
            if (_alternatingFlag)
            {
                panel.BackColor = _colorWhite;
            } else
            {
                panel.BackColor = _colorBlack;
            }
            return panel;
        }

        public void UpdateKnightPos(Panel targetPanel)
        {
            // reset if there was a knight somewhere already
            if (_knightPanel != null && _knightPanel.Controls.Count > 0)
            {
                _knightPanel.Controls.Clear();
            }

            double scale = .8;
            int scaledSize = (int)(scale * targetPanel.Size.Width);
            int scaledlocation = (int)((targetPanel.Size.Width - scaledSize) / 2);

            Panel newKnight = new ()
            {
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


        private void panel_Click(object sender, EventArgs e)
        {
            UpdateKnightPos((Panel)sender);
            // ToDo start simulation
        }

    }
}
