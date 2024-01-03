using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeProjeto.Stores;
using YoutubeProjeto.ViewModels;

namespace YoutubeProjeto.Commands;
public class OpenAddYouTubeViewerCommand : CommandBase
{
    private readonly ModalNavigationStore _modalNavigationStore;

    public OpenAddYouTubeViewerCommand(ModalNavigationStore modalNavigationStore)
    {
        _modalNavigationStore = modalNavigationStore;
    }

    public override void Execute(object? parameter)
    {
        AddYouTubeViewerViewModel addYouTubeViewerViewModel = new AddYouTubeViewerViewModel(_modalNavigationStore);
        _modalNavigationStore.CurrentViewModel = addYouTubeViewerViewModel;
    }
}
