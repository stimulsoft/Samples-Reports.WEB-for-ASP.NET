<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Adding_a_Custom_Function_to_the_Designer.Default" %>
<%@ Register assembly="Stimulsoft.Report.WebDesign" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Adding a Custom Function to the Designer</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnGetReport="StiWebDesigner1_GetReport"
            OnSaveReport="StiWebDesigner1_SaveReport" />
    </form>
</body>
</html>
