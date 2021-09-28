using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.PL;
using System.Data.Entity;
namespace TMS
{
    public partial class Main : Form
    {
        // Main init
        FRM_HOME HOME;
        FRM_Users users;
        FRM_Projects _Projects;
        FRM_Tasks tasks;
        TB_Note note;

        DBTMSEntities db;


        public Main()
        {
            InitializeComponent();
            LoadDataNote();
        }



        // Home event
        private void btn_home_Click(object sender, EventArgs e)
        {

            LoadHomePage();

        }


        // Users event
        private void btn_users_Click(object sender, EventArgs e)
        {
            users = new FRM_Users();
            users.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(users);
            // change the state of label
            lb_state.Text = "المستخدمين";

        }

        private void LoadHomePage()
        {
            HOME = new FRM_HOME();
            HOME.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(HOME);
            // change the state of label
            lb_state.Text = "الرئيسة";
        }

        // Form Load 
        private void Main_Load(object sender, EventArgs e)
        {
            LoadHomePage();
            LoadDataNote();
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            _Projects = new FRM_Projects();
            _Projects.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(_Projects);
            // change the state of label
            lb_state.Text = "المشاريع";
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            tasks = new FRM_Tasks();
            tasks.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(tasks);
            // change the state of label
            lb_state.Text = "المهام";
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            
        }

        private void btn_shownot_Click(object sender, EventArgs e)
        {
            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = true;
            transitionManager1.EndTransition();


        }

        private void gridControl1_MouseLeave(object sender, EventArgs e)
        {
            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = false;
            transitionManager1.EndTransition();
            LoadDataNote();
        }

        private void LoadDataNote()
        {
            try
            {
                db = new DBTMSEntities();

                gridControl1.DataSource = db.TB_Note.Where(x => x.Note_User == lb_username.Text || x.Note_Manger == lb_username.Text).ToList();
                var idnumber = db.TB_Note.Where(x => x.Note_User == lb_username.Text || x.Note_Manger == lb_username.Text).Select(x => x.ID).ToList();

                if (idnumber.Count == 0)
                {
                    btn_shownot.Text = "";
                }
                else
                {
                    btn_shownot.Text = idnumber.Count.ToString();

                }
            }
            catch { }


        }

        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
            // get id
            try
            {

                var id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
                if (id == 0)
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    db = new DBTMSEntities();
                    note = new TB_Note();
                    note = db.TB_Note.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(note).State = EntityState.Deleted;
                    db.SaveChanges();
                    LoadDataNote();


                }

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDataNote();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            FRM_Settings _Settings = new FRM_Settings();
            _Settings.Show();
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
