<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadform.aspx.cs" Inherits="FormWithUpload.uploadform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="btnUpload" runat="server" Text="Submit" />

    <br />
    <asp:Label ID="lblMessage" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
