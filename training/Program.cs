using System;
using System.Threading;
using training.model.player;
using training.model.playlistEnumerable;
using System.Collections.Generic;
using System.Threading;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = "";
      Console.WriteLine("初始化程式～");
      iPlayer player = new Player2();
      iPlaylistEnumerable playlist = new PlaylistByFileEnumerable();
      do
      {
        path = playlist.getNext();
        if (String.IsNullOrEmpty(path) || path.Equals("exit")) break;
        player.initPlayer(path);
        player.play();
        Thread.Sleep(3000);
        player.stop();
      } while (true);
      player.dispose();
    }
  }
}
