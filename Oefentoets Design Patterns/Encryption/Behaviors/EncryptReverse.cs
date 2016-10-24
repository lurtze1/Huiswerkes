using System;

namespace Oefentoets_Design_Patterns.Encryption
{
    public class EncryptReverse : EncryptionBehavior
    {
        public string Encrypt(string toEncrypt)
        {
            char[] charArray = toEncrypt.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}