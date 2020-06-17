<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Designer.aspx.cs" Inherits="Connect_to_Data_from_the_Code.Designer" %>
<%@ Register Assembly="Stimulsoft.Report.WebDesign" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <cc1:StiWebDesigner ID="StiWebDesigner1" runat="server"
            OnGetReport="StiWebDesigner1_GetReport"
            OnPreviewReport="StiWebDesigner1_PreviewReport" />

</asp:Content>
