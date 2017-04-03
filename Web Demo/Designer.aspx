<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Designer.aspx.cs" Inherits="Web_Demo.Designer" %>
<%@ Register Assembly="Stimulsoft.Report.MobileDesign" Namespace="Stimulsoft.Report.MobileDesign" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StiMobileDesigner ID="StiMobileDesigner1" runat="server" ShowFileMenuExit="true"
            OnPreviewReport="StiMobileDesigner1_PreviewReport"
            OnSaveReport="StiMobileDesigner1_SaveReport"
            OnExit="StiMobileDesigner1_Exit" />
    </div>
    </form>
</body>
</html>
