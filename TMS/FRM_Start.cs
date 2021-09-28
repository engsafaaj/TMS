using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace TMS
{
    public partial class FRM_Start : SplashScreen
    {
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2021-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(3000));
           var State= await Task.Run(() => CheckConn());

            if (State == true)
            {
                PL.FRM_Users_Login frm_login = new PL.FRM_Users_Login();
                frm_login.Show();
            }
            else
            {
                MessageBox.Show("خطأ في الاتصال في السيرفر , تحقق من الاتصال وحال مره اخرى");
                Application.Exit();

            }
        }

        private bool CheckConn()
        {
            try
            {
                DBTMSEntities db = new DBTMSEntities();
                var list = db.TB_Users.ToList();

                if (list != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}