using Producer;
namespace ProducerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string topic = "myTopic";
            string host = "localhost:29092";
            var message = "Started Producer!";
            var flag = true;

            KafkaProducer producer = new KafkaProducer(host);
            _ = producer.PostToKafka(topic, message);

            while (flag)
            {
                message = Console.ReadLine();
                if (message != null && message.Length > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    message = "End of Message Production";
                }
                _ = producer.PostToKafka(topic, message);
            }
        }
    }
}
