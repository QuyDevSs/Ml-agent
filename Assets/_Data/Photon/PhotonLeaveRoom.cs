using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class PhotonLeaveRoom : MonoBehaviourPunCallbacks
{
    public virtual void LeaveRoom()
    {
        Debug.Log(transform.name+": LeaveRoom");
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
    }
}
