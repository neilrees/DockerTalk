<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Docker Demo</title>
    
    <style>
        :root {
            --color-dark:  #161616;
            --color-ocean:  #416dea;
            --color-grass: #3dd28d;
            --color-snow: #FFFFFF;
            --color-salmon: #F32C52;
            --color-sun: #feee7d;
            --color-alge: #7999a9;
            --color-flower: #353866;
            --color-smoke: #e4e4e4;

            --font-face: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol";
        }

         body {
             font-family: sans-serif
         }

         table {
            border: 1px solid #ccc;
            margin: 5px;
            padding: 20px;
        }

        input[type=submit]{
            color: #202129;
            background-color: #f2f2f2;

            margin: 10px;
            padding: 12px 12px;

            cursor: pointer;
            user-select: none;
            transition: all 150ms linear;
            text-align: center;
            white-space: nowrap;
            text-decoration: none !important;
            text-transform: none;
            text-transform: capitalize;

            border: 0 none;
            border-radius: 4px;

            font-size: 13px;
            font-weight: 500;
            line-height: 1.3;

            -webkit-appearance: none;
            -moz-appearance:    none;
 
            justify-content: center;
            align-items: center;
            flex: 0 0 160px;
  
            box-shadow: 2px 5px 10px var(--color-smoke);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Milliman Docker Mailing List Signup</h1>
        <table id="signupTable" runat="server">
            <tr>
                <td>First Name</td>
                <td><asp:TextBox ID="FirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td><asp:TextBox ID="LastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td><asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Subscribe" runat="server" OnClick="Subscribe_Click" Text="I'd like to subscribe to your newsletter" />
                </td>
            </tr>
        </table>
        
        <asp:Label id="message" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
