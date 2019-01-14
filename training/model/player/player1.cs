using System;
using System.Threading;

namespace training.model.player
{
  class player1 : iplayer
  {
    private string videoPath = "";

    public player1()
    {
      Console.WriteLine("初始化player1");
      Console.WriteLine("初始化player1，參數1");
      Console.WriteLine("初始化player1，參數2");
      Console.WriteLine("初始化player1，參數3");
      Console.WriteLine("初始化player1，參數4");
    }
    public void initPlayer(string path)
    {
      videoPath = path;
      Console.WriteLine($"設定播放影片：{path}");
    }
    public void play()
    {
      Console.WriteLine($"player1開始播放影片{videoPath}，睡眠3秒鐘");
      Thread.Sleep(3000);
    }
    public void pause()
    {
      Console.WriteLine("player1暫停播放");
    }
    public void stop()
    {
      Console.WriteLine($"player1停止播放:{videoPath}");
    }
    public void dispose()
    {
      Console.WriteLine("釋放player1資源");
    }
  }
}