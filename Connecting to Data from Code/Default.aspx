<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Connecting_to_Data_from_Code.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Connecting to Data from Code</title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><asp:LinkButton ID="LinkButtonViewer" runat="server" OnClick="LinkButtonViewer_Click">View Report</asp:LinkButton>
        <br /><asp:LinkButton ID="LinkButtonDesigner" runat="server" OnClick="LinkButtonDesigner_Click">Design Report</asp:LinkButton>
    </form>
</body>
</html>
