using Boards;
using Pieces;

namespace Chess
{
    internal class ChessMatch
    {
        public Board Board { get; private set; }
        private int turn;
        private Colors PlayerTurn;
        public bool ended { get; private set; }

       
        public ChessMatch()
        {
            Board = new Board(8, 8);
            turn = 1;
            PlayerTurn = Colors.White;
            setPieces();
            ended = false;
        }

        public void performMovement (MatchPosition origin, MatchPosition destiny)
        {
            Piece piece = Board.takePieceAway(origin);
            piece.increaseAmountOfMovements();
            Piece capturedPiece = Board.takePieceAway(destiny);
            Board.placePiece(piece, destiny);
        }

        private void setPieces()
        {
            for (int i = 1; i <= 8; i++)
            {
                Board.placePiece(new Pawn(Board, Colors.Black), new MatchPosition(('i' - i), 7).toChessPosition());
            }
            Board.placePiece(new Rook(Board, Colors.Black), new MatchPosition('a', 8).toChessPosition());
            Board.placePiece(new Rook(Board, Colors.Black), new MatchPosition('h', 8).toChessPosition());
            Board.placePiece(new Bishop(Board, Colors.Black), new MatchPosition('c', 8).toChessPosition());
            Board.placePiece(new Bishop(Board, Colors.Black), new MatchPosition('f', 8).toChessPosition()); 
            Board.placePiece(new Knight(Board, Colors.Black), new MatchPosition('b', 8).toChessPosition());
            Board.placePiece(new Knight(Board, Colors.Black), new MatchPosition('g', 8).toChessPosition());
            Board.placePiece(new Queen(Board, Colors.Black), new MatchPosition('d', 8).toChessPosition());
            Board.placePiece(new King(Board, Colors.Black), new MatchPosition('e', 8).toChessPosition());

            
            Board.placePiece(new Rook(Board, Colors.White), new MatchPosition('a', 1).toChessPosition());
            Board.placePiece(new Rook(Board, Colors.White), new MatchPosition('h', 1).toChessPosition());
            Board.placePiece(new Bishop(Board, Colors.White), new MatchPosition('c', 1).toChessPosition());
            Board.placePiece(new Bishop(Board, Colors.White), new MatchPosition('f', 1).toChessPosition());
            Board.placePiece(new Knight(Board, Colors.White), new MatchPosition('b', 1).toChessPosition());
            Board.placePiece(new Knight(Board, Colors.White), new MatchPosition('g', 1).toChessPosition());
            Board.placePiece(new Queen(Board, Colors.White), new MatchPosition('d', 1).toChessPosition());
            Board.placePiece(new King(Board, Colors.White), new MatchPosition('e', 1).toChessPosition());
        }

    }
}
