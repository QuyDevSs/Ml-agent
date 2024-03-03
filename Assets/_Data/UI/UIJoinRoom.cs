using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIJoinRoom : MonoBehaviour
{
    public virtual void Clicked()
    {
        SceneManager.LoadScene("2_join_room");
    }
}
