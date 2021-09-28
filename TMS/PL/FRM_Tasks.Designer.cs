namespace TMS.PL
{
    partial class FRM_Tasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tasks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_done = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTask_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Duration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_done);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 87);
            this.panel1.TabIndex = 0;
            // 
            // btn_done
            // 
            this.btn_done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_done.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Appearance.Options.UseFont = true;
            this.btn_done.Appearance.Options.UseTextOptions = true;
            this.btn_done.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_done.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_done.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_done.ImageOptions.SvgImage")));
            this.btn_done.Location = new System.Drawing.Point(732, 3);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(126, 78);
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "تم";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Appearance.Options.UseTextOptions = true;
            this.btn_update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(600, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 78);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseTextOptions = true;
            this.btn_delete.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(468, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 78);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.Appearance.Options.UseTextOptions = true;
            this.btn_edit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(336, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(126, 78);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseTextOptions = true;
            this.btn_add.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(204, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 78);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(TMS.TB_Tasks);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1062, 465);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTask_Name,
            this.colTask_Des,
            this.colTask_User,
            this.colTask_Project,
            this.colTask_Start,
            this.colTask_End,
            this.colTask_Duration,
            this.colTask_State});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTask_Name
            // 
            this.colTask_Name.Caption = "الفعالية";
            this.colTask_Name.FieldName = "Task_Name";
            this.colTask_Name.MinWidth = 25;
            this.colTask_Name.Name = "colTask_Name";
            this.colTask_Name.OptionsColumn.AllowEdit = false;
            this.colTask_Name.Visible = true;
            this.colTask_Name.VisibleIndex = 0;
            this.colTask_Name.Width = 94;
            // 
            // colTask_Des
            // 
            this.colTask_Des.Caption = "الوصف";
            this.colTask_Des.FieldName = "Task_Des";
            this.colTask_Des.MinWidth = 25;
            this.colTask_Des.Name = "colTask_Des";
            this.colTask_Des.OptionsColumn.AllowEdit = false;
            this.colTask_Des.Visible = true;
            this.colTask_Des.VisibleIndex = 1;
            this.colTask_Des.Width = 94;
            // 
            // colTask_User
            // 
            this.colTask_User.Caption = "المستخدم";
            this.colTask_User.FieldName = "Task_User";
            this.colTask_User.MinWidth = 25;
            this.colTask_User.Name = "colTask_User";
            this.colTask_User.OptionsColumn.AllowEdit = false;
            this.colTask_User.Visible = true;
            this.colTask_User.VisibleIndex = 2;
            this.colTask_User.Width = 94;
            // 
            // colTask_Project
            // 
            this.colTask_Project.Caption = "المشروع";
            this.colTask_Project.FieldName = "Task_Project";
            this.colTask_Project.MinWidth = 25;
            this.colTask_Project.Name = "colTask_Project";
            this.colTask_Project.OptionsColumn.AllowEdit = false;
            this.colTask_Project.Visible = true;
            this.colTask_Project.VisibleIndex = 3;
            this.colTask_Project.Width = 94;
            // 
            // colTask_Start
            // 
            this.colTask_Start.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_Start.AppearanceCell.Options.UseBackColor = true;
            this.colTask_Start.Caption = "بداية";
            this.colTask_Start.FieldName = "Task_Start";
            this.colTask_Start.MinWidth = 25;
            this.colTask_Start.Name = "colTask_Start";
            this.colTask_Start.OptionsColumn.AllowEdit = false;
            this.colTask_Start.Visible = true;
            this.colTask_Start.VisibleIndex = 4;
            this.colTask_Start.Width = 94;
            // 
            // colTask_End
            // 
            this.colTask_End.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_End.AppearanceCell.Options.UseBackColor = true;
            this.colTask_End.Caption = "نهاية";
            this.colTask_End.FieldName = "Task_End";
            this.colTask_End.MinWidth = 25;
            this.colTask_End.Name = "colTask_End";
            this.colTask_End.OptionsColumn.AllowEdit = false;
            this.colTask_End.Visible = true;
            this.colTask_End.VisibleIndex = 5;
            this.colTask_End.Width = 94;
            // 
            // colTask_Duration
            // 
            this.colTask_Duration.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_Duration.AppearanceCell.Options.UseBackColor = true;
            this.colTask_Duration.Caption = "الفترة (يوم)";
            this.colTask_Duration.FieldName = "Task_Duration";
            this.colTask_Duration.MinWidth = 25;
            this.colTask_Duration.Name = "colTask_Duration";
            this.colTask_Duration.OptionsColumn.AllowEdit = false;
            this.colTask_Duration.Visible = true;
            this.colTask_Duration.VisibleIndex = 6;
            this.colTask_Duration.Width = 94;
            // 
            // colTask_State
            // 
            this.colTask_State.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTask_State.AppearanceCell.Options.UseBackColor = true;
            this.colTask_State.Caption = "الحالة";
            this.colTask_State.FieldName = "Task_State";
            this.colTask_State.MinWidth = 25;
            this.colTask_State.Name = "colTask_State";
            this.colTask_State.OptionsColumn.AllowEdit = false;
            this.colTask_State.Visible = true;
            this.colTask_State.VisibleIndex = 7;
            this.colTask_State.Width = 94;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "549bff24-85b3-4218-8246-3c13f18592de";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("9181fc38-5fc5-49c5-be2c-26a9322ad20c", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية الحذف بنجاح", "تمت عملية الحذف بنجاح", "تمت عملية الحذف بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b833ae9e-4135-40ec-b60d-b96a752c2689", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تم اكتمال المهمة", "تم اكتمال المهمة", "تم اكتمال المهمة", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.StateTime;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = Properties.Settings.Default.UpdateData;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FRM_Tasks
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_Tasks";
            this.Size = new System.Drawing.Size(1062, 552);
            this.Load += new System.EventHandler(this.FRM_Users_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.SimpleButton btn_done;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Des;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_User;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Project;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_End;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Duration;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_State;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
