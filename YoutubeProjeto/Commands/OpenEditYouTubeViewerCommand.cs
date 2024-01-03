﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeProjeto.Models;
using YoutubeProjeto.Stores;
using YoutubeProjeto.ViewModels;

namespace YoutubeProjeto.Commands;
public class OpenEditYouTubeViewerCommand : CommandBase
{
    private readonly YouTubeViewer _youTubeViewer;
    private readonly ModalNavigationStore _modalNavigationStore;

    public OpenEditYouTubeViewerCommand(
        YouTubeViewer youTubeViewer,
        ModalNavigationStore modalNavigationStore)
    {
        _youTubeViewer = youTubeViewer;
        _modalNavigationStore = modalNavigationStore;
    }

    public override void Execute(object? parameter)
    {
        EditYouTubeViewerViewModel editYouTubeViewerViewModel = new EditYouTubeViewerViewModel(_youTubeViewer,_modalNavigationStore);
        _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
    }
}

