using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Lobby : MonoBehaviour
{
    public GameObject connectionOptions;
    public LobbyScreen lobbyScreen;
    public GameObject enterAddressScreen;
    NetworkLobbyManager networkLobbyManager;
    NetworkClient networkClient;
    List<GameObject> screens;

    void Awake()
    {
        networkLobbyManager = GetComponent<NetworkLobbyManager>();
        screens = new List<GameObject>();
        screens.Add(connectionOptions);
        screens.Add(lobbyScreen.gameObject);
        screens.Add(enterAddressScreen);

        ChangeScreen(connectionOptions);
    }

    public void ChangeScreen(GameObject newScreen)
    {
        foreach (var screen in screens)
        {
            if (screen != newScreen)
            {
                screen.SetActive(false);
            }
        }
        newScreen.SetActive(true);
    }

    public void Host()
    {
        networkClient = networkLobbyManager.StartHost();
        ChangeScreen(lobbyScreen.gameObject);
        lobbyScreen.SetTitle("Host lobby");
    }

    public void EnterAddress()
    {
        ChangeScreen(enterAddressScreen);
    }

    public void SetConnectionAddress(string address)
    {
        networkLobbyManager.networkAddress = address;
    }

    public void Join()
    {
        networkClient = networkLobbyManager.StartClient();
        ChangeScreen(lobbyScreen.gameObject);
        lobbyScreen.SetTitle("Player lobby");
    }

    public void Disconnect()
    {
        networkClient = null;
        networkLobbyManager.StopHost();
        ChangeScreen(connectionOptions);
    }
}
