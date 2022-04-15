﻿using Andreal.Core;
using Andreal.Message;
using Andreal.Model.Pjsk;

namespace Andreal.Utils;

internal static class PjskHelper
{
    internal static (int, SongInfo?[]?) SongNameConverter(IEnumerable<string> command)
    {
        var enumerable = command.ToArray();

        if (enumerable.Length == 0) return (-128, null);

        var song = string.Join("", enumerable);

        return SongInfo.GetByAlias(song);
    }

    internal static TextMessage GetSongAliasErrorMessage(RobotReply info, int status, IEnumerable<SongInfo?> ls) =>
        status switch
        {
            -1 => info.NoSongFound!,
            -2 => ls.Aggregate(info.TooManySongFound, (cur, i) => cur + "\n" + i!.Songname),
            _  => ""
        };
}
