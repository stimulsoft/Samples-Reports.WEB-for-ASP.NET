<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Show_Report_in_the_ViewerFx.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Report in the ViewerFx</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewerFx ID="StiWebViewerFx1" runat="server"
            Width="100%" Height="800px"
            OnGetReport="StiWebViewerFx1_GetReport" />
    </form>
</body>
</html>
