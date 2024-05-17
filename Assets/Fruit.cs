using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour, IInteractable
{
    public GameManager manager;

    public void Interact()
    {
        manager.RedemarrerLeCompteAReboure();
        Destroy(gameObject);
    }
}
