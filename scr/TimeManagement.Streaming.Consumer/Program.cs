using System;

namespace TimeManagement.Streaming.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookingStream = new BookingStream();
            var bookingConsumer = new BookingConsumer(bookingStream, Console.WriteLine);

            bookingStream.Subscribe("Subscriber1", (m) => Console.WriteLine($"Subscriber1 Message : {m.Message}"));
            bookingStream.Subscribe("Subscriber2", (m) => Console.WriteLine($"Subscriber2 Message Formatted : {m.Message.Substring(0, 2)}"));

            bookingConsumer.Listen();
        }
    }
}
