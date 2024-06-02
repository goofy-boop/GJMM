using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porte : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        if (GameManager.dynamite)
        {
            SceneManager.LoadScene("MenuDepart");
        }
        else
        {
            return;
        }
    }
}
