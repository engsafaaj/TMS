namespace TMS.PL
{
    partial class FRM_Task_Add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Task_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.edt_taskname = new System.Windows.Forms.TextBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_project = new System.Windows.Forms.ComboBox();
            this.edt_user = new System.Windows.Forms.ComboBox();
            this.edt_manger = new System.Windows.Forms.ComboBox();
            this.edt_taskdes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbox_done = new System.Windows.Forms.CheckBox();
            this.edt_enddate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_startdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_duration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(361, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الفعالية";
            // 
            // edt_taskname
            // 
            this.edt_taskname.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_taskname.Location = new System.Drawing.Point(23, 83);
            this.edt_taskname.Name = "edt_taskname";
            this.edt_taskname.Size = new System.Drawing.Size(451, 33);
            this.edt_taskname.TabIndex = 2;
            this.edt_taskname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(0, 617);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(1107, 61);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "549bff24-85b3-4218-8246-3c13f18592de";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("2f7eec50-51da-4186-836b-bce727cd18ac", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("fa204823-6bd3-49bf-bbbb-056422462dc6", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edt_project);
            this.groupBox1.Controls.Add(this.edt_user);
            this.groupBox1.Controls.Add(this.edt_manger);
            this.groupBox1.Controls.Add(this.edt_taskdes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edt_taskname);
            this.groupBox1.Location = new System.Drawing.Point(572, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(494, 584);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عــــام";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(21, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 22);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_project
            // 
            this.edt_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_project.FormattingEnabled = true;
            this.edt_project.Location = new System.Drawing.Point(23, 371);
            this.edt_project.Name = "edt_project";
            this.edt_project.Size = new System.Drawing.Size(451, 34);
            this.edt_project.TabIndex = 4;
            // 
            // edt_user
            // 
            this.edt_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_user.FormattingEnabled = true;
            this.edt_user.Location = new System.Drawing.Point(23, 272);
            this.edt_user.Name = "edt_user";
            this.edt_user.Size = new System.Drawing.Size(451, 34);
            this.edt_user.TabIndex = 4;
            // 
            // edt_manger
            // 
            this.edt_manger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_manger.FormattingEnabled = true;
            this.edt_manger.Location = new System.Drawing.Point(23, 177);
            this.edt_manger.Name = "edt_manger";
            this.edt_manger.Size = new System.Drawing.Size(451, 34);
            this.edt_manger.TabIndex = 4;
            // 
            // edt_taskdes
            // 
            this.edt_taskdes.Location = new System.Drawing.Point(23, 463);
            this.edt_taskdes.Name = "edt_taskdes";
            this.edt_taskdes.Size = new System.Drawing.Size(451, 110);
            this.edt_taskdes.TabIndex = 3;
            this.edt_taskdes.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(350, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "وصف الفعالية";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(352, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "اسم المشروع";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(381, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "المستخدم";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(417, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "المدير";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbox_done);
            this.groupBox2.Controls.Add(this.edt_enddate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.edt_startdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.edt_duration);
            this.groupBox2.Location = new System.Drawing.Point(39, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(494, 573);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الوقــــــــــــــت";
            // 
            // chbox_done
            // 
            this.chbox_done.AutoSize = true;
            this.chbox_done.Font = new System.Drawing.Font("LBC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_done.Location = new System.Drawing.Point(30, 292);
            this.chbox_done.Name = "chbox_done";
            this.chbox_done.Size = new System.Drawing.Size(114, 39);
            this.chbox_done.TabIndex = 4;
            this.chbox_done.Text = "مكتمل";
            this.chbox_done.UseVisualStyleBackColor = true;
            // 
            // edt_enddate
            // 
            this.edt_enddate.Location = new System.Drawing.Point(6, 177);
            this.edt_enddate.Name = "edt_enddate";
            this.edt_enddate.Size = new System.Drawing.Size(452, 33);
            this.edt_enddate.TabIndex = 3;
            this.edt_enddate.ValueChanged += new System.EventHandler(this.edt_enddate_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(20, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 43);
            this.label9.TabIndex = 1;
            this.label9.Text = "يوم";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(210, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 43);
            this.label8.TabIndex = 1;
            this.label8.Text = "المدة";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(340, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "نهاية الفعالية";
            // 
            // edt_startdate
            // 
            this.edt_startdate.Location = new System.Drawing.Point(6, 81);
            this.edt_startdate.Name = "edt_startdate";
            this.edt_startdate.Size = new System.Drawing.Size(452, 33);
            this.edt_startdate.TabIndex = 3;
            this.edt_startdate.ValueChanged += new System.EventHandler(this.edt_startdate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(340, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "بداية الفعالية";
            // 
            // edt_duration
            // 
            this.edt_duration.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_duration.Location = new System.Drawing.Point(122, 358);
            this.edt_duration.Name = "edt_duration";
            this.edt_duration.ReadOnly = true;
            this.edt_duration.Size = new System.Drawing.Size(266, 50);
            this.edt_duration.TabIndex = 2;
            this.edt_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_Task_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Task_Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_Task_Add_Activated);
            this.Load += new System.EventHandler(this.FRM_Task_Add_Load);
            this.Enter += new System.EventHandler(this.FRM_Task_Add_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public System.Windows.Forms.TextBox edt_taskname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbox_done;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_duration;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.RichTextBox edt_taskdes;
        public System.Windows.Forms.DateTimePicker edt_enddate;
        public System.Windows.Forms.DateTimePicker edt_startdate;
        public System.Windows.Forms.ComboBox edt_project;
        public System.Windows.Forms.ComboBox edt_user;
        public System.Windows.Forms.ComboBox edt_manger;
    }
}