using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text compteARebour;

    public float tempsRestant = 30;

    public GameObject ecranDeMort;

    private float tempsMax;


    private void Awake()
    {
        tempsMax = tempsRestant;
        ecranDeMort.SetActive(false);
    }

    private void Update()
    {
        tempsRestant -= 1 * Time.deltaTime;
        compteARebour.text = Mathf.RoundToInt(tempsRestant).ToString();

        if (tempsRestant <= 0f)
        {
            Perdre();
        }
    }

    public void RedemarrerLeCompteAReboure()
    {
        tempsRestant = tempsMax;
    }

    public void Perdre()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ecranDeMort.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
