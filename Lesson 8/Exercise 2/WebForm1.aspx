<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exercise_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator Web Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculator Web Form</h2>
            <label for="txtNum1">Number 1:</label>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>

            <label for="ddlOperation">Operation:</label>
            <asp:DropDownList ID="ddlOperation" runat="server">
                <asp:ListItem Text="Add" Value="Add" />
                <asp:ListItem Text="Subtract" Value="Subtract" />
                <asp:ListItem Text="Multiply" Value="Multiply" />
                <asp:ListItem Text="Divide" Value="Divide" />
            </asp:DropDownList>

            <label for="txtNum2">Number 2:</label>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>

            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>