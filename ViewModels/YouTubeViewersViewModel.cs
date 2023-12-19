using System.Windows.Input;

namespace YoutubeProjeto.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel YouTubeViewerListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }

        public ICommand AddYouTubeViewersCommand { get; }

        public YouTubeViewersViewModel()
        {
            YouTubeViewerListingViewModel = new YouTubeViewersListingViewModel();
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
    }
    }
}
