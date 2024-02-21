<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SenderPage.aspx.cs" Inherits="Messaging_GUI.SenderPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Receiver ID&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ReceiverID_Textbox" runat="server" Width="180px"></asp:TextBox>
        <br />
        <br />
        Sender ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SenderID_Textbox" runat="server" Width="180px"></asp:TextBox>
        <br />
        <p>
            Message&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;
            <asp:TextBox ID="Message_Textbox" runat="server" Height="277px" TextMode="MultiLine" Width="274px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Send_Button" runat="server" OnClick="Send_Button_Click" Text="Send" />
        </p>
        <asp:Button ID="ReceiverPage_Button" runat="server" OnClick="ReceiverPage_Button_Click" Text="Go To Receiver Page" Width="138px" />
    </form>
</body>
</html>
