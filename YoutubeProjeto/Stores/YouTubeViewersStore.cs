using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeProjeto.Models;

namespace YoutubeProjeto.Stores;
public  class YouTubeViewersStore
{
    event Action<YouTubeViewer> YouTubeViewerAdded;
    public async Task Add(YouTubeViewer youTubeViewer)
    {
        YouTubeViewerAdded?.Invoke(youTubeViewer);
    }

}
