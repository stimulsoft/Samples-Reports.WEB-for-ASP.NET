<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Customizing_the_Viewer.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customizing the Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            Width="1000px" Height="800px"
            Theme="Office2013LightGrayPurple"
            ScrollBarsMode="true" ZoomPercent="150" ToolbarDisplayMode="Separated"
            ShowExportToBmp="false" ShowExportToPcx="false" ShowExportToSvg="false" ShowExportToSvgz="false"
            ShowExportToPng="false" ShowExportToGif="false" ShowExportToSylk="false" ShowExportToMetafile="false" 
            ShowExportToJpeg="false" ShowExportToTiff="false" ShowExportToDif="false" ShowExportToDbf="false" 
            ShowExportToCsv="false" ShowExportToXml="false" ShowPrintButton="false"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
