using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TimeManagement.Streaming.Consumer;

namespace TimeManagement.Service
{
    public class BookingMessageRelay
    {
        public BookingMessageRelay(IHubContext<BookingHub> hubContext, IBookingStream bookingStream)
        {
            bookingStream.Subscribe("Hub_Client", (m) => hubContext.Clients.All.InvokeAsync("booking", m.Message));
        }
    }
}
