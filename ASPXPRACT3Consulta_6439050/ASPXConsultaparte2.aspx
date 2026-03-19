<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPXConsultaparte2.aspx.cs" Inherits="ASPXPRACT3Consulta_6439050.ASPXConsultaparte2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Confirm Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Confirm Product</h2>

            Category 
            <asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem>Footwear - Men's</asp:ListItem>
            </asp:DropDownList>
            <br />

            Supplier 
            <asp:DropDownList ID="ddlSupplier" runat="server">
                <asp:ListItem>Adidas</asp:ListItem>
            </asp:DropDownList>
            <br />

            Product 
            <asp:Label ID="lblProduct" runat="server"></asp:Label>
            <br />

            Description 
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="3" ReadOnly="true"></asp:TextBox>
            <br />

            Image 
            <asp:Label ID="lblImage" runat="server"></asp:Label>
            <br />

            Price 
            <asp:Label ID="lblPrice" runat="server"></asp:Label>
            <br />

            Number in Stock 
            <asp:Label ID="lblNumberInStock" runat="server"></asp:Label> 
            (Value : <asp:Label ID="lblValueInStock" runat="server"></asp:Label>)
            <br />

            Number on Order 
            <asp:Label ID="lblNumberOnOrder" runat="server"></asp:Label> 
            (Value : <asp:Label ID="lblValueOnOrder" runat="server"></asp:Label>)
            <br />

            Reorder Level 
            <asp:Label ID="lblReorderLevel" runat="server"></asp:Label>
            <br />

            <asp:Button ID="btnSave" runat="server" Text="Save" />
            <asp:Button ID="btnBack" runat="server" Text="Back" PostBackUrl="AspxConsulta.aspx" />
        </div>
    </form>
</body>
</html>
