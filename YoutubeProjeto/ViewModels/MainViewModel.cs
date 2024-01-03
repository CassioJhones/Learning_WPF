﻿using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;
public class MainViewModel : ViewModelBase
{
    private readonly ModalNavigationStore _modalNavigationStore;
    public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
    public bool IsModalOpen => _modalNavigationStore.IsOpen;

    public YouTubeViewersViewModel YouTubeViewersViewModel { get; }

    public MainViewModel(ModalNavigationStore modalNavigationStore, YouTubeViewersViewModel youTubeViewersViewModel)
    {
        _modalNavigationStore = modalNavigationStore;
        YouTubeViewersViewModel = youTubeViewersViewModel;

        _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;

        _modalNavigationStore.CurrentViewModel = new EditYouTubeViewerViewModel();
    }


    protected override void Dispose()
    {
        _modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrentViewModelChanged;

        base.Dispose();
    }

    private void ModalNavigationStore_CurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentModalViewModel));
        OnPropertyChanged(nameof(IsModalOpen));
    }
}
