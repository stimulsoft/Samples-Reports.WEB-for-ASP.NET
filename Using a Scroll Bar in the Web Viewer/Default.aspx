<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Using_a_Scroll_Bar_in_the_Web_Viewer.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using a Scroll Bar in the Web Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" 
            Width="800px" Height="500px" ScrollbarsMode="true"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
