using Boards;

namespace Pieces
{
    internal class King : Piece
    {

        public King(Board board, Colors color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }

        private bool canMove(MatchPosition position)
        {
            Piece piece = Board.pc(position);
            return piece == null || piece.Colors != this.Colors;
        }

        public override bool[,] allowedMovements()
        {
            bool[,] move = new bool[Board.Row, Board.Column];
            MatchPosition position = new MatchPosition(0, 0);

            //Top
            position.setValues(Board.Row - 1, Board.Column);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //NE
            position.setValues(Board.Row - 1, Board.Column + 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //Right
            position.setValues(Board.Row, Board.Column + 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //SE
            position.setValues(Board.Row + 1, Board.Column + 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //Down
            position.setValues(Board.Row + 1, Board.Column);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //SW
            position.setValues(Board.Row + 1, Board.Column - 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //left
            position.setValues(Board.Row, Board.Column - 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            //NW
            position.setValues(Board.Row - 1, Board.Column - 1);
            if (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
            }

            return move;
        }
    }
}
