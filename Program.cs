namespace Cryptoquip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CryptoQuip game!");


            // Generate a random key
            List<char> alphabet = new List<char> { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> key = Key.GenerateKey(alphabet);


            // Encrypt the message
            string message = "test test test";
            string encryptedMessage = Encrypt.EncryptMessage(message, key);

            Console.WriteLine("Message: " + encryptedMessage);

            // Start the game
            while (true)
            {
                Console.Write("Enter your decoded message: ");
                string decodedMessage = Console.ReadLine();

                if (decodedMessage == message)
                {
                    Console.WriteLine("Congratulations! You decoded the message correctly.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect. Try again.");
                }
            }

            Console.WriteLine("\nThanks for playing!");
        }

        

        
    }
}