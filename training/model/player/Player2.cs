using System;
using System.Threading;

namespace training.model.player
{
  class Player2 : iPlayer
  {
    private string videoPath = "";

    public Player2()
    {
      Console.WriteLine("初始化player2");
      Console.WriteLine("初始化player2，參數1");
      Console.WriteLine("初始化player2，參數2");
      Console.WriteLine("初始化player2，參數3");
    }
    public void initPlayer(string path)
    {
      videoPath = path;
      Console.WriteLine($"設定播放影片：{path}");
    }
    public void play()
    {
      Console.WriteLine($"player2開始播放影片{videoPath}");
    }
    public void pause()
    {
      Console.WriteLine("player2暫停播放");
    }
    public void stop()
    {
      Console.WriteLine($"player2停止播放:{videoPath}");
    }
    public void dispose()
    {
      Console.WriteLine("釋放player2資源");
    }
  }
}