﻿using System.Net;
using Andreal.Core;
using Andreal.UI;
using Path = Andreal.Core.Path;

namespace Andreal.Utils;

internal static class WebHelper
{
    private static readonly ObjectPool<WebClient> Objpool = new();

    internal static Image GetImage(string url) => new(DownloadImage(url));

    internal static Path DownloadImage(string url, Path? path = null)
    {
        var downloader = Objpool.Get();
        path ??= Path.RandImageFileName();
        downloader.DownloadFile(url, path);
        Objpool.Return(downloader);
        return path;
    }
}
