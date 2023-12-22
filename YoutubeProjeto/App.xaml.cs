using System.Windows;
using YoutubeProjeto.Stores;
using YoutubeProjeto.ViewModels;

namespace YoutubeProjeto;

public partial class App : Application
{
    private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

    public App()
    {
        _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow = new MainWindow()
        {
            DataContext = new YouTubeViewersViewModel(_selectedYouTubeViewerStore)
        };
        MainWindow.Show();
        base.OnStartup(e);
    }
}

