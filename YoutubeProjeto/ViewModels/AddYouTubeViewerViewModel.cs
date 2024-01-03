using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProjeto.ViewModels;
public class AddYouTubeViewerViewModel : ViewModelBase
{
	public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

    public AddYouTubeViewerViewModel()
    {
        YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel();
    }

}
