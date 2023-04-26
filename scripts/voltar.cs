using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voltar : MonoBehaviour
{
    public float tempo;
    [SerializeField] private AudioSource backSFX;    

    public void Voltz()
    {
        backSFX.Play();
        Invoke("backDelay", tempo); 
    }

     void backDelay()
    {
      SceneManager.LoadScene("stageselec");
    }
}
