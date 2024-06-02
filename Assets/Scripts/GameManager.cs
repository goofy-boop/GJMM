using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float tempsRestant = 30;

    public GameObject ecranDeMort;

    private float tempsMax;

    float time;

    public static float fruitsManges = 0f;

    public static bool dynamite = false;

    public GameObject bomb;


    private void Awake()
    {
        tempsMax = tempsRestant;
        ecranDeMort.SetActive(false);
        time = Time.timeScale;
        dynamite = false;
        fruitsManges = 0f;
    }

    private void Update()
    {
        tempsRestant -= 1 * Time.deltaTime;

        if (tempsRestant <= 0f)
        {
            Perdre();
        }

        if (fruitsManges >= 10f)
        {
            dynamite = true;
        }

        if (dynamite == true)
        {
            bomb.SetActive(true);
        }
        else
        {
            bomb.SetActive(false);
        }
    }

    public void RedemarrerLeCompteAReboure()
    {
        tempsRestant = tempsMax;
    }

    public void Mange()
    {
        fruitsManges += 1f;
    }

    public void Perdre()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ecranDeMort.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Jouer()
    {
        Time.timeScale = time;
        SceneManager.LoadScene("Jeu");
    }

    public void RetournerAuMenuDeDepart()
    {
        Time.timeScale = time;
        SceneManager.LoadScene("MenuDepart");
    }
}
