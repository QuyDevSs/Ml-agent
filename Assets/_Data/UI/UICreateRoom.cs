using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UICreateRoom : MonoBehaviour
{
    public virtual void Clicked()
    {
        SceneManager.LoadScene("1_create_room");
    }
}
