using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.BasicMath
{
    public static class ComputerScience
    {
        public static string ConvertToBinary(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string input)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < input.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(input.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static string ConvertToHex(string input)
        {
            char[] converted = input.ToCharArray();

            foreach( char letter in converted)
            {
                int value = Convert.ToInt32(letter);
                string hexOutput = String.Format("{0:X", converted);
            }

            return converted.ToString();
        }
    }
}
