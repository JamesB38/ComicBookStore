<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="Stock ID" width="106px"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStockAvailability" runat="server" Text="Stock Availability"></asp:Label>
            <asp:TextBox ID="txtStockAvailability" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStockDescription" runat="server" Text="StockDescription" width="106px"></asp:Label>
            <asp:TextBox ID="txtStockDescription" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStockPrice" runat="server" Text="StockPrice" width="106px"></asp:Label>
            <asp:TextBox ID="txtStockPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkIsBeingRestocked" runat="server" Text="Is Being Restocked" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
