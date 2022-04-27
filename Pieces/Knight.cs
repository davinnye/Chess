using Boards;

namespace Pieces
{
    internal class Knight : Piece
    {
        public Knight(Board board, Colors color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
