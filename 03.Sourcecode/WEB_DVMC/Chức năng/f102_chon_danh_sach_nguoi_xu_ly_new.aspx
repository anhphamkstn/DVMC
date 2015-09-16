<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="f102_chon_danh_sach_nguoi_xu_ly_new.aspx.cs" Inherits="WEB_DVMC.Chức_năng.f102_chon_danh_sach_nguoi_xu_ly_new" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="width:24%; float: left">
           

                <dx:ASPxGridView ID="ASPxGridView1" runat="server" Width="223px">
                   
                     <Columns>
                          <dx:GridViewCommandColumn ButtonType="Default" ShowSelectCheckbox="true" Name="IsChecked" Caption="CHECK" >                                                       
                          </dx:GridViewCommandColumn>
                         <dx:GridViewDataTextColumn FieldName="" VisibleIndex="1" Caption="Họ tên BO" Width="70px"></dx:GridViewDataTextColumn>
                    </Columns>
                </dx:ASPxGridView>

            <div name="control">
                <asp:Button  ID="m_cm_dieu_phoi" runat="server" CssClass="m_cmd" Width="109px" Text="Điều phối"/>
                <asp:Button  ID="m_cmd_thoat" runat="server" CssClass="m_cmd" Width="119px" Text="Thoát"/>
            </div>
        </div>
        <div  style="width:75%; background-color: blue; display:inline-block; float:left" >
            <h1>TimeLine</h1>
        </div>
    </div>
</asp:Content>
