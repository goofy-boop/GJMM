using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regarder : MonoBehaviour
{
    public float vitesseDeCamera = 100f;
    public Transform player;

    float xRotation = 0f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float x = Input.GetAxis("Mouse X") * vitesseDeCamera * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * vitesseDeCamera * Time.deltaTime;

        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * x);
    }
}
