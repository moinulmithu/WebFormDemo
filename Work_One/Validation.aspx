<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="Work_One.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Enter a number from 1 to 100:
                <asp:TextBox ID="tbox1" runat="server" />
                <br />
                <br />
                <asp:Button Text="Submit" runat="server" />
            </p>
            <p>
               <asp:RangeValidator ControlToValidate="tbox1" MinimumValue="1" MaximumValue="100" Type="Integer" Text="The value must be from 1 to 100!" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
