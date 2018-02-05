using Moq;
using System;
using TimeManagement.Booking;
using TimeManagement.Data;
using Xunit;

namespace TimeManagement.UnitTest
{
    public class TimeBookingProcessorUnitTest
    {
        [Fact]
        public void Test_Invalid_EmployeeId()
        {
            var bookingProcessor = new Mock<IBookingProcessor>();
            var timeBookingProcessor = new TimeBookingProcessor(bookingProcessor.Object);

            Assert.Throws<ArgumentOutOfRangeException>(() => timeBookingProcessor.BookTime(new Data.Employee(), DateTime.Today, 8));
        }

        [Fact]
        public void Test_Invalid_Date()
        {
            var bookingProcessor = new Mock<IBookingProcessor>();
            var timeBookingProcessor = new TimeBookingProcessor(bookingProcessor.Object);

            Assert.Throws<ArgumentOutOfRangeException>(() => timeBookingProcessor.BookTime(new Data.Employee {Id=2 }, DateTime.Today.AddDays(1), 8));
        }

        [Fact]
        public void Test_Invalid_Duration()
        {
            var bookingProcessor = new Mock<IBookingProcessor>();
            var timeBookingProcessor = new TimeBookingProcessor(bookingProcessor.Object);

            Assert.Throws<ArgumentOutOfRangeException>(() => timeBookingProcessor.BookTime(new Data.Employee { Id = 2 }, DateTime.Today, 10));
        }

        [Fact]
        public void Test_Valid_Arguments()
        {
            var bookingProcessor = new Mock<IBookingProcessor>();
            bookingProcessor.Setup(p => p.Create(It.IsAny<int>(), It.IsAny<DateTime>(), It.IsAny<decimal>())).Returns(true);

            var timeBookingProcessor = new TimeBookingProcessor(bookingProcessor.Object);

            Assert.True(timeBookingProcessor.BookTime(new Data.Employee { Id = 2 }, DateTime.Today, 9));
        }
    }
}
