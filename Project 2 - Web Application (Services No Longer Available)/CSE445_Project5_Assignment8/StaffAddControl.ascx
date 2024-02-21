<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StaffAddControl.ascx.cs" Inherits="CSE445_Project5_Assignment8.WebUserControl1" %>
<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="Add New Staff Member"></asp:Label>
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
<p>
    <asp:Button ID="Add_Button" runat="server" OnClick="Add_Button_Click" Text="Add" />
</p>
<p>
    <asp:Label ID="BadRegister_Label" runat="server"></asp:Label>
    &nbsp;<asp:Label ID="SuccessfulRegister_Label" runat="server"></asp:Label>
</p>

