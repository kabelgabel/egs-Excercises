namespace KnightsTour
{
    public class KnightsTour
    {
        private static readonly int[,] _possibleMoves = new int[,] {
            { 2, 1 }, { 2, -1 }, { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 }, { -2, 1 }, { -2, -1 }
        };

        private int[,] _solution;
        private readonly int _boardSize;

        public KnightsTour(int boardSize)
        {
            _boardSize = boardSize;
            // init solution board
            _solution = new int[_boardSize, _boardSize];
            for (int col = 0; col < _boardSize; col++)
                for (int row = 0; row < _boardSize; row++)
                    _solution[col, row] = -1;

        }

        public int[,] Find(int knightPosCol, int knightPosRow)
        {
            // set starting coordinate
            _solution[knightPosCol, knightPosRow] = 0;

            if (SolveTour(knightPosCol, knightPosRow, 1))
            {
                // found a route
                return _solution;
            }
            return new int[0, 0];
        }

        private bool SolveTour(int startCol, int startRow, int moveCounter)
        {
            if (moveCounter == _boardSize * _boardSize)
                return true;

            // init Warnsdorf rule 
            int minDegIndex = -1, minDeg = int.MaxValue;
            int[] nextPositions;

            // iterates over all possible moves from current square
            // to determine the one with the lowest degree
            for (int moveIndex = 0; moveIndex < _possibleMoves.GetLength(0); moveIndex++)
            {
                nextPositions = GetNextPositions(startCol, startRow, moveIndex);
                int deg = GetDegree(nextPositions[0], nextPositions[1]);

                if (IsValidMove(nextPositions[0], nextPositions[1]) && deg < minDeg)
                {
                    minDegIndex = moveIndex;
                    minDeg = deg;
                }
            }

            if (minDegIndex == -1)
                return false;
            // found a valid square to move to

            nextPositions = GetNextPositions(startCol, startRow, minDegIndex);
            _solution[nextPositions[0], nextPositions[1]] = moveCounter;

            // advance deeper
            if (SolveTour(nextPositions[0], nextPositions[1], moveCounter + 1))
                return true;

            // backtracking step
            _solution[nextPositions[0], nextPositions[1]] = -1;
            return false;
        }

        /// <summary>
        ///  Helper function to calculate the degree of a given square.
        ///  Basically the heart of Warnsdorf's algorithm, which chooses the next move based on the
        ///  square with the fewest onward moves, aiming to reduce the chances of getting stuck
        /// </summary>
        /// <returns>
        ///  The amount of valid moves a knight can make from given square
        /// </returns>
        private int GetDegree(int col, int row)
        {
            int count = 0;
            for (int moveIndex = 0; moveIndex < _possibleMoves.GetLength(0); moveIndex++)
            {
                int[] nextPositions = GetNextPositions(col, row, moveIndex);
                if (IsValidMove(nextPositions[0], nextPositions[1]))
                    count++;
            }
            return count;
        }

        private int[] GetNextPositions(int col, int row, int moveIndex)
        {
            return new int[]
            {
                col + _possibleMoves[moveIndex, 0],
                row + _possibleMoves[moveIndex, 1]
            };
        }

        private bool IsValidMove(int col, int row)
        {
            if ((col >= 0) && (col < _boardSize) && (row >= 0) && (row < _boardSize))
            {
                if (_solution[col, row] == -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
