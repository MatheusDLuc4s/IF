using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;
    public void Começar()
    {
        clicSFX.Play();
        SceneManager.LoadScene("stageselec");

    }

    public void exit()
    {
        clicSFX.Play();
        print("saiu do jogo");
        Application.Quit();
    }

}
