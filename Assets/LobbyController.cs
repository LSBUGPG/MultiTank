using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LobbyController : MonoBehaviour {

	public NetworkManager manager;

	public void StartAsHost()
	{
		manager.StartServer ();
	}
}
