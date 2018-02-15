namespace WannaPlayChess.Common
{
    public struct Position
    {
        public static Position FromArrCordinates(int row, int col, int totalRows)
        {
            return new Position(totalRows - row, (char)(col + 'a'));
        }
        public Position(int row, char col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; private set; }

        public char Col { get; private set; }
    }
}
