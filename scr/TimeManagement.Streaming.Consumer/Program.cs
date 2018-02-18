using System;

namespace TimeManagement.Streaming.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookingConsumer = new BookingConsumer();
            bookingConsumer.Listen(Console.WriteLine);
        }
    }
}
