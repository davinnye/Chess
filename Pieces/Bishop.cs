using Boards;

namespace Pieces
{
    internal class Bishop : Piece
    {
        public Bishop (Board board, Colors color) : base(board, color)
        {
        }

       

        public override string ToString()
        {
            return "B";
        }
        public override bool[,] allowedMovements()
        {
            throw new NotImplementedException();
        }

    }
}
