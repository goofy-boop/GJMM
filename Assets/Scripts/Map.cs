using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Animator animateur;

    public float[] variétés;

    public float temps = 90f;
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
            animateur.SetFloat("VarDeMap", Random.Range(0, variétés.Length));
            temps = tempsMax;
        }
    }
}
