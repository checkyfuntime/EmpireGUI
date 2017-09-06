using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmpireGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //frmMain mainForm = new EmpireGUI.frmMain();
            //mainForm.Show();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
