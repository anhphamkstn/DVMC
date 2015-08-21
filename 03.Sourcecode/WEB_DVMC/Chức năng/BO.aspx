<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BO.aspx.cs" Inherits="WEB_DVMC.Chức_năng.TD" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href=""
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Giao diện là việc của BO

    </div>

        <div style="height: 424px">
            <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="Youthful" Width=100% >
               

            </dx:ASPxGridView>

        </div>

        <div style="height: 43px">
            <dx:ASPxButton ID="m_cmd_BO_tiep_nhan" class="cmd" runat="server" Height="35px" Text="Tiếp nhận đơn hàng" Width="192px">
            </dx:ASPxButton>
            <dx:ASPxButton ID="m_cmd_BO_tu_choi" Class="cmd" runat="server" Height="35px" Text="Từ chối đơn hàng" Width="193px">
            </dx:ASPxButton>
            <dx:ASPxButton ID="m_cmd_BO_bao_cao_hoan_thanh" Class="cmd" runat="server" Height="35px" Text="Báo cáo hoàn thành" Width="193px">
            </dx:ASPxButton>
        </div>
    </form>
    </body>
</html>
