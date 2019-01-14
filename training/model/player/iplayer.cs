namespace training.model.player
{
  interface iplayer
  {
    void initPlayer(string path);
    void play();
    void pause();
    void stop();
    void dispose();
  }
}