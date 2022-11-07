namespace H4RandomNums
{
    public class Encrypter
    {

        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZÆØÅ";
        string enalphabet = "KLMNOPQRSTUVXYZÆØÅABCDEFGHIJ";
        public Encrypter()
        {
        }
        public void Encrypt(string text)
        {
            string encrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (Char.ToLower(text[i]) == Char.ToLower(alphabet[j]))
                    {
                        encrypted += enalphabet[j + 1];
                    }
                }
            }
            Console.WriteLine(encrypted);
        }
        public void Decrypt(string text)
        {
            string decrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < enalphabet.Length; j++)
                {
                    if (Char.ToLower(text[i]) == Char.ToLower(enalphabet[j]))
                    {
                        decrypted += alphabet[j -1];
                    }
                }
            }
            Console.WriteLine(decrypted);
        }
    }
}
