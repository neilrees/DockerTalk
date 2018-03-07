using System;
using QRCode;
using Transport;

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
        Publisher.Send(new Contact
        {
            Name = string.Format("{0} {1}", FirstName.Text, LastName.Text),
            Phone = PhoneNumber.Text
        });
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