<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceiverPage.aspx.cs" Inherits="Messaging_GUI.ReceiverPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Receiver ID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ReceiverID_Textbox" runat="server" Width="180px"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:CheckBox ID="Purge_Checkbox" runat="server" Text="Purge" />
            <br />
            <br />
            Messages<br />
            <br />
            <asp:TextBox ID="Messages_Textbox" runat="server" Height="277px" TextMode="MultiLine" Width="274px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Receive_Button" runat="server" OnClick="Receive_Button_Click" Text="Receive Messages" Width="126px" />
            <br />
            <br />
            <asp:Button ID="SenderPage_Button" runat="server" OnClick="SenderPage_Button_Click" Text="Go To Sender Page" Width="128px" />
        </div>
    </form>
</body>
</html>
