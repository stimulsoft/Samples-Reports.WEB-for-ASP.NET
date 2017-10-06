<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Demo.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Demo</title>
    <link rel="stylesheet" type="text/css" href="Styles/webviewer.css" />
    <link rel="stylesheet" type="text/css" href="Styles/dtree.css" />
    <script type="text/javascript" src="Scripts/dtree.js"></script>
    <script type="text/javascript" src="Scripts/reports.js"></script>
</head>
<body>
    <form id="Form1" runat="server" style="width: 100%; height: 100%;">
        <table cellpadding="0" cellspacing="0" style="width: 100%; height: 100%;">
            <tr>
                <td style="width: 100px; height: 100%; vertical-align: top;">
                    <table cellpadding="0" cellspacing="0" style="height: 100%; font-size: 1px;">
                        <tr style="height: 100%;">
                            <td style="width: 100%; padding: 3px; background-color: White; vertical-align: top;">
                                <table cellpadding="1" cellspacing="1" style="width: 100%; height: 100%;">
                                    <tr><td><img src="Images/logoweb.png" style="padding-top: 2px; padding-bottom: 4px;"/></td></tr>
                                    <tr><td style="font-size: 1px; height: 2px;"><div style="height: 2px; border-top: Dashed 1px #c8c8c8;" /></td></tr>
                                    <tr>
                                        <td style="height: 100%; vertical-align: top;">
                                            <div style="width: 270px; max-width: 270px; overflow: hidden;">
                                                <script type="text/javascript">buildReportTree();</script><br />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr><td style="font-size: 10px;">&nbsp</td></tr>
                                </table>
                            </td>
                            <td style="background-image: url(Images/line.png); background-repeat: repeat-y;"><div class="table-side" /></td>
                        </tr>
                        <tr>
                            <td style="font-size: 1px; height: 9px; background-color: White; vertical-align: top;"><div style="height: 2px; border-top: Dashed 1px #c8c8c8;" /></td>
                            <td style="background-image: url(Images/line.png); background-repeat: repeat-y;"><div class="table-side" /></td>
                        </tr>
                        <tr>
                            <td style="text-align: center; background-color: White; padding: 0px 0px 5px 0px;">
                                <a class="link" href="https://www.stimulsoft.com/" target="_blank"><img border="0" src="Images/hyperlink.png" /></a>
                            </td>
                            <td style="background-image: url(Images/line.png); background-repeat: repeat-y;"><div class="table-side" /></td>
                        </tr>
                    </table>
                </td>
                <td style="vertical-align: top;">
                    <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
                        Width="100%" Height="100%" BackgroundColor="#e8e8e8" ShowDesignButton="True" ScrollbarsMode="true" ToolbarDisplayMode="Simple"
                        OnGetReportData="StiWebViewer1_GetReportData"
                        OnReportDesign="StiWebViewer1_ReportDesign" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
