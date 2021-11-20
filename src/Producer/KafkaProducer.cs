using Confluent.Kafka;
namespace Producer
{
    public class KafkaProducer
    {
        private readonly ProducerConfig? _config;
        public KafkaProducer(string host)
        {
            _config = new ProducerConfig { BootstrapServers = host };
        }
        public Object PostToKafka(string topic, string message)
        {
            using (var producer = new ProducerBuilder<Null, string>(_config).Build())
            {
                try
                {
                    return producer.ProduceAsync(topic, new Message<Null, string> { Value = message })
                        .GetAwaiter()
                        .GetResult();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception thrown: {e}!");
                }
            }
            return null;
        }
    }
}