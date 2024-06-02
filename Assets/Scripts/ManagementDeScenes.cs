using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagementDeScenes : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("Jeu");
    }

    public void Quitter()
    {
        Application.Quit();
        Debug.Log("Quitte!");
    }

    public void RetournerAuMenuDeDepart()
    {
        SceneManager.LoadScene("MenuDepart");
    }
}
