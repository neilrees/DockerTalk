using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Leads;

public partial class AllLeads : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ILeadManagement leads = new LeadManagement();

        foreach (var lead in leads.GetAll())
        {
            var row = new TableRow();
            row.Cells.Add(new TableCell {Text = lead.Name});
            row.Cells.Add(new TableCell {Text = lead.Phone});
            leadsTable.Rows.Add(row);
        }
    }
}