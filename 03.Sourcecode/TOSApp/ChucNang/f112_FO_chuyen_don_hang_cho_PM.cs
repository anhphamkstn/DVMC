using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f112_FO_chuyen_don_hang_cho_PM : Form
    {
        public f112_FO_chuyen_don_hang_cho_PM()
        {
            InitializeComponent();
        }

   

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void displayForUpdate(US_GD_DAT_HANG v_us)
        {
            load_data_to_form(v_us);
            this.ShowDialog();

            
        }

        private void load_data_to_form(US_GD_DAT_HANG v_us)
        {
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
          //  WinFormControls.load_data_to_combobox();
            m_txt_gui_kem.Focus();

        }

        private void m_cmd_Ok_Click(object sender, EventArgs e)
        {
            
        }
    }
}
