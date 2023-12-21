namespace YoutubeProjeto.ViewModels;

public class YouTubeViewersDetailsViewModel : ViewModelBase
{
    public string Username { get; }
    public string IsSubscribedDisplay { get; }
    public string IsMemberDisplay { get; }

    public YouTubeViewersDetailsViewModel()
    {
        Username = "Cassio";
        IsSubscribedDisplay = "Sim";
        IsMemberDisplay = "Sim";
    }
}
