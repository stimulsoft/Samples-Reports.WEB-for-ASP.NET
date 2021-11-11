<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Using_Designer_Events.Default" %>
<%@ Register Assembly="Stimulsoft.Report.WebDesign" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using Designer Events</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnCreateReport="StiWebDesigner1_CreateReport" 
            OnPreviewReport="StiWebDesigner1_PreviewReport"
            OnSaveReport="StiWebDesigner1_SaveReport" />
    </div>
    </form>
</body>
</html>
