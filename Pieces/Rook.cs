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
    }
}
