namespace WannaPlayChess.Common.Console
{
    using System;

    public static class ConosoleHelpers
    {
        public static void SetCursorAtCenter(int lengthOfMessage)
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - lengthOfMessage / 2;
            Console.SetCursorPosition(centerCol, centerRow);
        }
    }
}
