using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace com.jajago.SA
{
    public partial class FrmSplash : Form
    {
        private static Thread _splashLauncher;
        private static FrmSplash _splashScreen;

        public FrmSplash()
        {
            InitializeComponent();
        }

        public static void ShowSplash()
        {
            _splashLauncher = new Thread(new ThreadStart(LaunchSplash));
            _splashLauncher.IsBackground = true;
            _splashLauncher.Start();
        }

        private static void LaunchSplash()
        {
            _splashScreen = new FrmSplash();
            Application.Run(_splashScreen);  //Create new message pump
        }

        private static void CloseSplashDown()
        {
            Application.ExitThread();
        }

        public static void CloseSplash()
        {
            // need to get the thread that launched the form, use invoke
            MethodInvoker mi = new MethodInvoker(CloseSplashDown);
            _splashScreen.Invoke(mi);
        }

    }
}
