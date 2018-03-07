using System.Text;
using NATS.Client;
using Newtonsoft.Json;

namespace Transport
{
    public static class Publisher
    {
        public static void Send(Contact contact)
        {
            Options opts = ConnectionFactory.GetDefaultOptions();
            opts.Url = Defaults.Url;

            using (IConnection c = new ConnectionFactory().CreateConnection(opts))
            {
                byte[] payload = null;

                c.Publish("signups", CreatePayload(contact.Name, contact.Phone));
                c.Flush();
            }
        }

        static byte[] CreatePayload(string name, string phone)
        {
            var json = JsonConvert.SerializeObject(new {Name = name, Phone = phone});
            return Encoding.UTF8.GetBytes(json);
        }
    }
}