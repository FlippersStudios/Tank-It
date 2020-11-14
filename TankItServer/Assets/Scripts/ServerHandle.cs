using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerHandle
{
    public static void WelcomeReceived(int _fromClient, Packet _packet)
    {
        int _clientIdCheck = _packet.ReadInt();
        string _username = _packet.ReadString();


        Debug.Log(
            $"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} - connected successfully and is now player: {_fromClient}");
        if (_fromClient != _clientIdCheck)
        {
            Debug.Log(
                $"Player: \"{_username}\"  (ID: {_fromClient}) has assumed the wrong client ID: ({_clientIdCheck})!");
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

        Server.clients[_fromClient].player.SetInput(_inputs);
    }

    public static void PlayerShoot(int _fromClient, Packet _packet)
    {
        Vector3 _shootDirection = _packet.ReadVector3();
        
        Server.clients[_fromClient].player.Shoot(_shootDirection);
    }
}