using System;
using System.Collections.Generic;
using System.IO;

namespace training.model.playlistEnumerable
{
  class PlaylistByFileEnumerable : iPlaylistEnumerable
  {
    string[] videoPaths;
    int idx = 0;

    public PlaylistByFileEnumerable()
    {
      videoPaths = File.ReadAllLines(System.IO.Path.Combine(System.Environment.CurrentDirectory, "movie-list.txt"));
    }

    public string getNext()
    {
      if (idx < videoPaths.Length)
        return videoPaths[idx++];
      else return "exit";
    }
  }
}