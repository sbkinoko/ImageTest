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

        static AppViewModel objAppViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            objAppViewModel = new AppViewModel();

            objMainWindow = new MainWindow(
                objAppViewModel
                );
            objSubWindow = new SubWindow(
                objAppViewModel
                );

            objMainWindow.Show();
            objSubWindow.Show();
        }
    }

}
