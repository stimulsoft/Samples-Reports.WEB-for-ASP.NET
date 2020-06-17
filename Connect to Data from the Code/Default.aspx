<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Connect_to_Data_from_the_Code._Default" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br /><asp:LinkButton ID="LinkButtonViewer" runat="server" OnClick="LinkButtonViewer_Click">View Report</asp:LinkButton>
    <br /><asp:LinkButton ID="LinkButtonDesigner" runat="server" OnClick="LinkButtonDesigner_Click">Design Report</asp:LinkButton>

</asp:Content>
