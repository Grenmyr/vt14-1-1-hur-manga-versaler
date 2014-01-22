<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Versaler._default" ViewStateMode ="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hur många versaler?</h1>
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Onclick" />
        <asp:Button ID="ResetButton" runat="server" Text="Reset"  Visible="false" />
        <asp:Label ID="Response" runat="server" Text="Label" Visible="false"></asp:Label>  
             
    </div>      
    </form>
</body>
</html>
