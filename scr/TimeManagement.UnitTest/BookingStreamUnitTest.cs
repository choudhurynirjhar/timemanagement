using System;
using System.Collections.Generic;
using System.Text;
using TimeManagement.Streaming.Consumer;
using Xunit;

namespace TimeManagement.UnitTest
{
    public class BookingStreamUnitTest
    {
        [Fact]
        public void Test_Valid_Message()
        {
            var bookingStream = new BookingStream();

            var bookingMessage = default(BookingMessage);

            bookingStream.Subscribe("Test_Subscriber_1", (m) => bookingMessage = m );

            bookingStream.Publish(new BookingMessage { Message = "Test_Message" });

            Assert.Equal("Test_Message", bookingMessage.Message);
        }

        [Fact]
        public void Test_Empty_Message()
        {
            var bookingStream = new BookingStream();

            var bookingMessage = default(BookingMessage);

            bookingStream.Subscribe("Test_Subscriber_2", (m) => bookingMessage = m);

            bookingStream.Publish(new BookingMessage { Message = "" });

            Assert.Null(bookingMessage);

        }
    }
}
