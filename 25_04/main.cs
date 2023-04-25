using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    [SerializeField] private AudioSource clicSFX;
    [SerializeField] private AudioSource backSFX;
    public void cinema()
    {
       clicSFX.Play();
       SceneManager.LoadScene("SampleScene"); 
    }

    public void maior()
    {
       clicSFX.Play();
       SceneManager.LoadScene("maior"); 
    }
    
    public void media()
    {
       clicSFX.Play();
       SceneManager.LoadScene("media"); 
    }

    public void intervalo()
    {
       clicSFX.Play();
       SceneManager.LoadScene("intervalo"); 
    }

    public void potencia()
    {
       clicSFX.Play();
       SceneManager.LoadScene("Potencia"); 
    }

    public void status()
    {
       clicSFX.Play();
       SceneManager.LoadScene("status"); 
    }

    public void voltar()
    {
       backSFX.Play();
       SceneManager.LoadScene("main"); 
    }

}
