<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="Work_One.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Asp.net</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <h1><%Response.Write("Hello World"); %></h1>
            <a href="http://mahedee.net" id="link1" runat="server">Welcome to mahedee.net</a>
            <br />
            <table>
                <tr>
                    <td>Name: </td>
                    <td>
                        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <div>
                <asp:RadioButtonList ID="rbtnCity" runat="server">
                    <asp:ListItem Value="1" Text="Dhaka" />

                    <asp:ListItem Value="2" Text="Chittagong" />
                    <asp:ListItem Value="3" Text="Barisal" />
                    <asp:ListItem Value="4" Text="Rajshahi" />
                </asp:RadioButtonList>
                <hr />
                <asp:RadioButtonList ID="rbtnDynamic" runat="server"></asp:RadioButtonList>
                <hr />
                <asp:RadioButtonList ID="rbtnArrayList" runat="server"></asp:RadioButtonList>
                <hr />
                <asp:RadioButtonList ID="rbtnHashTable" runat="server"></asp:RadioButtonList>
                <hr />
                <asp:RadioButtonList ID="rbtnXml" runat="server"></asp:RadioButtonList>
            </div>

        </div>
    </form>
</body>
</html>
