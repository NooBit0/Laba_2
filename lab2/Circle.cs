using System;
using PointsNameSpace;
using PolygonNameSpace;

namespace CircleNameSpace
{
    public class Circle
    {
        #region Fields
        private readonly Points _point;
        private readonly Polygon _polygon;
        #endregion

        #region Constructor
        public Circle(int numberParties, int circleCenterX, int circleCenterY, double radius)
        {
            //testing comment
            _point = new Points(circleCenterX, circleCenterY);
            _polygon = new Polygon();
            Radius = radius;
            _polygon.NumberParties = numberParties;
        }

        public Circle()
        {
            _point = new Points(0, 0);
            _polygon = new Polygon();
            Radius = 9;
            _polygon.NumberParties = 7;
        }
        #endregion

        #region Properties
        public double AreaCircle => Math.PI * Math.Pow(Radius, 2);

        public double Radius { get; set; }
        #endregion

        #region Methods
        public static bool Check(Circle firstCircle, Circle secondCircle)
        {
            if (secondCircle._point.X > 0 && firstCircle._point.X > 0)
            {
                if (secondCircle._point.Y > 0 && firstCircle._point.Y > 0)
                {
                    return true;
                }
                else if (secondCircle._point.Y < 0 && firstCircle._point.Y < 0)
                {
                    return true;
                }
                else if (secondCircle._point.Y == 0 && firstCircle._point.Y == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (secondCircle._point.X < 0 && firstCircle._point.X < 0)
                {
                    if (secondCircle._point.Y > 0 && firstCircle._point.Y > 0)
                    {
                        return true;
                    }
                    else if (secondCircle._point.Y < 0 && firstCircle._point.Y < 0)
                    {
                        return true;
                    }
                    else if (secondCircle._point.Y == 0 && firstCircle._point.Y == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (secondCircle._point.X == 0 && firstCircle._point.X == 0)
                {
                    if (secondCircle._point.Y > 0 && firstCircle._point.Y >= 0)
                    {
                        return true;
                    }
                    else if (secondCircle._point.Y < 0 && firstCircle._point.Y < 0)
                    {
                        return true;
                    }
                    else if (secondCircle._point.Y == 0 && firstCircle._point.Y == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            return $"|({_point.X};{_point.Y})|\t|{Radius}|\t|{AreaCircle:F3}|\t|{_polygon.LengthPolygon(Radius)}";
        }

        public void AxisShift(int x) => _point.X += x;
        #endregion
    }
}
