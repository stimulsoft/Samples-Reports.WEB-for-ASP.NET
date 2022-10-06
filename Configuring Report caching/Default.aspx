<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Configuring_Report_caching.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Configuring Report caching</title>
</head>
<body>
    <h2>Configuring Report caching</h2>
    <form id="form1" runat="server">
        <br /><a href="DefaultCache.aspx">Default Cache</a>
        <br /><a href="FileCache.aspx">File Cache</a>
        <br /><a href="MSSQLCache.aspx">MS SQL Cache</a>
    </form>
</body>
</html>
