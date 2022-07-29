using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class ServerManager : MonoBehaviourPunCallbacks
{
    private bool _prefabSate = false;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        PhotonNetwork.JoinOrCreateRoom("RoomName:", new RoomOptions {MaxPlayers=4,IsOpen=true,IsVisible=true}, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        if (!_prefabSate)
        {
            PhotonNetwork.Instantiate("Player", new Vector3((int)Random.Range(0, 5), 0.5f, -12.5f), Quaternion.identity, 0, null);
            _prefabSate = true;
        }
        
        else if (_prefabSate)
        {
            PhotonNetwork.Instantiate("Player2", new Vector3((int)Random.Range(-5, 0), 0.5f, -12.5f), Quaternion.identity, 0, null);
            _prefabSate = false;
        }
    }
}