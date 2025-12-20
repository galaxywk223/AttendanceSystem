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

            while (true)
            {
                FrmLogin frmLogin = new FrmLogin();
                DialogResult result = frmLogin.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IsLogout = false;
                    if (currentStudent != null)
                    {
                        Application.Run(new FrmStudentMain());
                    }
                    else if (currentAdmin != null)
                    {
                        Application.Run(new FrmMain());
                    }

                    if (!IsLogout)
                    {
                        break;
                    }

                    currentStudent = null;
                    currentAdmin = null;
                }
                else
                {
                    break;
                }
            }
            Application.Exit();
        }

        public static bool IsLogout = false;

        public static SysAdmin? currentAdmin = null;
        public static Student? currentStudent = null;
    }
}
