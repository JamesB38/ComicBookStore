<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="chkEmailSub">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" height="24px" Text="Customer ID" width="88px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" Height="16px" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerFN" runat="server" height="20px" Text="Full Name" width="93px"></asp:Label>
            <asp:TextBox ID="txtCustomerFN" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerDOB" runat="server" height="25px" Text="Date of Birth" width="88px"></asp:Label>
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerPNo" runat="server" height="38px" Text="Phone Number" width="94px"></asp:Label>
            <asp:TextBox ID="txtCustomerPNo" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmailSub" runat="server" Text="Email Subscription " width="113px"></asp:Label>
            <asp:CheckBox ID="chkEmailSubYes" runat="server" Text="Yes" width="128px" />
            <asp:CheckBox ID="chkEmailSubNo" runat="server" Text="No" width="128px" />
        </p>
        <asp:Label ID="lblError" runat="server" height="20px" Text="lblError" width="66px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="45px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
