using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace TimeManagement.Streaming.Producer
{
    public class BookingProducer : IBookingProducer
    {
        public void Produce(string message)
        {
            var config = new Dictionary<string, object> {
                {"bootstrap.servers", "localhost:9092"}
            };

            using (var producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8)))
            {
                producer.ProduceAsync("timemanagement_booking", null, message).GetAwaiter().GetResult();
                producer.Flush(100);
            }
        }
    }
}
