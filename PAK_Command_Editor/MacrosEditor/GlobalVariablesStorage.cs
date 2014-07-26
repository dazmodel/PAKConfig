using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.MacrosEditor
{
    public static class GlobalVariablesStorage
    {
        private static Int16 _startNumber = 256;

        private static List<GlobalVariable> _globalVars;
        public static List<GlobalVariable> GlobalVars
        {
            get 
            {
                if (_globalVars == null)
                    _globalVars = GetGlobalVariables();

                return _globalVars;
            }
        }         

        public static void AddByName(String name)
        {
            Int16 index = GlobalVars.Count == 0 ? _startNumber : GlobalVars.Max(x => x.HexCode);
            GlobalVars.Add(new GlobalVariable() { Alias = name, Value = false, HexCode = (Int16)(index + 1), CanReceiveSignals = false });
        }

        public static GlobalVariable GetByName(String name)
        {
            return GlobalVars.Where(x => x.Alias == name).SingleOrDefault();
        }

        #region Utilities

        private static String StringFromHex(uint value)
        {
            return value.ToString("X");
        }

        private static uint HexFromString(String value)
        {
            return uint.Parse(value, System.Globalization.NumberStyles.HexNumber);
        }

        private static List<GlobalVariable> GetGlobalVariables()
        {
            List<GlobalVariable> gvList;

            using (Repository<GlobalVariable> gvRepo = new Repository<GlobalVariable>(PAKDataSessionFactory.GetSession()))
            {
                gvList = gvRepo.GetAll().ToList();
            }

            return gvList;
        }

        #endregion
    }
}
