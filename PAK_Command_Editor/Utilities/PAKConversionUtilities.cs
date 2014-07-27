using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.Utilities
{
    public static class PAKConversionUtilities
    {
        #region To Byte Array Utils

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

        public static byte[] StringToByteArray(String signalString)
        {
            List<String> strBytes = signalString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            return strBytes.Select(x => Convert.ToByte(x.Substring(2, 2), 16)).ToArray();
        }

        public static byte[] WordsStringToByteArray(String wordsString)
        {
            List<String> strBytes = wordsString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            List<byte> bytes = new List<byte>();

            foreach (String s in strBytes)
            {
                bytes.Add(Convert.ToByte(s.Substring(0, 2), 16));
                bytes.Add(Convert.ToByte(s.Substring(2, 2), 16));
            }

            return bytes.ToArray();
        }

        public static byte[] StringToASCIIByteCodesArray(String value)
        {            
            return Encoding.ASCII.GetBytes(value);
        }

        #endregion

        #region From Byte Array Utils

        public static Int16 ByteArrayToInt16(byte[] byteArray)
        {
            return ByteArrayToInt16(byteArray, 0);
        }

        public static Int16 ByteArrayToInt16(byte[] byteArray, Int32 startIndex)
        {
            return BitConverter.ToInt16(byteArray, startIndex);
        }

        public static Int32 ByteArrayToInt32(byte[] byteArray, Int32 startIndex)
        {
            return BitConverter.ToInt32(byteArray, startIndex);
        }

        public static String ByteArrayToSignalWordsString(byte[] byteArray)
        {
            return ByteArrayToSignalWordsString(byteArray, 0, byteArray.Length - 2);
        }

        public static String ByteArrayToSignalWordsString(byte[] byteArray, Int32 startIndex, Int32 length)
        {            
            StringBuilder wordSb = new StringBuilder();

            for (Int32 i = startIndex; i < length; i++)
            {
                if ((i > 0) && (i % 2 == 0) && (i != byteArray.Length - 1))
                {
                    wordSb.Append(" ");
                }
                wordSb.Append(byteArray[i].ToString("X2"));
            }

            return wordSb.ToString();
        }

        public static String ASCIIByteArrayToString(byte[] byteArray, Int32 startIndex, Int32 count)
        {
            return Encoding.ASCII.GetString(byteArray, startIndex, count);
        }

        #endregion

        public static Int16 StringToInt16(String hex)
        {
            return ByteArrayToInt16(StringToByteArray(hex));
        }
    }
}
