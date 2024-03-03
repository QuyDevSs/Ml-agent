using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class PhotonJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField inputRoomName;

    private void Start()
    {
        this.inputRoomName.text = "SaiGame";
    }

    public virtual void JoinRoom()
    {
        string name = inputRoomName.text;
        Debug.Log(transform.name + ": JoinRoom " + name);
        PhotonNetwork.JoinRoom(name);
    }
}
