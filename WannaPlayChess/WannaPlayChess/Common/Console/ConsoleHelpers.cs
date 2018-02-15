namespace WannaPlayChess.Common.Console
{
    using System;
    using WannaPlayChess.Figures.Contracts;

    public static class ConsoleHelpers
    {
        public static ConsoleColor ToConosleColor(this ChessColor chessColor)
        {
            switch (chessColor)
            {
                case ChessColor.Black:
                    {
                        return ConsoleColor.Black;
                    }
                case ChessColor.White:
                    {
                        return ConsoleColor.White;
                    }
                default:
                    throw new InvalidOperationException("Invalid Chess Color!");
            }
        }

        public static void SetCursorAtCenter(int lengthOfMessage)
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - lengthOfMessage / 2;
            Console.SetCursorPosition(centerCol, centerRow);
        }

        public static void PrintChessFigure(IFigure figure, ConsoleColor backgroundColor, ConsoleColor figureColor)
        {
            if (figure == null)
            {
                PrintEmptySquare(backgroundColor);
            }
        }

        public static void PrintEmptySquare(ConsoleColor backgroundColor)
        {
            for (int i = 0; i < CharactersPerBoardSquare; i++)
            {

                for (int j = 0; j < CharactersPerBoardSquare; j++)
                {
                    Console.SetCursorPosition(currentColPrint + j, currentRowPrint + i);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
