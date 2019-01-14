using System;
using training.model.player;
using training.model.playlistEnumerable;
using System.Collections.Generic;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = "";
      Console.WriteLine("初始化程式～");
      iPlayer player = new Player1();
      iPlaylistEnumerable playlist = new PlaylistEnumerable();
      do
      {
        path = playlist.getNext();
        if (String.IsNullOrEmpty(path) || path.Equals("exit")) break;
        player.initPlayer(path);
        player.play();
        player.stop();
      } while (true);
      player.dispose();
    }
  }
}
