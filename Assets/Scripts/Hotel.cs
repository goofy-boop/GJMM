using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotel : MonoBehaviour, IInteractable
{
    public GameManager manager;

    public void Interact()
    {
        if (GameManager.dynamite)
        {
            manager.PretAGagner();
        }
    }
}
