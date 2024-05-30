using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gameObject.activeSelf != true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
