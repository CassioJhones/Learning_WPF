using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;
public class MainViewModel : ViewModelBase
{
    private readonly ModalNavigationStore _modalNavigationStore;
    public YouTubeViewersViewModel YouTubeViewersViewModel { get; }

    public MainViewModel(ModalNavigationStore modalNavigationStore, YouTubeViewersViewModel youTubeViewersViewModel)
    {
        YouTubeViewersViewModel = youTubeViewersViewModel;
        _modalNavigationStore = modalNavigationStore;
    }

}
