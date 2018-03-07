namespace WannaPlayChess.Common.Console
{
    using System;
    using System.Collections.Generic;
    using WannaPlayChess.Figures;
    using WannaPlayChess.Figures.Contracts;

    public static class ConsoleHelpers
    {

        private static IDictionary<string, int[,]> patterns = new Dictionary<string, int[,]>
        {
            {
                "Pawn", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,1,0,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,0,0,1,0,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            },
            {
                "Rook", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,1,0,1,0,1,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,1,1,0,1,1,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            },
            {
                "Knight", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,1,1,1,0,0,1,1,0 },
                {0,0,1,1,1,0,0,0,0 },
                {0,0,1,1,1,1,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            },
             {
                "Bishop", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,1,0,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,0,1,1,0,0 },
                {0,0,1,0,1,0,1,0,0 },
                {0,0,1,1,0,1,1,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            },
             {
                "Queen", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,1,0,0,0,1,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,1,0,1,1,1,0,1,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,1,1,1,1,1,1,1,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            },
             {
                "King", new int[,] {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,1,0,1,0,1,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,1,0,0,0,0 },
                {0,1,0,1,1,1,0,1,0 },
                {0,1,1,1,1,1,1,1,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 }
                }
            }
        };

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

        public static void PrintChessFigure(IFigure figure, ConsoleColor backgroundColor, int top, int left)
        {
            if (figure == null)
            {
                PrintEmptySquare(backgroundColor, top, left);
                return;
            }



            var figurePattern = patterns[figure.GetType().Name];

            for (int i = 0; i < figurePattern.GetLength(0); i++)
            {
                for (int j = 0; j < figurePattern.GetLength(1); j++)
                {
                    Console.SetCursorPosition(left + j, top + i);
                    if (figurePattern[i, j] == 1)
                    {
                        Console.BackgroundColor = figure.Color.ToConosleColor();
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundColor;
                    }

                    Console.Write(" ");
                }
            }

        }

        public static void PrintEmptySquare(ConsoleColor backgroundColor, int top, int left)
        {
            for (int i = 0; i < ConsoleConstants.CharactersPerBoardSquare; i++)
            {
                for (int j = 0; j < ConsoleConstants.CharactersPerBoardSquare; j++)
                {
                    Console.SetCursorPosition(left + j, top + i);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
