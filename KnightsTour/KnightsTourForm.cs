namespace KnightsTour
{
    public partial class KnightsTourForm : Form
    {
        private bool _isSimOngoing;
        private View _view;

        public KnightsTourForm()
        {
            InitializeComponent();
            _isSimOngoing = false;
            _view = new(flowLayoutPanelBoard);
        }

        private void ButtonBoardInit_Click(object sender, EventArgs e)
        {
            if (
                int.TryParse(numericSettingSquares.Text, out int squaresPerSide) &&
                int.TryParse(numericSettingBoardSize.Text, out int boardSize)
                )
            {
                _view.UpdateBoardSize(squaresPerSide, boardSize);
            }

        }
    }
}
