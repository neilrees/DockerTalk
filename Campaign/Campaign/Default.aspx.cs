using System;
using Leads;
using QRCode;

public partial class _Default : System.Web.UI.Page
{
    protected void Subscribe_Click(object sender, EventArgs e)
    {
        Register();

        ShowSubscriptionCode();

        SayThanks();
    }

    void Register()
    {
        var leads = new LeadManagement();
        var name = string.Format("{0} {1}", FirstName.Text, LastName.Text);
        var number = PhoneNumber.Text;

        leads.Create(name, number);
    }

    void ShowSubscriptionCode()
    {
        new SpecialQRCodeGenerator().GenereateCode(message);
    }

    void SayThanks()
    {
        signupTable.Visible = false;
        message.Text = "Thanks!";
    }
}