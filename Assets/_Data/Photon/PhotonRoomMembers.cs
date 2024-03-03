using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhotonRoomMembers : MonoBehaviourPunCallbacks
{
    public List<TextMeshProUGUI> uiPlayers;
    public List<PlayerInfo> players;

    private void Start()
    {
        this.LoadUIPlayers();
    }

    private void FixedUpdate()
    {
        this.ShowPlayerInRoom();//TODO: not sure this should be here
    }

    protected virtual void LoadUIPlayers()
    {
        Transform step3 = GameObject.Find("Step_3").transform;
        foreach (Transform child in step3)
        {
            TextMeshProUGUI text = child.GetComponent<TextMeshProUGUI>();
            if (text == null) continue;

            this.uiPlayers.Add(text);
        }
    }

    public override void OnJoinedRoom()
    {
        Debug.Log(transform.name + ": OnJoinedRoom");
        this.ShowPlayerInRoom();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(transform.name + ": OnPlayerEnteredRoom");
        this.ShowPlayerInRoom();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log(transform.name + ": OnPlayerLeftRoom");
        this.ShowPlayerInRoom();
    }

    protected virtual void ShowPlayerInRoom()
    {
        this.ClearPlayerInRoom();

        int playerIndex = 0;
        foreach (Player player in PhotonNetwork.PlayerList)
        {
            this.uiPlayers[playerIndex].text = player.NickName;
            Debug.Log(player.NickName);
            playerIndex++;
        }
    }

    protected virtual void ClearPlayerInRoom()
    {
        foreach (TextMeshProUGUI uiPlayer in this.uiPlayers)
        {
            uiPlayer.text = "-";
        }
    }
}
