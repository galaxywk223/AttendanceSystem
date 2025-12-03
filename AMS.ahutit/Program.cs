using Models;
using Models.ahutit;
namespace AMS.ahutit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //显示登录窗体
            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();

            //判断是否登录成功
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }


            //Application.Run(new FrmMain());
        }

        //声明用户信息的全局变量
        public static SysAdmin currentAdmin=null; 

    }
}