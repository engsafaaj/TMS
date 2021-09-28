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

namespace TMS.PL
{
    public partial class FRM_HOME : DevExpress.XtraEditors.XtraUserControl
    {
        DBTMSEntities db = new DBTMSEntities();
        public FRM_HOME()
        {
            InitializeComponent();
        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            LoadDoneTask();
        }

        private void LoadDoneTask()
        {
            try
            {
                db = new DBTMSEntities();
                var Tasklist = db.TB_Tasks.Where(x => x.Task_State == "اليوم").Select(x => x.ID).ToList();
                lb_tasksdone.Text = Tasklist.Count.ToString();
            }
            catch { }
           
        }
    }
}
