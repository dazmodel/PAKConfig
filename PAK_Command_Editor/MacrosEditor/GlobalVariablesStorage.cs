using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.MacrosEditor
{
    public static class GlobalVariablesStorage
    {
        private static uint _startNumber = 256;

        private static List<GlobalVariable> _globalVars;
        public static List<GlobalVariable> GlobalVars
        {
            get 
            {
                if (_globalVars == null)
                    _globalVars = new List<GlobalVariable>();

                return _globalVars;
            }
        }         

        public static void AddByName(String name, Boolean value)
        {
            uint index = GlobalVars.Count == 0 ? _startNumber : GlobalVars.Max(x => HexFromString(x.HexCode));
            GlobalVars.Add(new GlobalVariable() { Alias = name, Value = value, HexCode = StringFromHex(index) });
        }

        public static GlobalVariable GetByName(String name)
        {
            return GlobalVars.Where(x => x.Alias == name).SingleOrDefault();
        }

        private static String StringFromHex(uint value)
        {
            return value.ToString("X");
        }

        private static uint HexFromString(String value)
        {
            return uint.Parse(value, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
