using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    static class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            string[] words = msg.Split(' ');
            string newWord = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                newWord += words[i];
                if (i > 0)
                    newWord += " ";
            }
            return newWord;
        }


        public static void LogTransmission(string agentName, string message)
        {
            string encryptedMessage = EncryptMessage(message);
            Console.WriteLine($"Agent {agentName} sent a message: {encryptedMessage}");
        }
    }
}
