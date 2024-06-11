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

    public AudioClip indictionDynamite;

    public static bool peutGagner = false;

    public GameObject bombEnPlace;

    bool dIndique;


    private void Awake()
    {
        tempsMax = tempsRestant;
        ecranDeMort.SetActive(false);
        time = Time.timeScale;
        dynamite = false;
        fruitsManges = 0f;
        dIndique = false;
        bombEnPlace.SetActive(false);
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
            StartCoroutine(IndicateurDynamite());
            dIndique = true;
        }
        else
        {
            dynamite = false;
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

    public void PretAGagner()
    {
        peutGagner = true;
        bombEnPlace.SetActive(true);
        fruitsManges = 0f;
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

    IEnumerator IndicateurDynamite()
    {
        if (!dIndique)
        {
            AudioSource.PlayClipAtPoint(indictionDynamite, transform.position, 1f);
            yield return new WaitForSeconds(500);
        }
        else
        {
            yield return new WaitForSeconds(500);
        }
        
    }
}
