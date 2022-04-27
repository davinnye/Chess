using Boards;

namespace Pieces
{
    internal class Pawn : Piece
    {
        public Pawn (Board board, Colors color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
