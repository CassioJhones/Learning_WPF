using System.Windows;
using YoutubeProjeto.ViewModels;

namespace YoutubeProjeto;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow = new MainWindow()
        {
            DataContext = new YouTubeViewersViewModel()
        };
        MainWindow.Show();
        base.OnStartup(e);
    }
}

