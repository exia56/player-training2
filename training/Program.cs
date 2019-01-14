using System;
using training.model.player;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = "";
      Console.WriteLine("初始化程式～");
      iplayer player = new player1();
      do
      {
        Console.WriteLine("輸入要播放的影片路徑：");
        path = Console.ReadLine();
        if (String.IsNullOrEmpty(path) || path.Equals("exit")) break;
        player.initPlayer(path);
        player.play();
        player.stop();
      } while (true);
      player.dispose();
    }
  }
}
