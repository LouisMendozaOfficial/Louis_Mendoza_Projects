<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Project5_Assignment8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
<asp:Label ID="Title_Label" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="The Important Stuff Application"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="About_Label" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Text="About"></asp:Label>
<br />
<br />
<asp:Label ID="AboutInfo_Label1" runat="server" Text="This application implements a series of services that tell you about the word and sentence content, numbers, and information from a given website."></asp:Label>
<br />
<asp:Label ID="AboutInfo_Label2" runat="server" Text="To test out our application and accompanying services, all you will need is a valid URL of a website."></asp:Label>
    <br />
<asp:Label ID="AboutInfo_Label3" runat="server" Text="Head to the Member Page to access and use our services!"></asp:Label>
<br />
<br />
<br />
<asp:Button ID="MemberPage_Button" runat="server" Font-Bold="True" Font-Size="Large" OnClick="MemberPage_Button_Click" Text="Go Member Page" Width="174px" />
<br />
<br />
<asp:Button ID="StaffPage_Button" runat="server" Font-Bold="True" Font-Size="Large" OnClick="StaffPage_Button_Click" Text="Go Staff Page" Width="174px" />
    <br />
    <br />
    <asp:Button ID="Logout_Button" runat="server" Font-Bold="True" Font-Size="Large" OnClick="Logout_Button_Click" Text="Logout" />
<br />

</asp:Content>
