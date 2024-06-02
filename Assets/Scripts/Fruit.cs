using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fruit : MonoBehaviour, IInteractable
{
    public GameManager manager;
    public AudioSource audio;
    public NavMeshAgent agent;
    public Transform player;

    public void Interact()
    {
        AudioSource.PlayClipAtPoint(audio.clip, transform.position, 1f);
        manager.RedemarrerLeCompteAReboure();
        manager.Mange();
        gameObject.SetActive(false);
    }

    private void Update()
    {
        agent.SetDestination(-player.position);
    }
}
