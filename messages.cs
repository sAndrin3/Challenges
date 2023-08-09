using System;

namespace Messages
{
    public static class MessageProcessor
    {
        public static void ProcessMessages()
        {
            // Sample data
            string[] messages = {
                "Hello!",
                "How are you?",
                "Good morning!",
                "Nice weather today."
            };

            string[] senders = {
                "Alice",
                "Bob",
                "Alice",
                "Eve"
            };

            // Process and display the messages with senders
            for (int i = 0; i < messages.Length; i++)
            {
                string sender = senders[i];
                string message = messages[i];

                Console.WriteLine($"{sender}: {message}");
            }
        }
    }
}
