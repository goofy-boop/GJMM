using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porte : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        if (GameManager.peutGagner)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Win");
        }
        else
        {
            return;
        }
    }
}
