<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer.aspx.cs" Inherits="Web_Demo.Viewer" %>
<%@ Register Assembly="Stimulsoft.Report.Web" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
                FullScreenMode="true"
                ShowFullScreenButton="false"
                ShowDesignButton="true"
                ToolbarDisplayMode="Separated"
                OnGetReport="StiWebViewer1_GetReport"
                OnDesignReport="StiWebViewer1_DesignReport" />
        </div>
    </form>
</body>
</html>
