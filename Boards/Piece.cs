namespace Boards
{
    internal class Piece
    {
        public MatchPosition Position { get; set; }
        public Colors Colors { get; protected set; }
        public int AmountOfMovements { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Colors color)
        {
            this.Position = null;
            this.Board = board;
            this.Colors = color;
            this.AmountOfMovements = 0;
        }

        public void increaseAmountOfMovements()
        {
            AmountOfMovements++;
        }
        
    }
}
