using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPData.DBNames;
using IP.Core.IPSystemAdmin;
using IPCOREDS;
using IPCOREDS.CDBNames;
using IPCOREUS;
using TOSApp.App_Code;

namespace TOSApp
{
	/// <summary>
	/// Summary description for f998_ht_nguoi_su_dung_de.
	/// </summary>
	public class f998_ht_nguoi_su_dung_de : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal System.Windows.Forms.ImageList ImageList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox m_txt_ten_truy_cap;
		private System.Windows.Forms.TextBox m_txt_ten;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox m_txt_mat_khau;
		private System.Windows.Forms.TextBox m_txt_go_lai_mat_khau;
		private System.Windows.Forms.ComboBox m_cbo_trang_thai;
		private System.Windows.Forms.CheckBox m_chk_is_admin;
		internal SIS.Controls.Button.SiSButton m_cmd_save;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
        private Label label10;
        private ComboBox m_cbo_nhom_quyen;
        private Label label11;
        private TextBox m_txt_email;
        private Label label12;
        private TextBox m_txt_password_email;
        private CheckBox m_chk_is_type_in_mail;
		private System.ComponentModel.IContainer components;

		public f998_ht_nguoi_su_dung_de()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f998_ht_nguoi_su_dung_de));
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_ten_truy_cap = new System.Windows.Forms.TextBox();
            this.m_txt_ten = new System.Windows.Forms.TextBox();
            this.m_txt_mat_khau = new System.Windows.Forms.TextBox();
            this.m_txt_go_lai_mat_khau = new System.Windows.Forms.TextBox();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_chk_is_admin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_chk_is_type_in_mail = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.m_txt_email = new System.Windows.Forms.TextBox();
            this.m_txt_password_email = new System.Windows.Forms.TextBox();
            this.m_cbo_nhom_quyen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 244);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(464, 36);
            this.m_pnl_out_place_dm.TabIndex = 1;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(284, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "&Lưu";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(372, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên truy cập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trạng thái";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(251, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Có quyền Admin?";
            // 
            // m_txt_ten_truy_cap
            // 
            this.m_txt_ten_truy_cap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ten_truy_cap.Location = new System.Drawing.Point(147, 24);
            this.m_txt_ten_truy_cap.Name = "m_txt_ten_truy_cap";
            this.m_txt_ten_truy_cap.Size = new System.Drawing.Size(152, 20);
            this.m_txt_ten_truy_cap.TabIndex = 0;
            // 
            // m_txt_ten
            // 
            this.m_txt_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ten.Location = new System.Drawing.Point(147, 48);
            this.m_txt_ten.Name = "m_txt_ten";
            this.m_txt_ten.Size = new System.Drawing.Size(224, 20);
            this.m_txt_ten.TabIndex = 1;
            // 
            // m_txt_mat_khau
            // 
            this.m_txt_mat_khau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_mat_khau.Location = new System.Drawing.Point(147, 72);
            this.m_txt_mat_khau.Name = "m_txt_mat_khau";
            this.m_txt_mat_khau.PasswordChar = '*';
            this.m_txt_mat_khau.Size = new System.Drawing.Size(120, 20);
            this.m_txt_mat_khau.TabIndex = 2;
            // 
            // m_txt_go_lai_mat_khau
            // 
            this.m_txt_go_lai_mat_khau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_go_lai_mat_khau.Location = new System.Drawing.Point(147, 96);
            this.m_txt_go_lai_mat_khau.Name = "m_txt_go_lai_mat_khau";
            this.m_txt_go_lai_mat_khau.PasswordChar = '*';
            this.m_txt_go_lai_mat_khau.Size = new System.Drawing.Size(120, 20);
            this.m_txt_go_lai_mat_khau.TabIndex = 3;
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trang_thai.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Đã đóng"});
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(147, 120);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(96, 21);
            this.m_cbo_trang_thai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gõ lại mật khẩu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_chk_is_admin
            // 
            this.m_chk_is_admin.Location = new System.Drawing.Point(347, 124);
            this.m_chk_is_admin.Name = "m_chk_is_admin";
            this.m_chk_is_admin.Size = new System.Drawing.Size(60, 20);
            this.m_chk_is_admin.TabIndex = 5;
            this.m_chk_is_admin.Text = "Không";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_chk_is_type_in_mail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.m_chk_is_admin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_txt_email);
            this.groupBox1.Controls.Add(this.m_txt_ten_truy_cap);
            this.groupBox1.Controls.Add(this.m_txt_ten);
            this.groupBox1.Controls.Add(this.m_txt_password_email);
            this.groupBox1.Controls.Add(this.m_txt_mat_khau);
            this.groupBox1.Controls.Add(this.m_txt_go_lai_mat_khau);
            this.groupBox1.Controls.Add(this.m_cbo_nhom_quyen);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.m_cbo_trang_thai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người sử dụng";
            // 
            // m_chk_is_type_in_mail
            // 
            this.m_chk_is_type_in_mail.Location = new System.Drawing.Point(312, 180);
            this.m_chk_is_type_in_mail.Name = "m_chk_is_type_in_mail";
            this.m_chk_is_type_in_mail.Size = new System.Drawing.Size(122, 20);
            this.m_chk_is_type_in_mail.TabIndex = 7;
            this.m_chk_is_type_in_mail.Text = "Nhập vào email?";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(124, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "(*)";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(124, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "(*)";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(124, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "(*)";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nhóm quyền";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_txt_email
            // 
            this.m_txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_email.Location = new System.Drawing.Point(147, 180);
            this.m_txt_email.Name = "m_txt_email";
            this.m_txt_email.Size = new System.Drawing.Size(152, 20);
            this.m_txt_email.TabIndex = 8;
            // 
            // m_txt_password_email
            // 
            this.m_txt_password_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_password_email.Location = new System.Drawing.Point(147, 206);
            this.m_txt_password_email.Name = "m_txt_password_email";
            this.m_txt_password_email.PasswordChar = '*';
            this.m_txt_password_email.Size = new System.Drawing.Size(152, 20);
            this.m_txt_password_email.TabIndex = 9;
            // 
            // m_cbo_nhom_quyen
            // 
            this.m_cbo_nhom_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhom_quyen.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Đã đóng"});
            this.m_cbo_nhom_quyen.Location = new System.Drawing.Point(147, 147);
            this.m_cbo_nhom_quyen.Name = "m_cbo_nhom_quyen";
            this.m_cbo_nhom_quyen.Size = new System.Drawing.Size(224, 21);
            this.m_cbo_nhom_quyen.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Mật khẩu Email";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // f998_ht_nguoi_su_dung_de
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(464, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f998_ht_nguoi_su_dung_de";
            this.Text = "F998 - cap nhat thong tin nguoi su dung";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		#region Public Interface
		public void insert_new_user(){
			m_e_form_mode = DataEntryFormMode.InsertDataState;
			this.ShowDialog();
		}
		public void update_new_user(US_HT_NGUOI_SU_DUNG i_us_user){
			m_e_form_mode = DataEntryFormMode.UpdateDataState;
			m_us_user = i_us_user;
			this.ShowDialog();

		}
        public void change_password(US_HT_NGUOI_SU_DUNG i_us_user
                                    , string ip_str_change_password_yn
                                    , params string[] ip_str_type_in_email_yn)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_user = i_us_user;
            // Nếu đây là đổi mật khẩu
            if (ip_str_change_password_yn.Equals("Y"))
            {
                m_txt_ten_truy_cap.Enabled = false;
                m_chk_is_admin.Enabled = false;
                m_cbo_trang_thai.Enabled = false;
                m_cbo_nhom_quyen.Enabled = false;
            }
            if (ip_str_type_in_email_yn.Length > 0)
            {
                if (ip_str_type_in_email_yn[0] == "Y")
                {
                    m_chk_is_type_in_mail.Checked = true;
                    m_txt_email.Enabled = true;
                    m_txt_password_email.Enabled = true;
                    m_str_change_email_yn = "Y";
                }
            }
            this.ShowDialog();
        }
		#endregion
		#region Members
		US_HT_NGUOI_SU_DUNG m_us_user = new US_HT_NGUOI_SU_DUNG();
		DataEntryFormMode m_e_form_mode;
        string m_str_change_email_yn = "N";
		#endregion
		#region Data Structures		
		#endregion
		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);		
			m_cbo_trang_thai.SelectedIndex = 0;
            m_txt_email.Enabled = false;
            m_txt_password_email.Enabled = false;
            set_define_events();
		}
        private void load_data_2_cbo_nhom_nguoi_dung()
        {
            US_HT_NHOM_NGUOI_SU_DUNG v_us_nhom_nguoi_dung = new US_HT_NHOM_NGUOI_SU_DUNG();
            DS_HT_NHOM_NGUOI_SU_DUNG v_ds_nhom_nguoi_dung = new DS_HT_NHOM_NGUOI_SU_DUNG();
            v_us_nhom_nguoi_dung.FillDataset(v_ds_nhom_nguoi_dung);
            v_ds_nhom_nguoi_dung.EnforceConstraints = false;

            m_cbo_nhom_quyen.ValueMember = HT_NHOM_NGUOI_SU_DUNG.ID;
            m_cbo_nhom_quyen.DisplayMember = HT_NHOM_NGUOI_SU_DUNG.MA_NHOM;
            m_cbo_nhom_quyen.DataSource = v_ds_nhom_nguoi_dung.HT_NHOM_NGUOI_SU_DUNG;
        }			   
		private void form_2_us_object(){
			m_us_user.strBUILT_IN_YN 
				= CIPConvert.ToYNString(m_chk_is_admin.Checked);
			m_us_user.strTEN_TRUY_CAP = m_txt_ten_truy_cap.Text;
			m_us_user.strTEN = m_txt_ten.Text;
			//m_us_user.strMAT_KHAU = m_txt_mat_khau.Text;
			m_us_user.strMAT_KHAU = CIPConvert.Encoding (m_txt_mat_khau.Text) ;
			m_us_user.strTRANG_THAI  = CIPConvert.ToStr(m_cbo_trang_thai.SelectedIndex);
			m_us_user.strNGUOI_TAO = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUser();
            m_us_user.dcID_NHOM_NGUOI_DUNG = CIPConvert.ToDecimal( m_cbo_nhom_quyen.SelectedValue);
            m_us_user.strEMAIL = m_txt_email.Text.Trim();
            m_us_user.strMAT_KHAU_EMAIL = CEncryptKeyString.EncryptString(m_txt_password_email.Text);
		}
		private void us_object_2_form(){
			m_chk_is_admin.Checked = CIPConvert.ToBoolean(m_us_user.strBUILT_IN_YN);
			if(m_chk_is_admin.Checked)
			{
				m_chk_is_admin.Text = "có";
			}
			else{
				m_chk_is_admin.Text = "Không";
			}
			m_txt_ten_truy_cap.Text= m_us_user.strTEN_TRUY_CAP;
			m_txt_ten.Text= m_us_user.strTEN;
//			m_txt_mat_khau.Text = m_us_user.strMAT_KHAU;
//			m_txt_go_lai_mat_khau.Text = m_us_user.strMAT_KHAU;
			m_txt_mat_khau.Text = CIPConvert.Deciphering ( m_us_user.strMAT_KHAU ) ;
			m_txt_go_lai_mat_khau.Text = CIPConvert.Deciphering ( m_us_user.strMAT_KHAU ) ;
			m_cbo_trang_thai.SelectedIndex = (int)CIPConvert.ToDecimal(m_us_user.strTRANG_THAI);
            m_cbo_nhom_quyen.SelectedValue = m_us_user.dcID_NHOM_NGUOI_DUNG;
            m_txt_email.Text = m_us_user.strEMAIL;
            m_txt_password_email.Text = CEncryptKeyString.DecryptString(m_us_user.strMAT_KHAU_EMAIL);
		}
		private bool check_validate(){
			if (!CValidateTextBox.IsValid(m_txt_ten_truy_cap, DataType.StringType, allowNull.NO, true)) return false;
			if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, true)) return false;
			if (!CValidateTextBox.IsValid(m_txt_mat_khau, DataType.StringType, allowNull.NO, true)) return false;
			if (m_txt_mat_khau.Text != m_txt_go_lai_mat_khau.Text){
				BaseMessages.MsgBox_Infor("Mật khẩu gõ chưa chính xác!");
				return false;
			}
            if (m_chk_is_type_in_mail.Checked)
            {
                if (!CValidateTextBox.IsValid(m_txt_email, DataType.StringType, allowNull.NO, true)) return false;
                if (!CValidateTextBox.IsValid(m_txt_password_email, DataType.StringType, allowNull.NO, true)) return false;
            }
			return true;
		}
		private void save_data(){
			if (!check_validate()) return;
			form_2_us_object();
			switch (m_e_form_mode){
				case DataEntryFormMode.InsertDataState:
					m_us_user.Insert();
					break;
				case DataEntryFormMode.UpdateDataState:
					m_us_user.Update();
					break;
			}
            if (m_chk_is_type_in_mail.Checked)
            {
                try
                {
                    send_mail_test_account();
                    f002_main_form.m_str_email_dvmc = m_us_user.strEMAIL;
                    f002_main_form.m_str_password_dvmc = m_us_user.strMAT_KHAU_EMAIL;
                    BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
                    this.Close();
                }
                catch (Exception v_e)
                {
                    BaseMessages.MsgBox_Error("Thông tin địa chỉ email và mật khẩu bạn vừa nhập chưa chính xác. Hãy kiểm tra lại");
                }
            }
            else
            {
                BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
                this.Close();
            }
		}
        private void send_mail_test_account()
        {
            string v_str_acc = m_txt_email.Text.Trim();
            string v_str_password_email = m_txt_password_email.Text;
            string v_str_subject = "[Tổng đài QLHT] - Gửi mail test account tổng đài viên";
            string v_str_content = "<p>Chào bạn, </p>";
            v_str_content += "<p>Bạn đang cập nhật thông tin email trong hệ thống TOS Ticket.</p>";
            v_str_content += "<p>Hệ thống tự động gửi email để thông báo thông tin email bạn vừa cập nhật đã thành công! </p>";
            v_str_content += "<p>Chúc bạn một ngày mới vui vẻ! </p>";

            HelpUtils.send_mail(m_txt_ten.Text.Trim()
                                , v_str_acc, v_str_password_email
                                , v_str_acc, "", v_str_subject, v_str_content);
        }
		private void set_define_events(){
		this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
		this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
		this.Load+= new EventHandler(f998_ht_nguoi_su_dung_de_Load);
		this.m_chk_is_admin.Click +=new EventHandler(m_chk_is_admin_Click);
		this.KeyDown +=new KeyEventHandler(f998_ht_nguoi_su_dung_de_KeyDown);
        this.m_chk_is_type_in_mail.Click += new EventHandler(m_chk_is_type_in_mail_Click);
		}
		#endregion
		//
		//
		//
		//
		//
        void m_chk_is_type_in_mail_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_is_admin.Checked)
                {
                    m_txt_email.Enabled = true;
                    m_txt_password_email.Enabled = true;
                }
                else
                {
                    m_txt_email.Enabled = false;
                    m_txt_password_email.Enabled = false;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_save_Click(object sender, EventArgs e) {
			try{
				save_data();
			}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void f998_ht_nguoi_su_dung_de_Load(object sender, EventArgs e) {
			try{
				load_data_2_cbo_nhom_nguoi_dung();
				switch (m_e_form_mode){
					case DataEntryFormMode.InsertDataState:
						
						break;
					case DataEntryFormMode.UpdateDataState:
						us_object_2_form();
						break;
				}
                if (m_str_change_email_yn == "Y") m_txt_email.Focus();
			}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_chk_is_admin_Click(object sender, EventArgs e) {
			try{
				if (m_chk_is_admin.Checked){
					m_chk_is_admin.Text ="Có";
				}else{
					m_chk_is_admin.Text ="Không";
				}
				}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void f998_ht_nguoi_su_dung_de_KeyDown(object sender, KeyEventArgs e)
		{	
			try
			{
				switch (e.KeyCode) 
				{
					case Keys.Escape:
						this.Close();
						break;
					case Keys.S:
						if (e.Control == true)
						{
							switch (m_e_form_mode)
							{
								case DataEntryFormMode.InsertDataState:
									save_data();
									break;
								case DataEntryFormMode.UpdateDataState:
									save_data();
									break;
								case DataEntryFormMode.ViewDataState:
									break;
								case DataEntryFormMode.SelectDataState:
									break;
							}							
						}
						break;
				}
			}
			catch (Exception v_e)
			{
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
	}
}
