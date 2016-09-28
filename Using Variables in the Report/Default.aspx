<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Using_Variables_in_the_Report.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using Variables in the Report</title>
</head>
<body>
    <h2><span style="color: #0066ff">Variables Example</span></h2>
    <h3>This sample demonstrates how to operate with report variables</h3>
    <form id="form1" action="Report.aspx" >
    <div>
        <table style="width:100%;">
            <tr>
                <td style="width:100px;"><label for="name">Name:</label></td>
                <td><input id="Name" type="text" name="name" /></td>
            </tr>
            <tr>
                <td><label for="surname">Surname:</label></td>
                <td><input id="Surname" type="text" name="surname" /></td>
            </tr>
            <tr>
                <td><label for="email">E-Mail:</label></td>
                <td><input id="EMail" type="text" name="email" /></td>
            </tr>
            <tr>
                <td><label for="address">Address:</label></td>
                <td><input id="Address" type="text" name="address" /></td>
            </tr>
            <tr>
                <td><label for="sex">Sex:</label></td>
                <td>
                    <input id="Radio1" type="radio" name="sex" value="true" checked="checked" />Male
                    <input id="Radio2" type="radio" name="sex" value="false" />Female
                </td>
            </tr>
        </table>
        <p>
            <input id="Submit" type="submit" value="Submit" />
        </p>
    </div>
    </form>
    <br />
    <a href="Design.aspx">Design Report</a>
</body>
</html>
