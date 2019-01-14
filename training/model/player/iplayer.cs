namespace training.model.player
{
  interface iPlayer
  {
    void initPlayer(string path);
    void play();
    void pause();
    void stop();
    void dispose();
  }
}