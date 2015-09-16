<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="f122_blacklist.aspx.cs" Inherits="WEB_DVMC.Chuc_Nang.f122_blacklist" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <div>
        <dx:ASPxGridView ID="f122_black_list" runat="server">
            <Columns>        
              <dx:GridViewDataTextColumn FieldName="" VisibleIndex="0" Caption="Số điện thoại" Width="70px"></dx:GridViewDataTextColumn>
               <dx:GridViewDataTextColumn FieldName="" VisibleIndex="1" Caption="Họ tên chủ điện thoại" Width="70px"></dx:GridViewDataTextColumn>
               <dx:GridViewDataTextColumn FieldName="" VisibleIndex="2" Caption="Ngày add" Width="70px"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="" VisibleIndex="3" Caption="Ghi chú lý do" Width="70px"></dx:GridViewDataTextColumn>
             </Columns>                      
        </dx:ASPxGridView>
      </div>
    <div>
         <asp:Button  ID="m_cmd_them" runat="server" CssClass="btn" Text="Thêm"/>
                 <asp:Button ID="m_cmd_xoa" runat="server" CssClass="btn" Text="Xóa"/>
    </div>
</div>
</asp:Content>
