<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Customize_the_WebViewer.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customize the WebViewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            Width="1000px" Height="800px"
            ScrollBarsMode="true" ToolBarBackColor="LightGray" ZoomPercent="150"
            ShowExportToBmp="false" ShowExportToPcx="false" ShowExportToSvg="false" ShowExportToSvgz="false"
            ShowExportToPng="false" ShowExportToGif="false" ShowExportToSylk="false" ShowExportToMetafile="false" 
            ShowExportToJpeg="false" ShowExportToTiff="false" ShowExportToDif="false" ShowExportToDbf="false" 
            ShowExportToCsv="false" ShowExportToXml="false" ShowPrintButton="false"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>
</body>
</html>
