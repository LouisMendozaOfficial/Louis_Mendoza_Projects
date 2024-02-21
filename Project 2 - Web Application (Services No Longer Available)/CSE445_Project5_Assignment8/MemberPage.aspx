<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="CSE445_Project5_Assignment8.MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}
  * {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
  }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label13" runat="server" Font-Size="X-Large" style="font-weight: 700" Text="Members Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Size="Larger" style="font-weight: 700" Text="Top Ten Words Service"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server">http://webstrar106.fulton.asu.edu/page10/Service1.svc</asp:HyperLink>
            <br />
            <asp:Label ID="Label9" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="string[] TopTenWords(string url) - A service that finds the top 10 most used words in a website. "></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" style="font-weight: 700" Text="Input URL:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            <asp:TextBox ID="URL_Textbox0" runat="server" Height="16px" Width="707px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="TopTenWords_Button" runat="server" OnClick="TopTenWords_Button_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" style="font-weight: 700" Text="Top Ten Words:"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="TopTenWords_Label" runat="server" Height="72px" style="margin-left: 0px" Width="572px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label19" runat="server" Font-Size="Larger" style="font-weight: 700" Text="Average Sentence Length"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label20" runat="server" style="font-weight: 700" Text="Service URL:  "></asp:Label>
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server">http://webstrar106.fulton.asu.edu/page10/Service1.svc</asp:HyperLink>
            <br />
            <asp:Label ID="Label21" runat="server" style="font-weight: 700" Text="Description: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label22" runat="server" Text="int AverageSentenceLength(string url) - A service that finds the average length of the sentences in a website."></asp:Label>
            <br />
            <asp:Label ID="Label23" runat="server" style="font-weight: 700" Text="Input URL:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            <asp:TextBox ID="URL_Textbox1" runat="server" Height="16px" Width="707px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AverageSentenceLength_Button" runat="server" OnClick="AverageSentenceLength_Button_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="Label24" runat="server" style="font-weight: 700" Text="Average Sentence Length:"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="AverageSentenceLength_Label" runat="server" Height="72px" style="margin-left: 0px" Width="572px"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" Text="Back" />
            <br />
            <br />
            <asp:Button ID="Logout_Button" runat="server" OnClick="Logout_Button_Click" Text="Logout" />
        </div>
    </form>
</body>
</html>
