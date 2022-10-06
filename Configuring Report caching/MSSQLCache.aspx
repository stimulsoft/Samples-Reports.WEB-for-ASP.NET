<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MSSQLCache.aspx.cs" Inherits="Configuring_Report_caching.MSSQLCache" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Configuring Report caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
