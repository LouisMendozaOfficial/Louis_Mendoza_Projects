<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XML_TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
<br />

    <asp:Label ID="Label7" runat="server" Font-Size="Larger" style="font-weight: 700" Text="Validation Service"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
    &nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server">http://localhost:50890/Service1.svc</asp:HyperLink>
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Text="A service which takes an XML file from a website at the given URL and checks if its valid."></asp:Label>
    <br />
    <br />
<br />
    <asp:Label ID="Label11" runat="server" style="font-weight: 700" Text="Input URL:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
<br />
    <asp:TextBox ID="URL_Textbox" runat="server" Height="16px" Width="707px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Validate_Button" runat="server" OnClick="Validate_Button_Click" Text="Validate" />
<br />
<br />
<asp:Label ID="Valid_Label" runat="server"></asp:Label>

<br />
<br />

    <br />
<br />

    <asp:Label ID="Label12" runat="server" Font-Size="Larger" style="font-weight: 700" Text="XPathSearch Service"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label13" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
    &nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink3" runat="server">http://localhost:50890/Service1.svc</asp:HyperLink>
    <br />
    <br />
    <asp:Label ID="Label14" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label15" runat="server" Text="A service which takes an XML file from a website at the given URL and a path for it and outputs the contents of the path."></asp:Label>
    <br />
    <br />
<br />
    <asp:Label ID="Label16" runat="server" style="font-weight: 700" Text="Input URL:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
<br />
    <asp:TextBox ID="URL_Textbox0" runat="server" Height="16px" Width="707px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label17" runat="server" style="font-weight: 700" Text="Input Path:"></asp:Label>
    <br />
<br />
    <asp:TextBox ID="Path_Textbox" runat="server" Height="16px" Width="707px"></asp:TextBox>
<br />
<br />
<asp:Button ID="Path_Button" runat="server" OnClick="Path_Button_Click" Text="Display Contents" />
<br />
<br />
<asp:Label ID="Path_Label" runat="server"></asp:Label>

</asp:Content>
