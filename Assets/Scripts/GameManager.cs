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

    public TMP_Text itd, rdm;

    bool dIndique;

    string itdDeb;

    bool pg;

    float itdCd = 30f;


    private void Awake()
    {
        tempsMax = tempsRestant;
        ecranDeMort.SetActive(false);
        time = Time.timeScale;
        dynamite = false;
        fruitsManges = 0f;
        dIndique = false;
        bombEnPlace.SetActive(false);
        itdDeb = itd.text;
        Time.timeScale = time;
        pg = false;
    }

    private void Update()
    {
        if (!pg)
        {
            tempsRestant -= 1 * Time.deltaTime;

            if (tempsRestant <= 0f)
            {
                Perdre();
            }
        }
        else
        {
            itdCd -= Time.deltaTime;
            itd.text = Mathf.RoundToInt(itdCd).ToString();

            if (itdCd <= 0)
            {
                rdm.text = "the bomb exploded. be faster.";
                Perdre();
            }
        }

        if (fruitsManges >= 10f)
        {
            dynamite = true;
            StartCoroutine(IndicateurDynamite());
            dIndique = true;
            itd.gameObject.SetActive(true);
            itd.text = itdDeb;
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

        itd.gameObject.SetActive(true);
        pg = true;
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
