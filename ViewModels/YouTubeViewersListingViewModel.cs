using System.Collections.ObjectModel;

namespace YoutubeProjeto.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;
        public YouTubeViewersListingViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Alexandre"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Bruno"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Joacks"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Fagner"));

        }
    }
}
