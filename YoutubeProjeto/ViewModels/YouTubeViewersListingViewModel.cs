using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersListingViewModel : ViewModelBase
{
    private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
    public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;
    public YouTubeViewersListingViewModel()
    {
        _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Alexandre"));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Joacks"));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Fagner"));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("David"));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Pimenta"));

    }
}
