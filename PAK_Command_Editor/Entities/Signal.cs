using System;
using System.Security.Cryptography;
using System.Text;

namespace PAK_Command_Editor.Entities
{
    public class Signal
    {
        public virtual Int32 Id { get; set; }
        public virtual String HexCodeHash { get; set; }
        public virtual String Name { get; set; }
        public virtual String HexCode { get; set; }
        public virtual Device Device { get; set; }

        public virtual String ComputeMD5Hash(String hexCode)
        {
            String hashStrig = String.Empty;

            using (MD5 md5Counter = MD5.Create())
            {
                hashStrig = Convert.ToBase64String(md5Counter.ComputeHash(Encoding.UTF8.GetBytes(hexCode)));
            }

            return hashStrig;
        }
    }
}
