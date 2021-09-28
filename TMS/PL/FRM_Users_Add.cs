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
    public partial class FRM_Users_Add : Form
    {

        // Main var
        DBTMSEntities db;
        TB_Users add;
        public int id;
       
        public FRM_Users_Add()
        {
            InitializeComponent();
        }


        // Save Data Event
        private  void btn_save_Click(object sender, EventArgs e)
        {
            // Check Filed
            if(edt_fullname.Text==""|| edt_username.Text == ""|| edt_password.Text == ""|| edt_role.SelectedItem == null)
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                // check dublicated data
                try
                {
                    db = new DBTMSEntities();
                    add = new TB_Users();

                    var data = db.TB_Users.Where(x => x.UserName == edt_username.Text).FirstOrDefault();

                    if (data != null)
                    {
                        // Dublicat data
                        MessageBox.Show("البيانات مكررة , لايمكن اجراء العملية");
                    }
                    else
                    {
                        // Add or Edit
                        // Check if Add or Edit
                        if (id == 0)
                        {
                            // Add
                            AddData();
                            Close();


                        }
                        else
                        {
                            // Edit
                            EditData();
                            Close();

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
                add = new TB_Users();

                add.FullName = edt_fullname.Text;
                add.UserName = edt_username.Text;
                add.Password = edt_password.Text;
                add.Role = edt_role.SelectedItem.ToString();
                add.State = "Off";
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
                add = new TB_Users();
                add.ID = id;
                add.FullName = edt_fullname.Text;
                add.UserName = edt_username.Text;
                add.Password = edt_password.Text;
                add.Role = edt_role.SelectedItem.ToString();
                add.State = add.State;
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("fa204823-6bd3-49bf-bbbb-056422462dc6");

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }
    }
}
