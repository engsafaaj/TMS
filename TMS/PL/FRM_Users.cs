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
    public partial class FRM_Users : DevExpress.XtraEditors.XtraUserControl
    {

        // Main var

        DBTMSEntities db;
        TB_Users users;
        FRM_Users_Add frm_add;
        public int id;

        public FRM_Users()
        {
            InitializeComponent();
            // Instantiate a new DBContext
            TMS.DBTMSEntities dbContext = new TMS.DBTMSEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
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
                gridControl1.DataSource = db.TB_Users.ToList();
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
             frm_add=new FRM_Users_Add();
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
                    users = new TB_Users();
                    users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    frm_add = new FRM_Users_Add();
                    frm_add.id = id;
                    frm_add.btn_save.Text = "تعديل";

                    frm_add.edt_fullname.Text = users.FullName;
                    frm_add.edt_username.Text = users.UserName;
                    frm_add.edt_password.Text = users.Password;
                    frm_add.edt_role.SelectedItem = users.Role;
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
                        users = new TB_Users();
                        users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
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
    }
}
