using YoutubeProjeto.Models;
using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersDetailsViewModel : ViewModelBase
{
    private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;
    private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYoutubeViewer;

    public bool HasSelectedYouTubeViewer => SelectedYouTubeViewer != null;
    public string Username => SelectedYouTubeViewer?.Username ?? "Desconhecido";
    public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Sim" : "Não";
    public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember ?? false) ? "Sim" : "Não";

    public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
    {
        _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
        _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged;
    }

    protected override void Dispose() 
    {
        _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged;

        base.Dispose();
    }


    private void SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged()
    {
        OnPropertyChanged(nameof(HasSelectedYouTubeViewer));
        OnPropertyChanged(nameof(Username));
        OnPropertyChanged(nameof(IsSubscribedDisplay));
        OnPropertyChanged(nameof(IsMemberDisplay));
    }
}
