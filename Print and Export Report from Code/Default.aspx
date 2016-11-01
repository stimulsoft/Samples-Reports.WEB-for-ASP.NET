<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Print_and_Export_Report_from_Code.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print and Export Report from Code</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="ButtonPrint" runat="server" Text="Print Report" OnClick="ButtonPrint_Click" />
        <br /><br />
        <asp:Button ID="ButtonExport" runat="server" Text="Export Report" OnClick="ButtonExport_Click" />
    </form>
</body>
</html>
