using System;
using System.Text;
using System.Threading;
using NATS.Client;
using Newtonsoft.Json;

namespace Transport
{
    public static class Receiver
    {
        public static void Listen(Action<Contact> onMessageReceived)
        {
            var opts = ConnectionFactory.GetDefaultOptions();
            opts.Url = Defaults.Url;

            var testLock = new Object();

            using (var connection = new ConnectionFactory().CreateConnection(opts))
            {
                using (var subscription = connection.SubscribeAsync("signups", (sender, args) =>
                {
                    var payload = Encoding.UTF8.GetString(args.Message.Data);
                    Console.WriteLine(payload);

                    var contact = JsonConvert.DeserializeObject<Contact>(payload);

                    onMessageReceived(contact);
                }))
                {
                    // just wait until we are done.
                    lock (testLock)
                    {
                        Monitor.Wait(testLock);
                    }
                }
            }
        }

    }
}
