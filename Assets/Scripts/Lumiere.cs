using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumiere : MonoBehaviour
{
    public GameObject lumiere;

    private void Start()
    {
        lumiere.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (lumiere.activeSelf != true)
            {
                lumiere.SetActive(true);
            }
            else
            {
                lumiere.SetActive(false);
            }
        }
    }
}
