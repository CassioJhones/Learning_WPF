using System.Collections.ObjectModel;
using YoutubeProjeto.Models;
using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersListingViewModel : ViewModelBase
{
    private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
    private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

    public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewerListingItemViewModels => _youTubeViewersListingItemViewModels;
    private YouTubeViewersListingItemViewModel _selectedYouTubeViewersListingItemViewModel;
    public YouTubeViewersListingItemViewModel SelectedYouTubeViewerListingItemViewModel
    {
        get
        {
            return _selectedYouTubeViewersListingItemViewModel;
        }
        set
        {
            _selectedYouTubeViewersListingItemViewModel = value;
            OnPropertyChanged(nameof(SelectedYouTubeViewerListingItemViewModel));

            _selectedYouTubeViewerStore.SelectedYoutubeViewer = _selectedYouTubeViewersListingItemViewModel?.YouTubeViewer;
        }
    }



    public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
    {
        _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
        _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Alexandre",true, true)));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Joacks", false, true)));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Lucas",true, false)));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("David", false, false)));
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Bruno",true, false)));
    }
}
