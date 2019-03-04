using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingPortal.Encryption256AES
{
    public class KeyGenerator
    {
        public static string GetUniqueKey(int maxSize = 15)
        {
            try
            {
                char[] chars = new char[62];
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[1];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetNonZeroBytes(data);
                    data = new byte[maxSize];
                    crypto.GetNonZeroBytes(data);
                }
                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Pass parameter
        //Match objMatch
        public static string GenerateToken()
        {
            var IssuedOn = DateTime.Now;
            try
            {
                string randomnumber =
                   string.Join(":", new string[]
                   {
                     //Convert.ToString(objMatch.Id),
                     //GetUniqueKey(),
                     //Convert.ToString(objMatch.MatchId),
                     //Convert.ToString(IssuedOn.Ticks)
                   });
                return EncryptionLibrary.EncryptText(randomnumber);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
