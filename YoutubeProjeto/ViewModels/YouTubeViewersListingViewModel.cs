using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Windows.Input;
using YoutubeProjeto.Commands;
using YoutubeProjeto.Models;
using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersListingViewModel : ViewModelBase
{
    private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
    private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

    public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewerListingItemViewModels => _youTubeViewersListingItemViewModels;
    private YouTubeViewersListingItemViewModel _selectedYouTubeViewerListingItemViewModel;
    public YouTubeViewersListingItemViewModel SelectedYouTubeViewersListingItemViewModel
    {
        get { return _selectedYouTubeViewerListingItemViewModel; }
        set
        {
            _selectedYouTubeViewerListingItemViewModel = value;
            OnPropertyChanged(nameof(SelectedYouTubeViewersListingItemViewModel));

            _selectedYouTubeViewerStore.SelectedYoutubeViewer = _selectedYouTubeViewerListingItemViewModel?.YouTubeViewer;
        }
    }

    public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore, ModalNavigationStore modalNavigationStore)
    {
        _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
        _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

        AddYouTubeViewer(new YouTubeViewer("Alexandre",true, true), modalNavigationStore);
        AddYouTubeViewer(new YouTubeViewer("Joacks", false, true), modalNavigationStore);
        AddYouTubeViewer(new YouTubeViewer("Lucas",true, false), modalNavigationStore);
    }

    private void AddYouTubeViewer(YouTubeViewer youTubeViewer, ModalNavigationStore modalNavigationStore)
    {
        ICommand editCommand = new OpenEditYouTubeViewerCommand(youTubeViewer, modalNavigationStore);
        _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(youTubeViewer,editCommand));

    }

}
