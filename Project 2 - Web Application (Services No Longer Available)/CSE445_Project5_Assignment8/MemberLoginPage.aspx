<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLoginPage.aspx.cs" Inherits="CSE445_Project5_Assignment8.MemberLoginPage" %>

<%@ Register Src="~/MemberLoginControl.ascx" TagPrefix="uc1" TagName="MemberLoginControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Text="The Important Stuff Application"></asp:Label>
            <br />
            <uc1:MemberLoginControl runat="server" ID="MemberLoginControl" />
        </div>
    </form>
</body>
</html>
