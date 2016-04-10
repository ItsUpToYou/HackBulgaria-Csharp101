<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="ClickCounter.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name:">Name:<%: Session["Name"] %></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Click:">Clicks: <%: Session["Click"] %></asp:Label>
        </div>
        <div>
            <asp:Label ID="txtTotalClick" runat="server" Text="TotalClick">TotalClicks: <%: Application["totalClicks"] %></asp:Label>
        </div>
    </form>
</body>
</html>
