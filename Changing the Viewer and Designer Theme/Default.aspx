<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Changing_the_Viewer_and_Designer_Theme_and_viewer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Changing the Viewer and Designer Theme</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>This sample demonstrates how to set a theme for the report designer or viewer</h2>
            <h3><span style="color: #0066ff">Themes for the designer</span></h3>
            <asp:DropDownList ID="DropDownListDesignerThemes" runat="server">
                <asp:ListItem Value="Office2013WhiteBlue">Office2013WhiteBlue</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteCarmine">Office2013WhiteCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteGreen">Office2013WhiteGreen</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteOrange">Office2013WhiteOrange</asp:ListItem>
                <asp:ListItem Value="Office2013WhitePurple">Office2013WhitePurple</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteTeal">Office2013WhiteTeal</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteViolet">Office2013WhiteViolet</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayBlue">Office2013LightGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayCarmine">Office2013LightGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayGreen">Office2013LightGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayOrange">Office2013LightGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayPurple">Office2013LightGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayTeal">Office2013LightGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayViolet">Office2013LightGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayBlue">Office2013DarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayCarmine">Office2013DarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayGreen">Office2013DarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayOrange">Office2013DarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayPurple">Office2013DarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayTeal">Office2013DarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayViolet">Office2013DarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayBlue">Office2013VeryDarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayCarmine">Office2013VeryDarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayGreen">Office2013VeryDarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayOrange">Office2013VeryDarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayPurple">Office2013VeryDarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayTeal">Office2013VeryDarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayViolet">Office2013VeryDarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteBlue">Office2022WhiteBlue</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteCarmine">Office2022WhiteCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteGreen">Office2022WhiteGreen</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteOrange">Office2022WhiteOrange</asp:ListItem>
                <asp:ListItem Value="Office2022WhitePurple">Office2022WhitePurple</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteTeal">Office2022WhiteTeal</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteViolet">Office2022WhiteViolet</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayBlue">Office2022LightGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayCarmine">Office2022LightGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayGreen">Office2022LightGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayOrange">Office2022LightGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayPurple">Office2022LightGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayTeal">Office2022LightGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayViolet">Office2022LightGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayBlue">Office2022DarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayCarmine">Office2022DarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayGreen">Office2022DarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayOrange">Office2022DarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayPurple">Office2022DarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayTeal">Office2022DarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayViolet">Office2022DarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022BlackBlue">Office2022BlackBlue</asp:ListItem>
                <asp:ListItem Value="Office2022BlackCarmine">Office2022BlackCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022BlackGreen">Office2022BlackGreen</asp:ListItem>
                <asp:ListItem Value="Office2022BlackOrange">Office2022BlackOrange</asp:ListItem>
                <asp:ListItem Value="Office2022BlackPurple">Office2022BlackPurple</asp:ListItem>
                <asp:ListItem Value="Office2022BlackTeal">Office2022BlackTeal</asp:ListItem>
                <asp:ListItem Value="Office2022BlackViolet">Office2022BlackViolet</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="ButtonShowDesigner" runat="server" Text="Show Designer" OnClick="ButtonShowDesigner_Click" />
        </div>
        <div style="margin-top: 50px;">
            <h3><span style="color: #0066ff">Themes for the viewer</span></h3>
            <asp:DropDownList ID="DropDownListViewerThemes" runat="server">
                <asp:ListItem Value="SimpleGray">SimpleGray</asp:ListItem>
                <asp:ListItem Value="WindowsXP">WindowsXP</asp:ListItem>
                <asp:ListItem Value="Office2003">Office2003</asp:ListItem>
                <asp:ListItem Value="Office2007Blue">Office2007Blue</asp:ListItem>
                <asp:ListItem Value="Office2007Black">Office2007Black</asp:ListItem>
                <asp:ListItem Value="Office2007Silver">Office2007Silver</asp:ListItem>
                <asp:ListItem Value="Office2010Blue">Office2010Blue</asp:ListItem>
                <asp:ListItem Value="Office2010Black">Office2010Black</asp:ListItem>
                <asp:ListItem Value="Office2010Silver">Office2010Silver</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteBlue">Office2013WhiteBlue</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteCarmine">Office2013WhiteCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteGreen">Office2013WhiteGreen</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteOrange">Office2013WhiteOrange</asp:ListItem>
                <asp:ListItem Value="Office2013WhitePurple">Office2013WhitePurple</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteTeal">Office2013WhiteTeal</asp:ListItem>
                <asp:ListItem Value="Office2013WhiteViolet">Office2013WhiteViolet</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayBlue">Office2013LightGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayCarmine">Office2013LightGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayGreen">Office2013LightGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayOrange">Office2013LightGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayPurple">Office2013LightGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayTeal">Office2013LightGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013LightGrayViolet">Office2013LightGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayBlue">Office2013DarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayCarmine">Office2013DarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayGreen">Office2013DarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayOrange">Office2013DarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayPurple">Office2013DarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayTeal">Office2013DarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013DarkGrayViolet">Office2013DarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayBlue">Office2013VeryDarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayCarmine">Office2013VeryDarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayGreen">Office2013VeryDarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayOrange">Office2013VeryDarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayPurple">Office2013VeryDarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayTeal">Office2013VeryDarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2013VeryDarkGrayViolet">Office2013VeryDarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteBlue">Office2022WhiteBlue</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteCarmine">Office2022WhiteCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteGreen">Office2022WhiteGreen</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteOrange">Office2022WhiteOrange</asp:ListItem>
                <asp:ListItem Value="Office2022WhitePurple">Office2022WhitePurple</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteTeal">Office2022WhiteTeal</asp:ListItem>
                <asp:ListItem Value="Office2022WhiteViolet">Office2022WhiteViolet</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayBlue">Office2022LightGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayCarmine">Office2022LightGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayGreen">Office2022LightGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayOrange">Office2022LightGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayPurple">Office2022LightGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayTeal">Office2022LightGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2022LightGrayViolet">Office2022LightGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayBlue">Office2022DarkGrayBlue</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayCarmine">Office2022DarkGrayCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayGreen">Office2022DarkGrayGreen</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayOrange">Office2022DarkGrayOrange</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayPurple">Office2022DarkGrayPurple</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayTeal">Office2022DarkGrayTeal</asp:ListItem>
                <asp:ListItem Value="Office2022DarkGrayViolet">Office2022DarkGrayViolet</asp:ListItem>
                <asp:ListItem Value="Office2022BlackBlue">Office2022BlackBlue</asp:ListItem>
                <asp:ListItem Value="Office2022BlackCarmine">Office2022BlackCarmine</asp:ListItem>
                <asp:ListItem Value="Office2022BlackGreen">Office2022BlackGreen</asp:ListItem>
                <asp:ListItem Value="Office2022BlackOrange">Office2022BlackOrange</asp:ListItem>
                <asp:ListItem Value="Office2022BlackPurple">Office2022BlackPurple</asp:ListItem>
                <asp:ListItem Value="Office2022BlackTeal">Office2022BlackTeal</asp:ListItem>
                <asp:ListItem Value="Office2022BlackViolet">Office2022BlackViolet</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="ButtonShowViewer" runat="server" Text="Show Viewer" OnClick="ButtonShowViewer_Click" />
        </div>
    </form>
</body>
</html>
