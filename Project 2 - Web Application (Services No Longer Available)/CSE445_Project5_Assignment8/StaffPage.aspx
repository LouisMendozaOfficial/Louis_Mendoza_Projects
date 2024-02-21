<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="CSE445_Project5_Assignment8.StaffPage" %>

<%@ Register Src="~/StaffAddControl.ascx" TagPrefix="uc1" TagName="StaffAddControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Text="Staff Page"></asp:Label>
            <br />
            <br />
            <uc1:StaffAddControl runat="server" ID="StaffAddControl" />
            <br />
            <p>
                <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" Text="Back" />
            </p>
        </div>
        <asp:Button ID="Logout_Button" runat="server" OnClick="Logout_Button_Click" Text="Logout" />
    </form>
</body>
</html>
