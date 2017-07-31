using System;

namespace EncryptionDecryptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = string.Empty;
            int key;
            string encryptedForm = string.Empty;
            string decryptedFrom = string.Empty;
            Console.WriteLine("Enter Data To Encrypt");
            data = Console.ReadLine();
            Console.WriteLine("Enter Encryption Key");
            key = Convert.ToInt32(Console.ReadLine());
            foreach (char character in data.ToCharArray())
            {
                encryptedForm += Convert.ToChar(Convert.ToInt32(character + key));
                encryptedForm += ' ';
            }
            Console.WriteLine($"Encrypted Form {encryptedForm}");
            foreach (string character in encryptedForm.ToString().Split(' '))
            {
                if (character != "")
                {
                    decryptedFrom += Convert.ToChar(Convert.ToInt32(Convert.ToChar(character)) - key);
                }
            }
            Console.WriteLine($"Decrypted Form {decryptedFrom}");
            Console.ReadKey();
        }
    }
}