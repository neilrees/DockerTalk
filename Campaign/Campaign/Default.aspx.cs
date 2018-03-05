using System;
using Leads;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Subscribe_Click(object sender, EventArgs e)
    {
        ILeadManagement leads = new LeadManagement();

        var name = string.Format("{0} {1}", FirstName.Text, LastName.Text);
        var number = PhoneNumber.Text;

        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(number))
        {
            leads.Create(name, number);
        }

        signupTable.Visible = false;
        message.Text = "Thanks!";
    }
}