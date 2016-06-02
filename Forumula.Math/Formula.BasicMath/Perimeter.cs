namespace Formula.BasicMath
{
    public static class Perimeter
    {

        public static int PerimeterOfSquare(int side)
        {
            int sides = side * side * side * side;

            return sides;
        }

        public static int PerimeterOfRectangle(int length, int width)
        {
            int perimeter = length + length + width + width;

            return perimeter;
        }

        public static int PerimeterOfTriangle(int lengthA, int lengthB, int lengthC)
        {
            int perimeter = lengthA + lengthB + lengthC;

            return perimeter;
        }
    }
}
