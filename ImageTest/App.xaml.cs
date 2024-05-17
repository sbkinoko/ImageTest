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
        static SubWindow objEditWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            objMainWindow = new MainWindow();
            objEditWindow = new SubWindow();

            objMainWindow.Show();
            objEditWindow.Show();
        }
    }

}
