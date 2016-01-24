<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DI.WebForms.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:HyperLink NavigateUrl="~/Customers.aspx" Text="Customers" runat="server" />
                <br /><br />
                <asp:TextBox ID="txtCustomerId" runat="server" Width="25" />
                <asp:LinkButton ID="lnkCustomer" runat="server" OnClick="lnkCustomer_Click" Text="Customer" />
            </div>
        </form>
    </body>
</html>
