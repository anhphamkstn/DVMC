<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="f0000_gd_dat_hang_gd_log_dat_hang.aspx.cs" Inherits="WEB_DVMC.Chuc_Nang.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #m_div_control_f000 {
            width: 1882px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   <%--<link href="../Styles/m_cmd.css" rel="stylesheet" />--%>
   <link href="../Styles/bootstrap.min.css" rel="stylesheet" />
    <div>
        <div id="m_div_grv_f000">
                <dx:ASPxGridView ID="m_grv_gd_dat_hang_gd_log_dat_hang" runat="server" Width="284px">
                         <Columns>                    
                             <dx:GridViewDataTextColumn FieldName="MA_DON_HANG" VisibleIndex="0" Caption="Mã đơn hàng" Width="70px"></dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn FieldName="HO_TEN_USER_DAT_HANG" VisibleIndex="1" Caption="Họ tên User đặt hàng" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="DON_VI" VisibleIndex="2" Caption="Đơn vị" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="DIEN_THOAI" VisibleIndex="3" Caption="Điện thoại" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="DICH_VU_SU_DUNG" VisibleIndex="4" Caption="Dịch vụ sử dụng" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="NOI_DUNG_DAT_HANG" VisibleIndex="5" Caption="Nội dung đặt hàng" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="THOI_GIAN_TAO" VisibleIndex="6" Caption="Thời gian tạo" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="THOI_GIAN_CAN_HOAN_THANH" VisibleIndex="7" Caption="Thời gian cần hoàn thành" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="THOI_DIEM_CAN_HOAN_THANH" VisibleIndex="8" Caption="Thời điểm cần hoàn thành" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="NGUOI_TAO_DON_HANG" VisibleIndex="9" Caption="Người tạo đơn hàng" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="TEN_CHI_NHANH" VisibleIndex="10" Caption="Tên chi nhánh" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="ID" VisibleIndex="11" Caption="ID log đặt hàng" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="TEN_LOAI_THAO_TAC_LOG" VisibleIndex="12" Caption="Tên thao tác log" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="NGAY_LAP_THAO_TAC" VisibleIndex="13" Caption="ngày lập thao tác log" Width="70px"></dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn FieldName="TEN_NGUOI_TAO_THAO_TAC_LOG" VisibleIndex="14" Caption="người tạo thao tác log" Width="70px"></dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn FieldName="TEN_NGUOI_NHAN_THAO_TAC" VisibleIndex="15" Caption="người nhận thao tác log" Width="70px"></dx:GridViewDataTextColumn>                 
                               <dx:GridViewDataTextColumn FieldName="GHI_CHU" VisibleIndex="16" Caption="Ghi chú" Width="70px"></dx:GridViewDataTextColumn>
                        </Columns>
                </dx:ASPxGridView>
        </div>
       
        <div id="m_div_control_f000">
            
             <div id="BO" style="text-align:right; height: 51px" >
                  <asp:Button  ID="m_cmd_BO_tiep_nhan" runat="server" CssClass="btn" Text="Tiếp nhận"/>
                 <asp:Button ID="m_cmd_BO_tu_choi" runat="server" CssClass="btn" Text="Từ chối"/>
                 <asp:Button ID="m_cmd_BO_cap_nhat_BO" runat="server" CssClass="btn" OnClick="m_cmd_BO_cap_nhat_BO_Click"  Text="Cập nhật"/>
                  <asp:Button ID="m_cmd_BO_hoan_thanh" runat="server" CssClass="btn" Text="Báo hoàn thành"/>
             </div>

             <div id="PM" style="text-align:right; height: 50px">
                  <asp:Button  ID="m_cmd_PM_tiep_nhan" runat="server" CssClass="btn" Text="Tiếp nhận"/>
                 <asp:Button ID="m_cmd_PM_dieu_phoi_cho_BO" runat="server" CssClass="btn" Text="Điều phối cho BO"/>
                 <asp:Button ID="m_cmd_PM_gui_cho_TD" runat="server" CssClass="btn" Text="Gửi cho TD"/>
                  <asp:Button ID="m_cmd_PM_hoan_thanh" runat="server" CssClass="btn" Text="Báo hoàn thành"/>
                 <asp:Button ID="m_cmd_PM_cap_nhat" runat="server" CssClass="btn"  Text="Cập nhật"/>
             </div>

             <div id="TD" style="text-align:right; height: 48px">
                 <asp:Button ID="m_cmd_TD_tiep_nhan" runat="server" CssClass="btn" Text="Tiếp nhận"/>
                 <asp:Button ID="m_cmd_TD_huy_don_hang" runat="server" CssClass="btn" Text="Hủy đơn hàng"/>
                 <asp:Button ID="m_cmd_TD_cap_nhan" runat="server" CssClass="btn" Text="Cập nhật"/>
                 <asp:Button ID="m_cmd_TD_hoan_thanh" runat="server" CssClass="btn" Text="Báo hoàn thành"/>
             </div>
             
         </div>
    </div>
</asp:Content>
