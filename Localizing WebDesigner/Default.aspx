<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Localizing_WebDesigner.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><span style="color: #0066ff">Localized Designer Example</span></h2>
        <h3>This sample demonstrates how to localize the report designer</h3>
        <asp:DropDownList ID="DropDownListLang" runat="server">
            <asp:ListItem Value="ar">Arabic</asp:ListItem>    
            <asp:ListItem Value="be">Belarusian</asp:ListItem>
            <asp:ListItem Value="bg">Bulgarian</asp:ListItem>
            <asp:ListItem Value="cro">Croatian</asp:ListItem>
            <asp:ListItem Value="cz">Czech</asp:ListItem>
            <asp:ListItem Value="de">Deutsch</asp:ListItem>
            <asp:ListItem Value="en" Selected="True">English</asp:ListItem>
            <asp:ListItem Value="es">Spanish</asp:ListItem>
            <asp:ListItem Value="fa">Farsi</asp:ListItem>
            <asp:ListItem Value="fr">French</asp:ListItem>
            <asp:ListItem Value="hu">Hungarian</asp:ListItem>
            <asp:ListItem Value="it">Italian</asp:ListItem>
            <asp:ListItem Value="ka">Georgian</asp:ListItem>
            <asp:ListItem Value="lt">Lithuanian</asp:ListItem>
            <asp:ListItem Value="nl">Dutch</asp:ListItem>
            <asp:ListItem Value="pl">Polish</asp:ListItem>
            <asp:ListItem Value="pt-BR">Portugese (Brazil)</asp:ListItem>
            <asp:ListItem Value="ro">Romanian</asp:ListItem>
            <asp:ListItem Value="ru">Russian</asp:ListItem>
            <asp:ListItem Value="ser">Serbian</asp:ListItem>
            <asp:ListItem Value="sk">Slovak</asp:ListItem>
            <asp:ListItem Value="sv">Swedish</asp:ListItem>
            <asp:ListItem Value="tr">Turkish</asp:ListItem>
            <asp:ListItem Value="ua">Ukrainian</asp:ListItem>
            <asp:ListItem Value="zh-CHS">Chinese (Simplified)</asp:ListItem>
            <asp:ListItem Value="zh-CHT">Chinese (Traditional)</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonShowDesigner" runat="server" Text="Show Designer" onclick="ButtonShowDesigner_Click" />
    </div>
    </form>
</body>
</html>
