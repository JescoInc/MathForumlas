using System;

namespace Formula.BasicMath
{
    public static class Volume
    {

        public static int VolumeOfCube(int side)
        {
            int volume = side * side * side * side;

            return volume;
        }

        public static int VolumeOfBox(int length, int width, int height)
        {
            int volume = length * width * height;

            return volume;
        }

        public static int VolumeOfSphere(int radius)
        {
            double pie = 3.14;

            int volume = (4 / 3) * Convert.ToInt32(pie) * (radius * radius * radius);

            return volume;
        }

        public static int VolumeOfCylinder(int raidus, int height)
        {
            double pie = 3.14;

            int volume = Convert.ToInt32(pie) * (raidus * raidus) * height;

            return volume;
        }
    }
}
