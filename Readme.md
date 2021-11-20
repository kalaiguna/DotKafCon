# DotKafka
---
### A simple dotnet core app to demonstrate a Kafka producer and consumer consoles.

* Run this command to run a Kafka instance: docker-compose up -d
* Download and install Offset Explorer from https://kafkatool.com/download.html
* Offset Explorer tool will be useful for examining the Kafka brokers, topics, partitions, messages, consumers, etc.
* set BootstrapServers to localhost:29092

### Steps to run this solution
* Build the solution
* Run ProducerConsole and start publishing the messages
* Run ConsumerConsole which reads the messages from kafka and prints
