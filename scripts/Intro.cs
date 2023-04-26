using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;

    public float delay;

    public void Começar()
    {
        clicSFX.Play();
        Invoke("MainMenu", delay);
    }

    public void exit()
    {
        clicSFX.Play();
        Invoke("Quit", delay);
        
    }

    void Quit()
    {
        print("saiu do jogo");
        Application.Quit();
    }

    void MainMenu()
    {
        SceneManager.LoadScene("stageselec");
    }

}
