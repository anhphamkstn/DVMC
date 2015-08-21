<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PM.aspx.cs" Inherits="WEB_DVMC.Chức_năng.TM" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="bootraps/css/bootraps.min" rel="stylesheet"/>

</head>
<body style="height: 497px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <div style="height: 418px">
            <dx:ASPxGridView ID="ASPxGridView1" runat="server">
            </dx:ASPxGridView>
        </div>
        <div style="height: 51px">
            <dx:ASPxButton ID="ASPxButton1" Class="cmd" runat="server" Text="Tiếp nhận xử lý">
            </dx:ASPxButton>
            <dx:ASPxButton ID="ASPxButton2" Class="cmd" runat="server" Text="Chuyển lên TD">
            </dx:ASPxButton>
            <dx:ASPxButton ID="ASPxButton3" Class="cmd" runat="server" Text="Điều phối lại">
            </dx:ASPxButton>
        </div>
    </form>
</body>
</html>
