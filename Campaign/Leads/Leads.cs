using System;
using System.Collections.Generic;
using System.Linq;
using Leads.DB;

namespace Leads
{
    public interface ILeadManagement
    {
        void Create(string name, string phone);
        IEnumerable<Lead> GetAll();
    }

    public class LeadManagement : ILeadManagement
    {
        public void Create(string name, string phone)
        {
            using (var db = new CRMContext())
            {
                db.Leads.Add(new Lead
                {
                    Name = name,
                    Phone = phone
                });

                db.SaveChanges();
            }
        }

        public IEnumerable<Lead> GetAll()
        {
            using (var db = new CRMContext())
            {
                foreach (var l in db.Leads.OrderByDescending(l => l.LeadId))
                {
                    yield return l;
                }
            }
        }
    }
}
