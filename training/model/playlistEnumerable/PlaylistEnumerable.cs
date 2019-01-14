using System;
using System.Collections.Generic;

namespace training.model.playlistEnumerable
{
  class PlaylistEnumerable : iPlaylistEnumerable
  {
    public PlaylistEnumerable()
    {

    }

    public string getNext()
    {
      Console.WriteLine("請輸入下一個影片播放的影片：");
      return Console.ReadLine();
    }
  }
}