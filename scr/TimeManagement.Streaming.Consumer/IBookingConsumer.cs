using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Streaming.Consumer
{
    public interface IBookingConsumer
    {
        void Listen(Action<string> message);
    }
}
