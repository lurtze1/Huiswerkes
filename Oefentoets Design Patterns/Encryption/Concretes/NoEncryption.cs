namespace Oefentoets_Design_Patterns.Encryption.Concretes
{
    public class NoEncryption : Encryption
    {
        public NoEncryption()
        {
            EncryptionBehavior = new EncryptNoWay();
        }
    }
}