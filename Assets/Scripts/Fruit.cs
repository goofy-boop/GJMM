using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour, IInteractable
{
    public GameManager manager;
    public AudioSource audio;

    public void Interact()
    {
        AudioSource.PlayClipAtPoint(audio.clip, transform.position, 1f);
        manager.RedemarrerLeCompteAReboure();
        gameObject.SetActive(false);
    }
}
