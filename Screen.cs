using Boards;

namespace Chess
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.Row; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Screen.printPiece(board.piece(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printPiece(Piece piece)
        {
            if (piece.Colors == Colors.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

        public static MatchPosition readMatchPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1]+ "");
            return new MatchPosition(column, row);
        }
    }
}
