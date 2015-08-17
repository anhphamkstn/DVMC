namespace HT_DVMC
{
    partial class f000_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_id = new System.Windows.Forms.TextBox();
            this.m_txt_pass = new System.Windows.Forms.TextBox();
            this.m_lab_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dịch vụ một cửa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên truy cập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // m_txt_id
            // 
            this.m_txt_id.Location = new System.Drawing.Point(173, 82);
            this.m_txt_id.Name = "m_txt_id";
            this.m_txt_id.Size = new System.Drawing.Size(163, 20);
            this.m_txt_id.TabIndex = 6;
            // 
            // m_txt_pass
            // 
            this.m_txt_pass.Location = new System.Drawing.Point(173, 121);
            this.m_txt_pass.Name = "m_txt_pass";
            this.m_txt_pass.Size = new System.Drawing.Size(163, 20);
            this.m_txt_pass.TabIndex = 6;
            // 
            // m_lab_error
            // 
            this.m_lab_error.AutoSize = true;
            this.m_lab_error.ForeColor = System.Drawing.Color.Red;
            this.m_lab_error.Location = new System.Drawing.Point(105, 160);
            this.m_lab_error.Name = "m_lab_error";
            this.m_lab_error.Size = new System.Drawing.Size(10, 14);
            this.m_lab_error.TabIndex = 7;
            this.m_lab_error.Text = " ";
            // 
            // f000_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.m_lab_error);
            this.Controls.Add(this.m_txt_pass);
            this.Controls.Add(this.m_txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "f000_login";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_id;
        private System.Windows.Forms.TextBox m_txt_pass;
        private System.Windows.Forms.Label m_lab_error;

    }
}

