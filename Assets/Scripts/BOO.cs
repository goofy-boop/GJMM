using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOO : MonoBehaviour
{
    public float temps = 15f;
    float tempsMax;

    public GameObject boo;

    public AudioClip audio;

    private void Awake()
    {
        tempsMax = temps;
    }

    void Update()
    {
        temps -= Time.deltaTime;

        if (temps <= 0f)
        {
            boo.SetActive(true);
            AudioSource.PlayClipAtPoint(audio, transform.position, 1f);
            temps = tempsMax;
            boo.SetActive(false);
        }
    }
}
