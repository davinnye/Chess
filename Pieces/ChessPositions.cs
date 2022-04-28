using Boards;

namespace Pieces
{
    internal class ChessPositions
    {
        public char Column { get; set; }
        public int Row { get; set; }

        public ChessPositions(char column, int row)
        {
            Column = column;
            Row = row;
        }
        public MatchPosition toChessPosition()
        {
            return new MatchPosition((Column - 'a'), 8 - Row);
        }
        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}
