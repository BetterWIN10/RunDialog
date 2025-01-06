using System;
using System.Diagnostics;
using RunDialog.ViewModels;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace RunDialog.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(400, 200);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void OKBTN_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string PathToRun = PATH.Text;
            Process process = new Process();
            process.StartInfo.FileName = PathToRun;
            //process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}
