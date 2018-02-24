using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Streaming.Producer
{
    public interface IBookingProducer
    {
        void Produce(string message);
    }
}
