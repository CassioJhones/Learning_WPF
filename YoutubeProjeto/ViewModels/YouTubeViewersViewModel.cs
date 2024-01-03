using System.Windows.Input;
using YoutubeProjeto.Commands;
using YoutubeProjeto.Stores;
namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersViewModel : ViewModelBase
{
    public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
    public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }
    public ICommand AddYouTubeViewersCommand { get; }

    public YouTubeViewersViewModel(YouTubeViewersStore youTubeViewersStore, SelectedYouTubeViewerStore selectedYouTubeViewerStore, ModalNavigationStore modalNavigationStore)
    {
        YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(youTubeViewersStore,selectedYouTubeViewerStore, modalNavigationStore);
        YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel(selectedYouTubeViewerStore);

        AddYouTubeViewersCommand = new OpenAddYouTubeViewerCommand(youTubeViewersStore, modalNavigationStore);
}
}
