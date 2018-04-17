using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkLobbyManager {

    public Lobby lobby;

    public override void OnClientDisconnect(NetworkConnection connection)
    {
        Debug.LogFormat("Client disconnected from {0}", connection.address);
        lobby.CancelConnect();
    }
}
