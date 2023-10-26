using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.heartPoint = 10;
            player.Fire(new Knife());
            player.GetHeartPoint(ref player.heartPoint);
            player.Fire(new Revolver());
            player.GetHeartPoint(ref player.heartPoint);
        }
    }
}