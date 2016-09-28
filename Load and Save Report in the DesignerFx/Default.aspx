<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Load_and_Save_Report_in_the_DesignerFx.Default" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Load and Save Report in the DesignerFx</title>
    <style type="text/css">
        .style1 {
            width: 80px;
            text-align: center;
        }
        .style2 {
            width: 260px;
            vertical-align: top;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiWebDesigner ID="StiWebDesigner1" runat="server" 
            onsavereport="StiWebDesigner1_SaveReport" 
            ongetpreviewdataset="StiWebDesigner1_GetPreviewDataSet" />
        <table>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="11pt" Text='1. Choose ".mrt" file'></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="11pt" Text='2. Click "Design" button'></asp:Label><br />
                    <br />
                    <asp:FileUpload ID="FileReport" runat="server" Font-Names="Arial" Font-Size="11pt" Width="264px" /><br />
                    <br />
                    <asp:Button ID="ButtonDesignFile" runat="server" Text="Design" Width="141px" OnClick="ButtonDesignFile_Click" />
                    <br />
                </td>
                
                <td class="style1"><b>or</b></td>
                
                <td class="style2">
                    <asp:Label ID="Label3" runat="server" Font-Names="Arial" Font-Size="11pt" Text='1. Choose Report on server'></asp:Label><br />
                    <asp:Label ID="Label4" runat="server" Font-Names="Arial" Font-Size="11pt" Text='2. Click "Design" button'></asp:Label><br />
                    <br />
                    <asp:DropDownList ID="DropDownListReport" runat="server" Width="250px">
                        <asp:ListItem Value="SimpleList.mrt"></asp:ListItem>
                        <asp:ListItem Value="TwoSimpleLists.mrt"></asp:ListItem>
                        <asp:ListItem Value="Invoice.mrt"></asp:ListItem>
                        <asp:ListItem Value="Shapes.mrt"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="ButtonDesignServer" runat="server" Text="Design" Width="141px" onclick="ButtonDesignServer_Click" />
                    <br />
                <td class="style1"><b>or</b></td>
                
                <td class="style2">
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="ButtonDesignNew" runat="server" Text="Design New Report" 
                        Width="157px" onclick="ButtonDesignNew_Click" />
                </td>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
