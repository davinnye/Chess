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

        public Piece pc(MatchPosition position)
        {
            return Pieces[position.row, position.column];
        }

        public void placePiece(Piece piece, MatchPosition position)
        {
            if (existingPiece(position))
            {
                throw new BoardException("There is a piece set for this position already!");
            }

            Pieces [position.row, position.column] = piece;
            piece.Position = position;
        }

        public Piece takePieceAway(MatchPosition matchPosition)
        {
            if (pc(matchPosition) == null)
            {
                return null;
            }

            Piece aux = pc(matchPosition);
            aux.Position = null;
            Pieces[matchPosition.row, matchPosition.column] = null;
            return aux;
        }

        public bool existingPiece (MatchPosition position)
        {
            validatePosition(position);
            return pc(position) != null;
        }

        public bool validPosition(MatchPosition position)
        {
            if (position.row < 0 || position.row >= Row || position.column < 0 || position.column >= Column)
            {
                return false;
            }
            return true;
        }

        public void validatePosition (MatchPosition position)
        {
            if (!validPosition(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
