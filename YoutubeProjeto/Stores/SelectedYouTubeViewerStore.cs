using YoutubeProjeto.Models;

namespace YoutubeProjeto.Stores;

public class SelectedYouTubeViewerStore
{
    private YouTubeViewer _selectedYoutubeViewer;
    public YouTubeViewer SelectedYoutubeViewer
    {
        get { return _selectedYoutubeViewer; }
        set { _selectedYoutubeViewer = value;
               SelectedYouTubeViewerChanged?.Invoke();
        }
    }

    public event Action SelectedYouTubeViewerChanged;

}
