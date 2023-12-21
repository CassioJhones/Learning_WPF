using System.Windows.Input;

namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersViewModel : ViewModelBase
{
    public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
    public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }

    public ICommand AddYouTubeViewersCommand { get; }

    public YouTubeViewersViewModel()
    {
        YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel();
        YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
}
}
