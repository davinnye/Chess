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
    }
}
