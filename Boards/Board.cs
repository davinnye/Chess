namespace Boards
{
    internal class Board
    {
        public int Row { get; set; }
        public int Column { get; set; }
        private Piece[,] Pieces;

        public Board(int row, int column)
        {
            Row = row;
            Column = column;
            Pieces = new Piece[row, column];
        }
        public Piece piece(int row, int column)
        {
            return Pieces[row, column];
        }
    }
}
