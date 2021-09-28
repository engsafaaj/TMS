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
    public partial class FRM_Projects_Add : Form
    {

        // Main var
        DBTMSEntities db;
        TB_Projects add;
        public int id;
       
        public FRM_Projects_Add()
        {
            InitializeComponent();
        }


        // Save Data Event
        private  void btn_save_Click(object sender, EventArgs e)
        {
            // Check Filed
            if(edt_name.Text=="")
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                // check dublicated data
                try
                {
                    db = new DBTMSEntities();

                    var data = db.TB_Projects.Where(x => x.ProjectName == edt_name.Text).FirstOrDefault();

                    
                        // Add or Edit
                        // Check if Add or Edit
                        if (id == 0 )
                        {
                        if (data == null)
                        {
                            // Add
                            AddData();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("البيانات مكررة , لايمكن اجراء العملية");

                        }

                    }
                      

                        if (id>0)
                        {
                        var data1 = db.TB_Projects.Where(x => x.ProjectName == edt_name.Text && x.ID!=id).FirstOrDefault();

                        // Edit
                        if (data1 == null)
                        {
                            EditData();
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
                add = new TB_Projects();

                add.ProjectName = edt_name.Text;
                add.ProjectDes = edt_des.Text;                
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
                add = new TB_Projects();

                add.ID = id;
                add.ProjectName = edt_name.Text;
                add.ProjectDes = edt_des.Text;
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
