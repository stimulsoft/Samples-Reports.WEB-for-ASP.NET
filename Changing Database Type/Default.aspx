<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Changing_Database_Type.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Changing Database Type</title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><asp:LinkButton ID="LinkButtonJsonDatabase" runat="server" OnClick="LinkButtonJsonDatabase_Click">View Report with JSON database</asp:LinkButton>
        <br /><asp:LinkButton ID="LinkButtonMySqlDatabase" runat="server" OnClick="LinkButtonMySqlDatabase_Click">View Report with database changed to MySQL</asp:LinkButton>
    </form>
</body>
</html>
