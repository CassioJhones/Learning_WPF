using Accessibility;
using System.Windows.Input;

namespace YoutubeProjeto.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public string Username { get;  } 
        public ICommand EditCommand { get;  } 
        public ICommand DeleteCommand { get;  }

        public YouTubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }
    }
}
