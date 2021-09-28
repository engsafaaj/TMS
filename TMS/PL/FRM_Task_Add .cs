using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.PL
{
    public partial class FRM_Task_Add : Form
    {

        // Main var
        DBTMSEntities db;
        TB_Tasks add;

       public string TaskStateDate;

        public int id;


        public FRM_Task_Add()
        {
            InitializeComponent();
        }


        // Save Data Event
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Check Filed
            if (edt_taskname.Text == ""|| edt_duration.Text == "" )
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                // check dublicated data
                try
                {
                    db = new DBTMSEntities();

                    var data = db.TB_Tasks.Where(x => x.Task_Name == edt_taskname.Text).FirstOrDefault();

                    
                        // Add or Edit
                        // Check if Add or Edit
                        if (id == 0 )
                        {
                        if (data == null)
                        {
                            // Add
                            AddData();
                            AddNote();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("البيانات مكررة , لايمكن اجراء العملية");

                        }

                    }
                      

                        if (id>0)
                        {
                        var data1 = db.TB_Tasks.Where(x => x.Task_Name == edt_taskname.Text && x.ID!=id).FirstOrDefault();

                        // Edit
                        if (data1 == null)
                        {
                            EditData();
                            EditNote();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("البيانات مكررة , لايمكن اجراء العملية");

                        }


                    }


                   

                }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               




            }
        }

        private  void AddData()
        {
            try
            {
                db = new DBTMSEntities();
                add = new TB_Tasks();
                var iduser = db.TB_Users.Where(x => x.FullName == edt_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                var idproject = db.TB_Projects.Where(x => x.ProjectName == edt_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                add.Task_Name = edt_taskname.Text;
                add.Task_Admin = edt_manger.SelectedItem.ToString();
                add.Task_User = edt_user.SelectedItem.ToString();
                add.Task_Project = edt_project.SelectedItem.ToString();
                add.Task_Des = edt_taskdes.Text;
                add.Task_Start = edt_startdate.Value;
                add.Task_End = edt_enddate.Value;
                add.Task_Duration =Convert.ToInt16( edt_duration.Text);
                add.Task_State = TaskStateDate;
                add.ID_User = iduser;
                add.ID_Project = idproject;

                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("2f7eec50-51da-4186-836b-bce727cd18ac");

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void EditData()
        {
            try
            {
                db = new DBTMSEntities();
                add = new TB_Tasks();
                add.ID = id;
                var iduser = db.TB_Users.Where(x => x.FullName == edt_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                var idproject = db.TB_Projects.Where(x => x.ProjectName == edt_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                add.Task_Name = edt_taskname.Text;
                add.Task_Admin = edt_manger.SelectedItem.ToString();
                add.Task_User = edt_user.SelectedItem.ToString();
                add.Task_Project = edt_project.SelectedItem.ToString();
                add.Task_Des = edt_taskdes.Text;
                add.Task_Start = edt_startdate.Value;
                add.Task_End = edt_enddate.Value;
                add.Task_Duration = Convert.ToInt16(edt_duration.Text);
                add.Task_State = TaskStateDate;
                add.ID_User = iduser;
                add.ID_Project = idproject;

                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("fa204823-6bd3-49bf-bbbb-056422462dc6");

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }


        private void AddNote()
        {
            try
            {
                db = new DBTMSEntities();
                TB_Note note = new TB_Note();
                note.Note_Manger = edt_manger.SelectedItem.ToString();
                note.Note_User = edt_user.SelectedItem.ToString();
                note.Note_Des = "تم اضافة فعالية  "+edt_taskname.Text+" الى "+edt_user.SelectedItem.ToString()+"";

                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void EditNote()
        {
            try
            {
                db = new DBTMSEntities();
                TB_Note note = new TB_Note();
                note.Note_Manger = edt_manger.SelectedItem.ToString();
                note.Note_User = edt_user.SelectedItem.ToString();
                note.Note_Des = "تم تعديل فعالية  " + edt_taskname.Text + " الى " + edt_user.SelectedItem.ToString() + "";

                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void FRM_Task_Add_Activated(object sender, EventArgs e)
        {
            db = new DBTMSEntities();
            edt_manger.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
            edt_user.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
            edt_project.DataSource = db.TB_Projects.Select(x => x.ProjectName).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_Projects_Add fRM_ = new FRM_Projects_Add();
            fRM_.Show();
        }



       private void TaskDateCal()
        {
            var date1 = (edt_enddate.Value - edt_startdate.Value).Days;
            edt_duration.Text = date1.ToString();

            // Set State

            if (date1 == 0)
            {
                TaskStateDate = "اليوم";
            }
            else if (date1 == 1)
            {
                TaskStateDate = "غدا";

            }
            else if (date1 >1)
            {
                TaskStateDate = "بعد "+ date1.ToString()+ " يوم";

            }
            else if (date1 < 1)
            {
                TaskStateDate = "غير مكتمل";

            }

            if (chbox_done.Checked == true)
            {
                TaskStateDate = " مكتمل";

            }


        }

        private void edt_startdate_ValueChanged(object sender, EventArgs e)
        {
            TaskDateCal();
        }

        private void edt_enddate_ValueChanged(object sender, EventArgs e)
        {
            TaskDateCal();
        }

        private void FRM_Task_Add_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Task_Add_Load(object sender, EventArgs e)
        {
           
        }
    }
}
