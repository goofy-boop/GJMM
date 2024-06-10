using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Animator animateur;

    public float[] variétés;

    public float temps = 90f;

    public GameObject blur;

    public AudioSource audio;

    float tempsMax;

    // Start is called before the first frame update
    void Start()
    {
        animateur.SetFloat("VarDeMap", Random.Range(0, variétés.Length));
        tempsMax = temps;
    }

    // Update is called once per frame
    void Update()
    {
        temps -= Time.deltaTime;

        if (temps <= 0f)
        {
            audio.Play();
            animateur.SetFloat("VarDeMap", Random.Range(0, variétés.Length));
            StartCoroutine(Blur());
            temps = tempsMax;
        }
    }

    IEnumerator Blur()
    {
        blur.SetActive(true);
        yield return new WaitForSeconds(2f);
        blur.SetActive(false);
    }
}
