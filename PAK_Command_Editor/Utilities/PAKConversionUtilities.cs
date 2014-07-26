using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.Utilities
{
    public static class PAKConversionUtilities
    {
        public static byte[] Int16ToByteArray(Int16 intValue)
        {
            byte[] intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                System.Array.Reverse(intBytes);
            return intBytes;
        }

        public static byte[] Int32ToByteArray(Int32 intValue)
        {
            byte[] intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                System.Array.Reverse(intBytes);
            return intBytes;
        }

        public static Int16 ByteArrayToInt16(byte[] byteArray)
        {
            return BitConverter.ToInt16(byteArray, 0);
        }

        public static byte[] StringToByteArray(String hex)
        {
            List<String> strBytes = hex.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            return strBytes.Select(x => Convert.ToByte(x.Substring(2, 2), 16)).ToArray();
        }

        public static byte[] StringToASCIIByteCodesArray(String value)
        {
            return Encoding.ASCII.GetBytes(value);
        }

        public static Int16 StringToInt16(String hex)
        {
            return ByteArrayToInt16(StringToByteArray(hex));
        }
    }
}
