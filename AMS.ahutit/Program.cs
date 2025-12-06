using Models;
using Models.ahutit;

namespace AMS.ahutit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (currentStudent != null)
                {
                    Application.Run(new FrmStudentMain());
                }
                else if (currentAdmin != null)
                {
                    Application.Run(new FrmMain());
                }
            }
            else
            {
                Application.Exit();
            }
        }

        public static SysAdmin currentAdmin = null;
        public static Student? currentStudent = null;
    }
}
