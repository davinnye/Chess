using Boards;

namespace Pieces
{
    internal class Rook : Piece
    {
        public Rook (Board board, Colors color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "R";
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
            while (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
                if (Board.pc(position) != null && Board.pc(position).Colors != this.Colors)
                {
                    break;
                }
                position.row = position.row - 1;
            }
            

            //Down
            position.setValues(Board.Row + 1, Board.Column);
            while (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
                if (Board.pc(position) != null && Board.pc(position).Colors != this.Colors)
                {
                    break;
                }
                position.row = position.row + 1;
            }

            //Left
            position.setValues(Board.Row, Board.Column - 1);
            while (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
                if (Board.pc(position) != null && Board.pc(position).Colors != this.Colors)
                {
                    break;
                }
                position.column = position.column - 1;
            }

            //Right
            position.setValues(Board.Row, Board.Column + 1);
            while (Board.validPosition(position) && canMove(position))
            {
                move[position.row, position.column] = true;
                if (Board.pc(position) != null && Board.pc(position).Colors != this.Colors)
                {
                    break;
                }
                position.column = position.column + 1;
            }
            return move;
        }
    }
}
