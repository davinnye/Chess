namespace Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Colors Colors { get; protected set; }
        public int AmountOfMovements { get; protected set; }
        public Board Board { get; protected set; }

        public Piece (Position position, Board board, Colors color)
        {
            this.Position = position;
            this.Board = board;
            this.Colors = color;
            this.AmountOfMovements = 0;
        }
    }
}
