<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TD.aspx.cs" Inherits="WEB_DVMC.Chức_năng.TD1" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 506px">
    <form id="form1" runat="server">
    <div style="height: 90%; width: 100%">
        lưới dữ liệu của TD<br />
    </div>
    <div style="height: 45px">
        
        
        <dx:ASPxButton ID="ASPxButton1" Class="cmd" runat="server" Text="Tiếp nhận xử lý">
        </dx:ASPxButton>
        <dx:ASPxButton ID="ASPxButton2" Class="cmd" runat="server" Text="Hủy đơn hàng">
        </dx:ASPxButton>
       
        
        <dx:ASPxButton ID="ASPxButton3" runat="server" Text="Báo cáo hoàn thành">
        </dx:ASPxButton>
       
        
    </div>
    </form>
</body>
</html>
