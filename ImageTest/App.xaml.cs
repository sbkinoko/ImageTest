using System.Configuration;
using System.Data;
using System.Windows;

namespace ImageTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        static MainWindow objMainWindow;
        static SubWindow objSubWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            objMainWindow = new MainWindow();
            objSubWindow = new SubWindow();

            objMainWindow.Show();
            objSubWindow.Show();
        }
    }

}
