namespace Oefentoets_Design_Patterns.Encryption
{
    public abstract class Encryption
    {
         public EncryptionBehavior EncryptionBehavior;

        public string PreformEncryption(string toEncrypt)
        {
            return EncryptionBehavior.Encrypt(toEncrypt);
        }
    }
}