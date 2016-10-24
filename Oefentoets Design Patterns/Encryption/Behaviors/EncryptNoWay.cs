namespace Oefentoets_Design_Patterns.Encryption
{
    public class EncryptNoWay : EncryptionBehavior
    {
        public string Encrypt(string toEncrypt)
        {
            return toEncrypt;
        }
    }
}