using System;
namespace Server
{
    public class ServerHandle
    {
        public static void WelcomeRecieved(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ReadString();


            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} - connected successfully and is now player: {_fromClient}");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player: \"{_username}\"  (ID: {_fromClient}) has assumed the wrong client ID: ({_clientIdCheck})!");
            }

            //Send player into game
            Server.clients[_fromClient].SendIntoGame(_username);
        }

    }
}
