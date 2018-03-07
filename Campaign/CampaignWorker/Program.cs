using System;
using Leads;
using Transport;

namespace CampaignWorker
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Listening...");
            Receiver.Listen(contact =>
            {
                Console.WriteLine($"Contact received: {contact.Name}, {contact.Phone}");
                OnConcatReceived(contact);
            });
        }

        static void OnConcatReceived(Contact contact)
        {
            var leadManagement = new LeadManagement();

            leadManagement.Create(contact.Name, contact.Phone);
        }
    }
}