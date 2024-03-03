using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PhotonStatus : MonoBehaviour
{
    public TextMeshProUGUI textField;

    void FixedUpdate()
    {
        this.textField.text = PhotonNetwork.NetworkClientState.ToString();
    }
}
