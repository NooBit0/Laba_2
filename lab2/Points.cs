namespace PointsNameSpace
{
    public class Points
    {
        #region Constructor
        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Properties
        public int X { get; set; }

        public int Y { get; set; }
        #endregion
    }
}
