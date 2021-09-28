using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using TMS.PL;
namespace TMS.PL
{
    public partial class FRM_Tasks : DevExpress.XtraEditors.XtraUserControl
    {

        // Main var

        DBTMSEntities db;
        TB_Tasks users;
        FRM_Task_Add frm_add;
        public int id;

        public FRM_Tasks()
        {
            InitializeComponent();
            // Instantiate a new DBContext

            TMS.DBTMSEntities dbContext = new TMS.DBTMSEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Tasks.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Tasks.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }



        // Update Data Event
        private void btn_update_Click(object sender, EventArgs e)
        {
            UsersDataUpdate();
        }


        public void UsersDataUpdate()
        {
            try
            {
                db = new DBTMSEntities();
                gridControl1.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void FRM_Users_Load(object sender, EventArgs e)
        {
            UsersDataUpdate();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add = new FRM_Task_Add();
            frm_add.id = 0;
            frm_add.btn_save.Text = "اضافة";
            frm_add.Show();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {

                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id == 0)
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها", "خطأ في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    db = new DBTMSEntities();
                    users = new TB_Tasks();
                    users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                 
                    frm_add = new FRM_Task_Add();
                    frm_add.id = id;
                    frm_add.btn_save.Text = "تعديل";



                    frm_add.Show();
                }

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            var rs = MessageBox.Show("هل انت متأكد من هذ الاجراء", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        db = new DBTMSEntities();
                        users = new TB_Tasks();
                        users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("9181fc38-5fc5-49c5-be2c-26a9322ad20c");
                    }

                }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }


        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذ الاجراء", "اجراء اكمال مهمة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية اكمال المهمة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        db = new DBTMSEntities();

                        users = new TB_Tasks();
                        users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        users.ID = id;
                        users.Task_Name = users.Task_Name;
                        users.Task_Admin = users.Task_Admin;
                        users.Task_User = users.Task_User;
                        users.Task_Project = users.Task_Project;
                        users.Task_Des = users.Task_Des;
                        users.Task_Start = users.Task_Start;
                        users.Task_End = users.Task_End;
                        users.Task_Duration = users.Task_Duration;
                        users.Task_State = "مكتمل";

                        db.Entry(users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("b833ae9e-4135-40ec-b60d-b96a752c2689");
                        AddNote();


                    }

                }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }





        private void AddNote()
        {
            try
            {
                db = new DBTMSEntities();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                users = new TB_Tasks();
                users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                TB_Note note = new TB_Note();
                note.Note_Manger = users.Task_Admin;
                note.Note_User = users.Task_User;
                note.Note_Des = "تم اكمال الفعالية  " + users.Task_Name + " من قبل " + users.Task_User + "";

                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                db = new DBTMSEntities();
                TB_Tasks tasks = new TB_Tasks();
                var idlist = db.TB_Tasks.Select(x => x.ID).ToArray();

                for (int i = 0; i < idlist.Length; i++)
                {
                    var id = idlist[i];
                    tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();

                    var start = tasks.Task_Start;
                    var end = DateTime.Now.Date;
                    var date1 = (end - start).Value.Days;

                    tasks.ID = id;
                    tasks.Task_Name = tasks.Task_Name;
                    tasks.Task_Admin = tasks.Task_Admin;
                    tasks.Task_User = tasks.Task_User;
                    tasks.Task_Project = tasks.Task_Project;
                    tasks.Task_Des = tasks.Task_Des;
                    tasks.Task_Start = tasks.Task_Start;
                    tasks.Task_End = tasks.Task_End;
                    tasks.Task_Duration = tasks.Task_Duration;

                    if (date1 == 0 && tasks.Task_State!="مكتمل")
                    {
                        tasks.Task_State = "اليوم";

                        TB_Note note = new TB_Note();
                        note.Note_Manger = tasks.Task_Admin;
                        note.Note_User = tasks.Task_User;
                        note.Note_Des = "الفعالية "+tasks.Task_Name+" تنتهي اليوم";

                        db.Entry(note).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();


                    }
                    else if (date1 == 1 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "غدا";

                    }
                    else if (date1 > 1 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "بعد " + date1.ToString() + " يوم";

                    }
                    else if (date1 < 0 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "غير مكتمل";

                    }

                    db.Entry(tasks).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }

                UsersDataUpdate();

            }
            catch(Exception ex) 
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                db = new DBTMSEntities();
                gridControl1.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {

            }
        }
    }
}
