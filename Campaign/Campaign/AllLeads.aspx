<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllLeads.aspx.cs" Inherits="AllLeads" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style>
        body {
            font-family: sans-serif
        }

         table {
             border: 1px solid #ccc;
             margin: 5px;
             padding: 20px;
         }

        td {
            border: 1px solid #eee;
        }
    </style>
</head>
<body>

    <h2>All Docker Mailing List Signups</h2>

    <asp:Table ID="leadsTable" runat="server" Width="100%"> 
        <asp:TableRow>
            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Phone</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>
        
</body>
</html>
