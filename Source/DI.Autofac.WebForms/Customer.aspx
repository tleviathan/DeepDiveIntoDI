﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="DI.WebForms.Customer1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:DetailsView ID="detCustomer" runat="server" />
            </div>
            <br />
            <asp:HyperLink runat="server" NavigateUrl="~/Default.aspx" Text="Home" />
        </form>
    </body>
</html>
