using System;
using training.model.player;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("初始化程式～");
      iplayer player = new player1();
      player.initPlayer("video1");
      player.play();
      player.stop();
      player.dispose();
    }
  }
}
