﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Runtime_Report_Creation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>
        <span style="color: #0066ff">Runtime Build Report Example</span></h2>
        <h3>This sample demonstrates how to build the report at runtime</h3>
        <asp:Button ID="ButtonShowReport" runat="server" Text="Build Report" 
            onclick="ButtonShowReport_Click" />    
    </div>
    </form>
</body>
</html>
