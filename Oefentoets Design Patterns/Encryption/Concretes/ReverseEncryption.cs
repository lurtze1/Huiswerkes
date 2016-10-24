namespace Oefentoets_Design_Patterns.Encryption.Concretes
{
    public class ReverseEncryption : Encryption
    {
        public ReverseEncryption()
        {
            EncryptionBehavior = new EncryptReverse();
        }
    }
}