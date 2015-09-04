using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREDS;
using DevExpress.XtraScheduler;

namespace TOSApp.ChucNang
{
    public partial class f150_Bo_time_line : Form
    {
        public f150_Bo_time_line()
        {
            load_data_to_grid();
            InitializeComponent();
            Mapping();
        }

        private void Mapping()
        {
            throw new NotImplementedException();
        }

        private void load_data_to_grid()
        {

            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
           
            DataSet v_ds_appointment = new DataSet();
            v_ds_appointment.Tables.Add(new DataTable());

            DataSet v_ds_resource = new DataSet();
            v_ds_resource.Tables.Add(new DataTable());

            v_us.FillDatasetWithQuery(v_ds_resource,"");

            schedulerStorage.Appointments.DataSource = v_ds_appointment.Tables[0];
            schedulerStorage.Resources.DataSource = v_ds_resource.Tables[0];
        }

        private void f150_Bo_time_line_Load(object sender, EventArgs e)
        {
           

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
           
        }
    }
}