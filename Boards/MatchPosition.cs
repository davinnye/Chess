using Boards;
using Pieces;

namespace Boards
{
    class MatchPosition
    {
        public int row { get; set; }
        public int column { get; set; }

        public MatchPosition(int column, int row)
        {
            this.row = row;
            this.column = column;
        }
        public MatchPosition toChessPosition()
        {
            return new MatchPosition((column - 'a'), 8 - row);
        }

        public void setValues(int column, int row)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return $"{column}, {row}";
        }
    }
}
