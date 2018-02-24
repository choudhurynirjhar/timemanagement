using System;

namespace TimeManagement.Streaming.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message. Enter q for quiting");
            var message = default(string);
            while((message = Console.ReadLine()) != "q")
            {
                var producer = new BookingProducer();
                producer.Produce(message);
            }
        }
    }
}
