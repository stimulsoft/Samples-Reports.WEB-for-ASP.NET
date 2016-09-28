<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Customize_the_ViewerFx.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customize the ViewerFx</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewerFx ID="StiWebViewerFx1" runat="server"
            Width="1000px" Height="700px"
            ShowOpenButton="false" ShowDesignButton="false" ShowExitButton="true"
            ExitUrl="http://www.stimulsoft.com"
            ShowExportToBmp="false" ShowExportToPcx="false" ShowExportToSvg="false" ShowExportToSvgz="false"
            ShowExportToPng="false" ShowExportToGif="false" ShowExportToSylk="false" ShowExportToMetafile="false" 
            ShowExportToJpeg="false" ShowExportToTiff="false" ShowExportToDif="false" ShowExportToDbf="false" 
            ShowExportToCsv="false" ShowExportToXml="false"
            AboutDialogTextLine1="My Company Name"
            AboutDialogTextLine2="Information about My Company"
            OnGetReport="StiWebViewerFx1_GetReport" />
    </form>
</body>
</html>
