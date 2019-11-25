using System;

namespace PolygonNameSpace
{
    public class Polygon
    {
        #region Properties
        public int NumberParties { get; set; }
        #endregion

        #region Methods
        public double LengthPolygon(double radiusCirle)
        {
            return 2 * radiusCirle * Math.Tan(Math.PI / NumberParties);
        }
        #endregion
    }
}
