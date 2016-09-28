<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Globalized_Reports.Default" %>
<%@ Register Assembly="Stimulsoft.Report.Web" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Globalized Reports</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="14px" Text="Select Country"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="150">
            <asp:ListItem Value="fr-FR">France</asp:ListItem>
            <asp:ListItem Value="de-DE">Germany</asp:ListItem>
            <asp:ListItem Value="it-IT">Italy</asp:ListItem>
            <asp:ListItem Value="ru-RU">Russia</asp:ListItem>
            <asp:ListItem Value="es-ES">Spain</asp:ListItem>
            <asp:ListItem Value="en-GB">United Kingdom</asp:ListItem>
            <asp:ListItem Value="en-US">United States</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="View Report" onclick="Button1_Click" />
        <br />
        <br />
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" />
    </div>
    </form>
</body>
</html>
