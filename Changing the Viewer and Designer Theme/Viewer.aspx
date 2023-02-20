<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer.aspx.cs" Inherits="Changing_the_Viewer_and_Designer_Theme.Viewer" %>
<%@ Register Assembly="Stimulsoft.Report.Web" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server" OnGetReport="StiWebViewer1_GetReport" />
    </div>
    </form>
</body>
</html>
