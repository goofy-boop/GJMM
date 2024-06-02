using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screamer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BobLaBomb"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            SceneManager.LoadScene("Screamer");
        }
    }
}
