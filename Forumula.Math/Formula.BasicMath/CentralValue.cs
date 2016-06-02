namespace Formula.BasicMath
{
    public static class CentralValue
    {
        public static int MeanOfTwo(int a, int b)
        {
            int mean = (a + b) / 2;
            return mean;
        }

        public static int MeanOfThree(int a, int b, int c)
        {
            int mean = (a + b + c) / 3;

            return mean;
        }

        public static int MeanOfFour(int a, int b, int c, int d)
        {
            int mean = (a + b + c + d) / 4;

            return mean;
        }

        public static int MeanOfFive(int a, int b, int c, int d, int e)
        {
            int mean = (a + b + c + d + e) / 5;

            return mean;
        }
    }
}
