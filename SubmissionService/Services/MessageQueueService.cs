using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Client;
using LocalHpcShared.Jobs;


namespace SubmissionService.Services
{
    public class MessageQueueService
    {

        // TODO: Inject configuration POCO
        public MessageQueueService()
        {

        }

        public async Task SubmitJob(Job job)
        {

            // TODO: Abstract URLs into config
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "user",
                Password = "password"
                
            };

            using var connection = factory.CreateConnection();

            using (var channel = connection.CreateModel())
            {

                channel.ExchangeDeclare("Jobs", ExchangeType.Fanout);


                channel.QueueDeclare("HpcJobs", durable: true, exclusive: false, autoDelete: false, arguments: null);


                var body = System.Text.Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(job));

                channel.BasicPublish("Jobs", "", basicProperties: null, body: body);

            }

        }





    }
}
