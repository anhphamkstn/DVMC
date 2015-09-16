<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="f122_blacklist_detail.aspx.cs" Inherits="WEB_DVMC.Chuc_Nang.f122_blacklist_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="height: 53px">
            <div style="float:left; height:inherit; width:45%">
                 <asp:Label ID="Label1" runat="server" Width="30%" Height="100%">Số điện thoại:</asp:Label>
                <asp:TextBox runat="server" Height="22px" Width="378px"></asp:TextBox>
            </div>
            <div style="float:right; width:45%">
                <asp:Label ID="Label2" runat="server" Width="30%" Height="100%">Họ và tên:</asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="319px"></asp:TextBox>
            </div>
        </div>
        <div style="height:120px">
             <asp:Label ID="Label3" runat="server" Width="15%" Height="106%">Lý do:</asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="104px" Width="985px" ></asp:TextBox>
        </div>
        
        <div style="float:right">
            <asp:Button runat="server" Text="OK" Width="86px"/>  
            <asp:Button ID="Button1" runat="server" Text="Cancel"/>
        </div>
    </div>
</asp:Content>
