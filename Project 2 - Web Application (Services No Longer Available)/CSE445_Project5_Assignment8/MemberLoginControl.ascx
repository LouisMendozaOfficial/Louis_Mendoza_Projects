<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberLoginControl.ascx.cs" Inherits="CSE445_Project5_Assignment8.MemberLoginControl" %>
<p>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Text="Login or Register"></asp:Label>
</p>
<asp:Label ID="Label9" runat="server" Font-Bold="False" Font-Size="Medium" Text="Login or Register to gain access to the member page."></asp:Label>
<br />
<br />
<br />
<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Returning User"></asp:Label>
<p>
    <asp:Label ID="Label3" runat="server" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ReturningUserName_Textbox" runat="server" Width="213px"></asp:TextBox>
</p>
<asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="ReturningUserPassword_Textbox" runat="server" Width="213px"></asp:TextBox>
<p>
    <asp:Button ID="Login_Button" runat="server" OnClick="Login_Button_Click" Text="Login" />
</p>
<p>
    <asp:Label ID="BadLogin_Label" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="New User"></asp:Label>
<p>
    &nbsp;<asp:Label ID="Label6" runat="server" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NewUserName_Textbox" runat="server" Width="213px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label8" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="NewUserPassword_Textbox" runat="server" Width="213px"></asp:TextBox>
</p>
<asp:Button ID="Register_Button" runat="server" OnClick="Register_Button_Click" Text="Register" />
<p>
    <asp:Label ID="BadRegister_Label" runat="server"></asp:Label>
    &nbsp;<asp:Label ID="SuccessfulRegister_Label" runat="server"></asp:Label>
</p>

<p>
    <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" Text="Back" />
</p>


