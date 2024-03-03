using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PhotonLogin : MonoBehaviour
{
    public TMP_InputField inputUsername;

    private void Start()
    {
        this.inputUsername.text = "BeSai";
    }

    public virtual void Login()
    {
        string name = inputUsername.text;
        Debug.Log(transform.name + ": Login " + name);

        PhotonNetwork.LocalPlayer.NickName = name;
        PhotonNetwork.ConnectUsingSettings();
    }
}
