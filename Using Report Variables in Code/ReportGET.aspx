<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportGET.aspx.cs" Inherits="Using_Report_Variables_in_Code.ReportGET" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formViewer" runat="server">
    <div>
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" PassQueryParametersToReport="true" />
    </div>
    </form>
</body>
</html>
