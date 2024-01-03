﻿using System.Windows;
using YoutubeProjeto.Stores;
using YoutubeProjeto.ViewModels;
namespace YoutubeProjeto;

public partial class App : Application
{
    private readonly ModalNavigationStore _modalNavigationStore;
    private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

    public App()
    {
        _modalNavigationStore = new ModalNavigationStore();
        _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        YouTubeViewersViewModel youTubeViewersViewModel = new YouTubeViewersViewModel(_selectedYouTubeViewerStore, _modalNavigationStore);
        MainWindow = new MainWindow()
        {
            DataContext = new MainViewModel(_modalNavigationStore, youTubeViewersViewModel)
        };
        MainWindow.Show();
        base.OnStartup(e);
    }
}

