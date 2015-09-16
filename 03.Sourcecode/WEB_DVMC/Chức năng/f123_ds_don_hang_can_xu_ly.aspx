<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="f123_ds_don_hang_can_xu_ly.aspx.cs" Inherits="WEB_DVMC.Chuc_Nang.f123_ds_don_hang_can_xu_ly" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        
        <dx:ASPxGridView ID="f123_ds_don_hang_can_xu_ly_new" runat="server">        
                     <Columns>                          
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="0" Caption="Loại dịch vụ" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="1" Caption="Nhóm dịch vụ" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="2" Caption="Dịch vụ" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="3" Caption="Mã đơn hàng" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="4" Caption="Nhân viên đặt hàng" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="5" Caption="Nhân viên chờ tiếp nhận" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="6" Caption="Thời gian tạo" Width="70px"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="7" Caption="Thời gian hoàn thành" Width="70px"></dx:GridViewDataTextColumn>
                    </Columns>
        </dx:ASPxGridView>
        
    </div>
</asp:Content>
