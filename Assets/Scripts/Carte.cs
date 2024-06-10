using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte : MonoBehaviour
{
    public GameObject carte;

    public AudioSource audio;

    private void Awake()
    {
        carte.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            audio.Play();
            if (carte.activeSelf != true)
            {
                carte.SetActive(true);
            }
            else
            {
                carte.SetActive(false);
            }
        }
    }
}
