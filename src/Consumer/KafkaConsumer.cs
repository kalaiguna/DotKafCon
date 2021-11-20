using Confluent.Kafka;

namespace Consumer
{
    public class KafkaConsumer
    {
        private readonly ConsumerConfig? conf;
        public KafkaConsumer(string host, string groupid)
        {
            conf = new ConsumerConfig
            {
                GroupId = groupid,
                BootstrapServers = host,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
        }
        public void Consume(string topic)
        {
            using (var builder = new ConsumerBuilder<Ignore, string>(conf).Build())
            {
                builder.Subscribe(topic);
                var cancelToken = new CancellationTokenSource();
                try
                {
                    while (true)
                    {
                        var consumer = builder.Consume(cancelToken.Token);
                        Console.WriteLine($"Message: {consumer.Message.Value} received from {consumer.TopicPartitionOffset}");
                    }
                }
                catch (Exception)
                {
                    builder.Close();
                }
            }
        }
    }
}
