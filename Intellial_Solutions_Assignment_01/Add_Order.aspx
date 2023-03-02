<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Order.aspx.cs" Inherits="Intellial_Solutions_Assignment_01.Add_Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Order</h1>
            <p>Customer&nbsp;&nbsp;
                <asp:TextBox ID="txtbox_customer" runat="server" Width="163px"></asp:TextBox>
            </p>
            <p>Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtbox_product" runat="server" Height="16px" Width="164px"></asp:TextBox>
            </p>
            <p>Remarks&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtbox_remarks" runat="server" Height="54px" Width="164px"></asp:TextBox>
            </p>
            <p class="auto-style1">
                <asp:Button ID="btn_placeorder" runat="server" OnClick="btn_placeorder_Click" Text="Place Order" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_cancle" runat="server" Text="Cancle" OnClick="btn_cancle_Click" />
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>
    </form>
</body>
</html>
