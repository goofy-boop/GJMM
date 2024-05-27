using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BobLaBomb"))
        {
            manager.Perdre();
        }
    }
}
