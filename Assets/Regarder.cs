using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regarder : MonoBehaviour
{
    public float vitesseDeCamera = 100f;
    public Transform player;

    float xRotation = 0f;

    bool povMonstre;

    public Transform monstre;

    public Transform playerCamPos;

    public float distanceMonstre = 5f;

    public LayerMask maskPlayer;

    public Transform romero;

    public Bouger bouger;

    Vector3 romeroPos;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        romeroPos = romero.localPosition;
    }

    private void Update()
    {
        povMonstre = Physics.CheckSphere(monstre.position, distanceMonstre, maskPlayer);

        float x = Input.GetAxis("Mouse X") * vitesseDeCamera * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * vitesseDeCamera * Time.deltaTime;

        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        if (!povMonstre)
        {
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.position = playerCamPos.position;
            romero.rotation = player.rotation;
        }
        else
        {
            transform.position = monstre.position;
            transform.LookAt(player.position);
            bouger.TourneADirectionQueBouge(romero);
        }

        player.Rotate(Vector3.up * x);
        romero.localPosition = romeroPos;
    }
}
