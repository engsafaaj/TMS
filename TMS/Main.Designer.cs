namespace TMS
{
    partial class Main
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.PushFadeTransition pushFadeTransition1 = new DevExpress.Utils.Animation.PushFadeTransition();
            this.colNote_Des = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colNote_User = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNote_Manger = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new DevExpress.XtraEditors.SimpleButton();
            this.btn_task = new DevExpress.XtraEditors.SimpleButton();
            this.btn_project = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.btn_help = new DevExpress.XtraEditors.SimpleButton();
            this.pn_statebar = new System.Windows.Forms.Panel();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_state = new System.Windows.Forms.Label();
            this.btn_shownot = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_statebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNote_Des
            // 
            this.colNote_Des.FieldName = "Note_Des";
            this.colNote_Des.MinWidth = 25;
            this.colNote_Des.Name = "colNote_Des";
            this.colNote_Des.Visible = true;
            this.colNote_Des.VisibleIndex = 0;
            this.colNote_Des.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = typeof(TMS.TB_Note);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 632);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.gridControl1.Visible = false;
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.EmptySpace.BackColor = System.Drawing.SystemColors.Control;
            this.tileView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNote_Des,
            this.colNote_User,
            this.colNote_Manger});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 90);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 51D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            tableSpan1.ColumnSpan = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.BorderColor = System.Drawing.Color.Gray;
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseBorderColor = true;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colNote_Des;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colNote_Des";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
            // 
            // colNote_User
            // 
            this.colNote_User.FieldName = "Note_User";
            this.colNote_User.MinWidth = 25;
            this.colNote_User.Name = "colNote_User";
            this.colNote_User.Visible = true;
            this.colNote_User.VisibleIndex = 1;
            this.colNote_User.Width = 94;
            // 
            // colNote_Manger
            // 
            this.colNote_Manger.FieldName = "Note_Manger";
            this.colNote_Manger.MinWidth = 25;
            this.colNote_Manger.Name = "colNote_Manger";
            this.colNote_Manger.Visible = true;
            this.colNote_Manger.VisibleIndex = 2;
            this.colNote_Manger.Width = 94;
            // 
            // pn_navbar
            // 
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(1062, 80);
            this.pn_navbar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_home);
            this.flowLayoutPanel1.Controls.Add(this.btn_task);
            this.flowLayoutPanel1.Controls.Add(this.btn_project);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Controls.Add(this.btn_help);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1062, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Options.UseFont = true;
            this.btn_home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_home.ImageOptions.SvgImage")));
            this.btn_home.Location = new System.Drawing.Point(849, 8);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 66);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "الرئيسة";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_task
            // 
            this.btn_task.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_task.Appearance.Options.UseFont = true;
            this.btn_task.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_task.ImageOptions.SvgImage")));
            this.btn_task.Location = new System.Drawing.Point(643, 8);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(200, 66);
            this.btn_task.TabIndex = 1;
            this.btn_task.Text = "المهام";
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // btn_project
            // 
            this.btn_project.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_project.Appearance.Options.UseFont = true;
            this.btn_project.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_project.ImageOptions.SvgImage")));
            this.btn_project.Location = new System.Drawing.Point(437, 8);
            this.btn_project.Name = "btn_project";
            this.btn_project.Size = new System.Drawing.Size(200, 66);
            this.btn_project.TabIndex = 2;
            this.btn_project.Text = "المشاريع";
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_users.ImageOptions.SvgImage")));
            this.btn_users.Location = new System.Drawing.Point(231, 8);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(200, 66);
            this.btn_users.TabIndex = 3;
            this.btn_users.Text = "المستخدمين";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_help
            // 
            this.btn_help.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Appearance.Options.UseFont = true;
            this.btn_help.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_help.ImageOptions.SvgImage")));
            this.btn_help.Location = new System.Drawing.Point(25, 8);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(200, 66);
            this.btn_help.TabIndex = 4;
            this.btn_help.Text = "الاعدادات";
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // pn_statebar
            // 
            this.pn_statebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_statebar.Controls.Add(this.lb_role);
            this.pn_statebar.Controls.Add(this.lb_username);
            this.pn_statebar.Controls.Add(this.lb_state);
            this.pn_statebar.Controls.Add(this.btn_shownot);
            this.pn_statebar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_statebar.Location = new System.Drawing.Point(0, 632);
            this.pn_statebar.Name = "pn_statebar";
            this.pn_statebar.Size = new System.Drawing.Size(1062, 41);
            this.pn_statebar.TabIndex = 1;
            // 
            // lb_role
            // 
            this.lb_role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.ForeColor = System.Drawing.Color.White;
            this.lb_role.Location = new System.Drawing.Point(453, 4);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(59, 31);
            this.lb_role.TabIndex = 0;
            this.lb_role.Text = "مدير";
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(539, 4);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(70, 31);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "صفاء ";
            // 
            // lb_state
            // 
            this.lb_state.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_state.ForeColor = System.Drawing.Color.White;
            this.lb_state.Location = new System.Drawing.Point(990, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(72, 41);
            this.lb_state.TabIndex = 0;
            this.lb_state.Text = "مستعد";
            this.lb_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_shownot
            // 
            this.btn_shownot.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shownot.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btn_shownot.Appearance.Options.UseFont = true;
            this.btn_shownot.Appearance.Options.UseForeColor = true;
            this.btn_shownot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_shownot.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_shownot.ImageOptions.SvgImage")));
            this.btn_shownot.Location = new System.Drawing.Point(0, 0);
            this.btn_shownot.Name = "btn_shownot";
            this.btn_shownot.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_shownot.Size = new System.Drawing.Size(81, 41);
            this.btn_shownot.TabIndex = 4;
            this.btn_shownot.Text = "12";
            this.btn_shownot.Click += new System.EventHandler(this.btn_shownot_Click);
            // 
            // pn_cont
            // 
            this.pn_cont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Location = new System.Drawing.Point(0, 80);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(1062, 553);
            this.pn_cont.TabIndex = 2;
            // 
            // transitionManager1
            // 
            this.transitionManager1.FrameInterval = 3000;
            this.transitionManager1.ShowWaitingIndicator = false;
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = this.gridControl1;
            transition1.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition1.TransitionType = pushFadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.GetNotTimer;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pn_statebar);
            this.Controls.Add(this.pn_navbar);
            this.Controls.Add(this.pn_cont);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_statebar.ResumeLayout(false);
            this.pn_statebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_statebar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_home;
        private DevExpress.XtraEditors.SimpleButton btn_task;
        private DevExpress.XtraEditors.SimpleButton btn_project;
        private DevExpress.XtraEditors.SimpleButton btn_help;
        private System.Windows.Forms.Label lb_state;
        private DevExpress.XtraEditors.SimpleButton btn_shownot;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_Des;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_User;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_Manger;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.SimpleButton btn_users;
        public System.Windows.Forms.Label lb_role;
        public System.Windows.Forms.Label lb_username;
    }
}

