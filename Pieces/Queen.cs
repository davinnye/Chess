using Boards;

namespace Pieces
{
    internal class Queen : Piece
    {
        public Queen (Board board, Colors color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "Q";
        }

        public override bool[,] allowedMovements()
        {
            throw new NotImplementedException();
        }
    }
}
