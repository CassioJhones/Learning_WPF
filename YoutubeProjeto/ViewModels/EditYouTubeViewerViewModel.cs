﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeProjeto.Commands;
using YoutubeProjeto.Models;
using YoutubeProjeto.Stores;

namespace YoutubeProjeto.ViewModels;
public class EditYouTubeViewerViewModel : ViewModelBase
{
    public Guid YouTubeViewerId { get; }

    public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

    public EditYouTubeViewerViewModel(YouTubeViewer youTubeViewer, YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
    {
        YouTubeViewerId = youTubeViewer.Id;

        ICommand submitCommand = new EditYouTubeViewerCommand(this, youTubeViewersStore, modalNavigationStore);
        ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
        YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand)
        {
            Username = youTubeViewer.Username,
            IsSubscribed = youTubeViewer.IsSubscribed,
            IsMember = youTubeViewer.IsMember,
        };
    }
}
