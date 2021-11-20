using Consumer;

namespace ConsumerConsole
{
    class Program
    {
        private static readonly string topic = "myTopic";

        private static readonly string groupId = "consumerGroup";

        private static readonly string host = "localhost:29092";
        static void Main(string[] args)
        {
            Console.WriteLine("Started Consumer!");
            KafkaConsumer consumer = new KafkaConsumer(host, groupId);
            consumer.Consume(topic);
        }
    }
}
