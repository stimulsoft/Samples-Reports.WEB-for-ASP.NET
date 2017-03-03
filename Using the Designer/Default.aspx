<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Using_the_Designer.Default" %>
<%@ Register Assembly="Stimulsoft.Report.MobileDesign" Namespace="Stimulsoft.Report.MobileDesign" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using the Designer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiMobileDesigner ID="StiMobileDesigner1" runat="server"
            OnCreateReport="StiMobileDesigner1_CreateReport" 
            OnPreviewReport="StiMobileDesigner1_PreviewReport"
            OnSaveReport="StiMobileDesigner1_SaveReport" />
    </div>
    </form>
</body>
</html>
