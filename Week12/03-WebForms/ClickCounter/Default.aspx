<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClickCounter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter a name"></asp:TextBox>
        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                                      ControlToValidate="TextBox1"
                                      ErrorMessage="Enter a name is a required field."
                                      ForeColor="Red">
                                    </asp:RequiredFieldValidator>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
