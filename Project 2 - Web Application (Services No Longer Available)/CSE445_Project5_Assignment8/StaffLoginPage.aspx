<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLoginPage.aspx.cs" Inherits="CSE445_Project5_Assignment8.StaffLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Text="Staff Login"></asp:Label>
            </p>
            <asp:Label ID="Label9" runat="server" Font-Bold="False" Font-Size="Medium" Text="Login to gain access to the Staff Page."></asp:Label>
            <br />
            <p>
                <asp:Label ID="Label3" runat="server" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="UserName_Textbox" runat="server" Width="213px"></asp:TextBox>
            </p>
            <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Password_Textbox" runat="server" Width="213px"></asp:TextBox>
            <p>
                <asp:Button ID="Login_Button" runat="server" OnClick="Login_Button_Click" Text="Login" />
            </p>
            <p>
                <asp:Label ID="BadLogin_Label" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" Text="Back" />
            </p>
        </div>
    </form>
</body>
</html>
