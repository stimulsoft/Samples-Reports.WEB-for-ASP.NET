﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Creating_a_Custom_Button_on_the_Viewer_Toolbar.Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Creating a Custom Button on the Viewer Toolbar</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
            OnGetReport="StiWebViewer1_GetReport" />
    </form>

    <script type="text/javascript">
        jsStiWebViewer1.onready = function () {
            var customButton = jsStiWebViewer1.SmallButton("customButton", "Custom Button", "emptyImage");
            customButton.image.src = "icon.png";
            customButton.action = function () {
                alert("Custom Button Event");
            }

            var toolbarTable = jsStiWebViewer1.controls.toolbar.firstChild.firstChild;
            var buttonsTable = toolbarTable.rows[0].firstChild.firstChild;
            var customButtonCell = buttonsTable.rows[0].insertCell(0);
            customButtonCell.appendChild(customButton);
        }
    </script>
</body>
</html>
