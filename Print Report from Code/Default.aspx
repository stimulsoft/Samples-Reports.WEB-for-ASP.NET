<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Print_Report_from_Code.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print and Export Report from Code</title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <asp:Button ID="ButtonPrintPDF" runat="server" Text="Print Report as PDF" OnClick="ButtonPrintPdf_Click" />
        <br /><br />
        <asp:Button ID="ButtonPrintHTML" runat="server" Text="Print Report as HTML" OnClick="ButtonPrintHtml_Click" />
        <br /><br />
    </form>
</body>
</html>
