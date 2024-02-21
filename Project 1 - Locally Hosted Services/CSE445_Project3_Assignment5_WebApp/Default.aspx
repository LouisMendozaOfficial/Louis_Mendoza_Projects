<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Project3_Assignment5_WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

    <div class="jumbotron">
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="Larger" style="font-weight: 700" Text="Word Filter Service"></asp:Label>
        <br />
        <br />
        &nbsp;<asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server">http://localhost:50048/Service1.svc</asp:HyperLink>
        <br />
        &nbsp;<asp:Label ID="Label3" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="string WordFilter(string inputString) - A service that filters out unimportant words in text such as &quot;a&quot; and &quot;the&quot;. "></asp:Label>
        <br />
        &nbsp;<asp:Label ID="Label5" runat="server" style="font-weight: 700" Text="Input Text:"></asp:Label>
&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:TextBox ID="Unfiltered_Textbox" runat="server" Height="95px" Width="707px" TextMode="MultiLine"></asp:TextBox>
        <br />
&nbsp;<br />
&nbsp;<asp:Button ID="Filter_Button" runat="server" OnClick="Filter_Button_Click" Text="Filter" Width="73px" />
        <br />
        &nbsp;<asp:Label ID="Label6" runat="server" style="font-weight: 700" Text="Filtered Text:"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;<asp:Label ID="Filtered_Label" runat="server" Height="137px" style="margin-left: 0px" Width="572px"></asp:Label>
        <br />
        &nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;<br />
        <asp:Label ID="Label7" runat="server" Font-Size="Larger" style="font-weight: 700" Text="Top Ten Words Service"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server">http://localhost:50048/Service1.svc</asp:HyperLink>
        <br />
        <asp:Label ID="Label9" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="string[] TopTenWords(string url) - A service that finds the top 10 most used words in a website. "></asp:Label>
        <br />
        <asp:Label ID="Label11" runat="server" style="font-weight: 700" Text="Input URL:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
        <asp:TextBox ID="URL_Textbox" runat="server" Height="16px" Width="707px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Find_Button" runat="server" OnClick="Find_Button_Click" Text="Find" />
        <br />
        <asp:Label ID="Label12" runat="server" style="font-weight: 700" Text="Top Ten Words:"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="TopTenWords_Label" runat="server" Height="72px" style="margin-left: 0px" Width="572px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </div>

    </div>

</asp:Content>
