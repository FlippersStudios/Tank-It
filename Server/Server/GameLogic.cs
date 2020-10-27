using System;
namespace Server
{
    public class GameLogic
    {
        public static void Update()
        {
            foreach (var _client in Server.clients.Values)
            {
                _client.player?.Update(); // equal to ---> if(_client.player != null){_client.player.Update()}
            }
            ThreadManager.UpdateMain();
        }
    }
}
