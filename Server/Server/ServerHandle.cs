using System;
using System.Numerics;

namespace Server
{
    public class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
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

        public static void PlayerMovement(int _fromClient, Packet _packet)
        {
            bool[] _inputs = new bool[_packet.ReadInt()];
            for (int _i = 0; _i < _inputs.Length; _i++)
            {
                _inputs[_i] = _packet.ReadBool();
            }

            Quaternion _rotation = _packet.ReadQuaternion();

            Server.clients[_fromClient].player.SetInput(_inputs, _rotation);
        }

    }
}
