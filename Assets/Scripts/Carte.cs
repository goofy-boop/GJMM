using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte : MonoBehaviour
{
    public GameObject carte;

    private void Awake()
    {
        carte.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
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
