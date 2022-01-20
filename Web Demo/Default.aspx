<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Demo.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Demo</title>
    <link rel="stylesheet" type="text/css" href="Styles/demo.css" />
    <script type="text/javascript" src="Scripts/demo.js"></script>
</head>
<body>
    <form id="form1" runat="server" style="position: relative; width: 100%; height: 100%;"> 
        <div class="stiLeftPanel" id="MainLeftPanel" >
            <div class="stiLogo" style="overflow: hidden; width: 100%;" >
                <table cellspacing="0" cellpadding="0" style="border-spacing: 0; width: 100%; height: 100%">
                    <tr>
                        <td id="stiLogo" style="vertical-align: middle; text-align: center;" onclick="window.open('https://www.stimulsoft.com/en')">
                            STIMULSOFT
                        </td>
                    </tr>
                </table>
            </div>
            <div id="stiReportsContainer" style="width: 100%" class="stiReportsContainer">
                <script type="text/javascript">createReportsButtons();</script> 
            </div>
            <div class="stiLeftPanelItemSeparator"></div>
        </div>        
        <div id="RightPanel" class="stiRightPanel">
            <iframe src="/Viewer.aspx" id="stiMainFrame" class="stiMainFrame" onload="mainFrameLoadComplete()"></iframe>
        </div>
    </form>
</body>
</html>
