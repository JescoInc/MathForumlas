namespace Formula.BasicMath
{
    public static class Area
    {

        public static int AreaOfSquare(int side)
        {
            int area = side * side;

            return area;
        }

        public static int AreaOfRectangle(int legnth, int width)
        {
            int area = legnth * width;

            return area;
        }

        public static int AreaOfTriangle(int baselength, int height)
        {
            int area = (baselength * height) / 2;

            return area;
        }

        public static int AreaOfTrapezoid(int base1, int base2, int height)
        {
            int area = (base1 + base2) * height / 2;

            return area;
        }
    }
}
