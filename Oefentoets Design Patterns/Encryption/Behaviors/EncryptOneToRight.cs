namespace Oefentoets_Design_Patterns.Encryption
{
    public class EncryptOneToRight : EncryptionBehavior
    {
        public string Encrypt(string toEncrypt)
        {
            char[] array = toEncrypt.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                if (char.IsLetter(letter))
                {
                    if (letter == 'z')
                    {
                        letter = 'a';
                    }
                    else if (letter == 'Z')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter = (char) (letter + 1);
                    }
                }
                array[i] = letter;
            }
            string s;
            return s = new string(array);
        }
    }
}