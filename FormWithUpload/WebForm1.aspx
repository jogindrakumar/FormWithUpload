<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormWithUpload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Submit" />

    <br />
    <asp:Label ID="lblMessage" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
