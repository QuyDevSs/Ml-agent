using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class PhotonCreateRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField inputRoomName;

    private void Start()
    {
        this.inputRoomName.text = "SaiGame";
    }

    public virtual void CreateRoom()
    {
        string name = inputRoomName.text;
        Debug.Log(transform.name + ": CreateRoom " + name);

        RoomOptions options = new RoomOptions { MaxPlayers = 9, PlayerTtl = 10000 };
        PhotonNetwork.CreateRoom(name, options, TypedLobby.Default);
    }
}
