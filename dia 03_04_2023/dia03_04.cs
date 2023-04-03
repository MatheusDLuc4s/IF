using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dia03_04 : MonoBehaviour
{
     [Header("Tabuada")]
    public int numBase;

    private bool tabuada;

    public void dia_27_03 ()
    {   
        SceneManager.LoadScene("SampleScene");     
    }

    public void Botão()
    {
        SceneManager.LoadScene("meio");
    }

    public void Botão1()
    {
        SceneManager.LoadScene("tabuada");
    }
}

//botões não chamam loops :(
