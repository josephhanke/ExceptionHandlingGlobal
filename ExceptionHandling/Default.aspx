<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExceptionHandling.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>Hero Name: <asp:TextBox ID="heroNameTextBox" runat="server"></asp:TextBox></p>
        <p>Hero Hit Points: <asp:TextBox ID="heroHitPoints" runat="server"></asp:TextBox></p>
        <p>Games Won: <asp:TextBox ID="gamesWonTextBox" runat="server"></asp:TextBox></p>
        <p>Total Games Played: <asp:TextBox ID="totalGamesTextBox" runat="server"></asp:TextBox></p>
        <p><asp:Button ID="okButton" runat="server" Text="Calculate" OnClick="okButton_Click" Width="141px" />&nbsp;</p>
            <p>
                <asp:Button ID="doNotClick" runat="server" OnClick="doNotClick_Click" Text="Do NOT click me" Width="142px" />
            </p>
            <p>
                <asp:Button ID="argumentOutOfRangeButton" runat="server" OnClick="argumentOutOfRangeButton_Click" Text="ArgumentOutOfRange" Width="144px" />
            </p>
        <p><asp:Label ID="resultLabel" runat="server" Text=""></asp:Label></p>

        </div>
    </form>
</body>
</html>
