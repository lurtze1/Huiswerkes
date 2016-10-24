namespace Oefentoets_Design_Patterns.Encryption.Concretes
{
    public class ShiftEncryption : Encryption
    {
        public ShiftEncryption()
        {
            EncryptionBehavior = new EncryptOneToRight();
        }
    }
}