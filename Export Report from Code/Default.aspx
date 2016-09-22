<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Export_Report_from_Code.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2><span style="color: #0066ff">Export Example</span></h2>
        <table>
            <tr>
                <td width="200px">
                    <strong>Select Report:</strong>
                </td>
                <td width="200px">
                    <strong>Select Output Format:</strong>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="ListBoxReports" runat="server" Height="100px">
                        <asp:ListItem Selected="True">Anchors</asp:ListItem>
                        <asp:ListItem>MasterDetail</asp:ListItem>
                        <asp:ListItem>MultiColumnList</asp:ListItem>
                        <asp:ListItem>SimpleGroup</asp:ListItem>
                        <asp:ListItem>SimpleList</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="ListBoxFormats" runat="server" Height="100px">
                        <asp:ListItem Selected="True">Pdf</asp:ListItem>
                        <asp:ListItem>Html</asp:ListItem>
                        <asp:ListItem>Xls</asp:ListItem>
                        <asp:ListItem>Txt</asp:ListItem>
                        <asp:ListItem>Rtf</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonPreview" runat="server" Text="Preview" onclick="ButtonPreview_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonExport" runat="server" Text="Export" onclick="ButtonExport_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
